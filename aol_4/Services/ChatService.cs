namespace aol.Services;
public class ChatService
{
    private readonly int port = 6697;
    private readonly string server = "irc.snoonet.org";
    public SimpleIRC irc = new();
    public ConcurrentDictionary<string, List<string>> users = new(); // key: channel, value: users
    public string newPM = "";
    public static ConcurrentDictionary<string, bool> buddyStatus = new(); // key: name, value: online status

    public void DownloadStatusChanged(object source, DCCEventArgs args)
    {
        Debug.WriteLine("DOWNLOAD STATUS: " + args.Status);
        Debug.WriteLine("DOWNLOAD FILENAME: " + args.FileName);
        Debug.WriteLine("DOWNLOAD PROGRESS: " + args.Progress + "%");
    }

    public void ChatOutputCallback(object source, IrcReceivedEventArgs args)
    {
        string msg = args.User + ": " + args.Message;
        Debug.WriteLine("[CO]:" + msg);
        string cleanChannel = args.Channel.Replace("#", "");

        if (args.Channel == Account.tmpUsername) // PRIVMSG
        {
            Debug.WriteLine("RECEIVED PRIVATE MESSAGE FROM " + args.User);
            newPM = args.User;
            string logpath = Application.StartupPath + @"\chatlogs";
            string privateLog = logpath + @"\PM_" + args.User + ".txt";

            if (!Directory.Exists(logpath))
                Directory.CreateDirectory(logpath);
            if (!File.Exists(privateLog))
                File.Create(privateLog).Dispose();

            File.AppendAllText(privateLog, msg + '\n');

            bool foundFrm = false;
            Debug.WriteLine("Checking for open form with username tag");
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Tag == null)
                    continue;

                if (frm.Tag.ToString() == newPM)
                    foundFrm = true;
            } 

            if (!foundFrm)
            {
                Debug.WriteLine("Opening IM for user " + newPM);
                Application.OpenForms[0].Invoke(new MethodInvoker(delegate
                {
                    InstantMessageForm im = new InstantMessageForm(newPM);
                    im.Owner = Application.OpenForms[0];
                    im.MdiParent = Application.OpenForms[0];
                    im.Tag = newPM;
                    im.Show();
                }));
            }
        }
        else
        {
            string logpath = Application.StartupPath + @"\chatlogs";
            string chatlog = logpath + @"\" + cleanChannel + ".txt";
            
            if (!Directory.Exists(logpath))
                Directory.CreateDirectory(logpath);
            if (!File.Exists(chatlog))
                File.Create(chatlog).Dispose();

            File.AppendAllText(chatlog, msg + '\n');
        }
    }

    public void RawOutputCallback(object source, IrcRawReceivedEventArgs args)
    {
        if (Account.tmpUsername == "Guest" || Account.tmpUsername == "" || args.Message == null) // prevents crash if signing off
            return;

        Debug.WriteLine("[RO]:" + args.Message);
        string[] info = args.Message.Split(' ');
        // buddy is offline ([RO]::veronica.snoonet.org 401 erfg12 NeWaGe :No such nick/channel)
        if (args.Message.Contains("No such nick")) // say this when disconnecting from server too
        {
            //Debug.WriteLine("user is dead");
            if (buddyStatus.ContainsKey(info[3].ToLower()))
                buddyStatus[info[3].ToLower()] = false;
        }
        // buddy is online ([RO]::veronica.snoonet.org 318 erfg12 NeWaGe :End of /WHOIS list.)
        else if (args.Message.Contains(" 311 " + Account.tmpUsername))
        {
            //Debug.WriteLine("user is alive!!");
            buddyStatus[info[3].ToLower()] = true;
        }
        else if (args.Message.Contains("NickServ!NickServ@services NOTICE " + Account.tmpUsername + " :       Registered"))
        {
            irc.SendMessageToChannel("IDENTIFY " + Account.tmpPassword, "NickServ");
        }
        else if (args.Message.Contains(" JOIN :#"))
        {
            string chan = args.Message.Substring(args.Message.IndexOf(" JOIN :") + " JOIN :".Length);
            Debug.WriteLine("Getting users list from IRC server: " + chan);
            //irc.GetUsersInCurrentChannel();
            irc.GetUsersInDifferentChannel(chan);
        }
        else if (args.Message.Contains(" PART #"))
        {
            string chan = args.Message.Substring(args.Message.IndexOf(" PART :") + " PART :".Length);
            string logpath = Application.StartupPath + @"\chatlogs";
            //string privateLog = logpath + @"\" + pChat + ".txt";
            string[] getUN = args.Message.Split('!');
            //File.AppendAllText(privateLog, getUN[0] + " has left." + '\n');
            irc.GetUsersInDifferentChannel(chan); // GetUsersInDifferentChannel("#chanName");
        }
        else if(args.Message.Contains(":You need to be identified to a registered account to join this channel"))
        {
            // users needs to register
            Debug.WriteLine("ERROR: IRC nickname needs to be registered.");
            string logpath = Application.StartupPath + @"\chatlogs";
            //string privateLog = logpath + @"\" + pChat + ".txt";
            //File.AppendAllText(privateLog, "IMPORTANT NOTICE: This is a registered users only chatroom. We will send an authentication request to the NickServ. Open an email with the subject \"Nickname registration for " + Account.tmpUsername + "\" please." + '\n');
            //irc.SendMessageToChannel("REGISTER " + Account.tmpPassword + " " + Account.tmpUsername + "@aolemu.com", "NickServ");
        }
        else if (args.Message.Contains("This nickname is registered and protected."))
        {
            // user needs to authenticate
            irc.SendMessageToChannel("IDENTIFY " + Account.tmpPassword, "NickServ");
        }
        // get a channel list
        // command -> /list >200
        // :alamo.snoonet.org 322 NeWaGe_test #beer 58 :[+CFJTfjnrtx 5:60 2 5:1 5:5 10:4] its a !bang (again) | Welcome! Everything you...
        // need to compare channel list with category list -> https://snoonet.org/communities
        else if (args.Message.Contains(" 322 ") && args.Message.Contains("#"))
        {
            string[] chan = args.Message.Split('#');
            string[] chanClean = chan[1].Split(new[] { ' ' }, 2);
            if (chanClean[0] != "")
                Debug.WriteLine(chanClean[0] + " channel is available");
        }
    }

    public void DebugOutputCallback(object source, IrcDebugMessageEventArgs args)
    {
        Debug.WriteLine(args.Type + " | " + args.Message);
        if (args.Message == "STARTING LISTENER!")
        {
            irc.SendMessageToChannel("INFO " + Account.tmpUsername, "NickServ"); // send a request to see if our username is registered
        }
    }

    public void UserListCallback(object source, IrcUserListReceivedEventArgs args)
    {
        if (args.UsersPerChannel.Count <= 0)
            return;

        Debug.WriteLine("Generating user list...");
        Debug.WriteLine("Users in channel: " + args.UsersPerChannel.Count);

        foreach (KeyValuePair<string, List<string>> usersPerChannel in args.UsersPerChannel)
        {
            string channel = usersPerChannel.Key.ToLower();
            channel = channel.Replace("#", "");
            if (!users.ContainsKey(channel)) // sometimes skipped?!
            {
                Debug.WriteLine("Creating users key " + channel);
                if (args.UsersPerChannel.ContainsKey(usersPerChannel.Key))
                    users.TryAdd(channel, args.UsersPerChannel[usersPerChannel.Key]);
                continue;
            }
            // check if offline user is still in list
            for (int i = 0; i < users[channel].Count; i++)
            {
                if (!usersPerChannel.Value.Contains(users[channel][i]))
                    users[channel].Remove(users[channel][i]);
            }
            // if user is not in list, add them
            for (int i = 0; i < usersPerChannel.Value.Count; i++)
            {
                if (usersPerChannel.Value[i] == "") // there's always 1 empty user for some reason
                    continue;
                //Debug.WriteLine("[UL]: " + user);
                if (!users[channel].Contains(usersPerChannel.Value[i]))
                    users[channel].Add(usersPerChannel.Value[i]);
            }
        }
    }

    public void StartConnection()
    {
        if (!Account.SignedIn() || irc.IsClientRunning())
            return;

        StartupIRC();
    }

    public void StartupIRC()
    {
        irc.SetupIrc(server, Account.tmpUsername, "", port, "", 3000, true);

        if (!irc.IsClientRunning())
        {
            Debug.WriteLine($"Connecting to IRC server {server}:{port}...");
            Task.Run(() => irc.StartClient());
        }
    }
}
