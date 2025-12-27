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

    public static Dictionary<string, Image> emojis = new()
    {
        { ":-)", Properties.Resources.Smiling },
        { ":-(", Properties.Resources.Frowning },
        { ";-)", Properties.Resources.Winking },
        { ":-P", Properties.Resources.Sticking_out_tongue },
        { "=-O", Properties.Resources.Surprised },
        { ":-*", Properties.Resources.Kissing },
        { ">:o", Properties.Resources.Yelling },
        { "8-)", Properties.Resources.Cool },
        { ":-$", Properties.Resources.Money_mouth },
        { ":-!", Properties.Resources.Foot_in_mouth },
        { ":-[", Properties.Resources.Embarrassed },
        { "O:-)", Properties.Resources.Innocent },
        { ":-\\", Properties.Resources.Undecided },
        { ":'(", Properties.Resources.Crying },
        { ":-X", Properties.Resources.Lips_are_sealed },
        { ":-D", Properties.Resources.Laughing }
    };

    private static Dictionary<string, string> emojiRtfCache = new Dictionary<string, string>();

    public static void ReplaceEmojisWithImage(RichTextBox rtb, string text)
    {
        int startIndex = rtb.TextLength;
        rtb.AppendText(" " + text);

        bool wasReadOnly = rtb.ReadOnly;
        rtb.ReadOnly = false;

        float dpiScale = rtb.DeviceDpi / 96f;
        int fontPx = rtb.Font.Height;

        // Build the RTF cache if needed
        if (emojiRtfCache.Count == 0)
        {
            foreach (var emoji in emojis)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    emoji.Value.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    string hex = BitConverter.ToString(ms.ToArray()).Replace("-", "");

                    // size emoji to match text height, DPI-aware
                    int goal = (int)(fontPx * 15 / dpiScale);

                    string imageRtf =
                        @"{\rtf1{\pict\pngblip" +
                        @"\picw" + (emoji.Value.Width * 26) +
                        @"\pich" + (emoji.Value.Height * 26) +
                        @"\picwgoal" + goal +
                        @"\pichgoal" + goal +
                        " " + hex + "}}";

                    emojiRtfCache[emoji.Key] = imageRtf;
                }
            }
        }

        List<(int index, int length, string rtf)> replacements = new();

        foreach (var emoji in emojis.OrderByDescending(e => e.Key.Length))
        {
            if (!text.Contains(emoji.Key))
                continue;

            int index = startIndex;

            while (index < rtb.TextLength)
            {
                index = rtb.Find(emoji.Key, index, RichTextBoxFinds.None);
                if (index == -1)
                    break;

                replacements.Add((index, emoji.Key.Length, emojiRtfCache[emoji.Key]));
                index += emoji.Key.Length;
            }
        }

        replacements = replacements.OrderByDescending(r => r.index).ToList();

        IDataObject clipboardBackup = null;
        try { clipboardBackup = Clipboard.GetDataObject(); } catch { }

        foreach (var replacement in replacements)
        {
            rtb.Select(replacement.index, replacement.length);

            for (int retry = 0; retry < 3; retry++)
            {
                try
                {
                    Clipboard.SetText(replacement.rtf, TextDataFormat.Rtf);
                    rtb.Paste();
                    break;
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    if (retry < 2)
                        System.Threading.Thread.Sleep(50);
                }
            }
        }

        try
        {
            if (clipboardBackup != null)
                Clipboard.SetDataObject(clipboardBackup, false);
        }
        catch { }

        rtb.ReadOnly = wasReadOnly;
    }

    public void PrivateMessageReceived(string user, string message)
    {
        string msg = $"{user}: {message}";

        string chatFile = string.Empty;

        newPM = user;
        chatFile = ChatHelper.GetChatPath(Account.tmpUsername, $"PM_{user}");

        // open IM form if needed
        bool foundFrm = false;
        foreach (Form frm in Application.OpenForms)
        {
            if (frm.Tag?.ToString().ToLower() == newPM.ToLower())
                foundFrm = true;
        }
        if (!foundFrm)
        {
            Application.OpenForms[0].Invoke(() =>
            {
                InstantMessageForm im = new InstantMessageForm(newPM)
                {
                    Owner = Application.OpenForms[0],
                    MdiParent = Application.OpenForms[0],
                    Tag = newPM
                };
                im.Show();
            });
        }

        File.AppendAllText(chatFile, msg + '\n');
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
            if (buddyStatus.ContainsKey(info[3]))
                buddyStatus[info[3]] = false;
        }
        // buddy is online ([RO]::veronica.snoonet.org 318 erfg12 NeWaGe :End of /WHOIS list.)
        else if (args.Message.Contains(" 311 " + Account.tmpUsername))
        {
            buddyStatus[info[3]] = true;
        }
        else if (args.Message.Contains("NickServ!NickServ@services NOTICE " + Account.tmpUsername + " :       Registered"))
        {
            irc.SendMessageToChannel("IDENTIFY " + Account.tmpPassword, "NickServ");
        }
        else if (args.Message.Contains(" JOIN :#"))
        {
            string chan = args.Message.Substring(args.Message.IndexOf(" JOIN :") + " JOIN :".Length);
            chan = chan.ToLower();
            Debug.WriteLine("Getting users list from IRC server: " + chan);
            //irc.GetUsersInCurrentChannel();
            irc.GetUsersInDifferentChannel(chan);
        }
        // [RO]::testaccount3!Jake@Snoonet-ksn.e7k.pkq6pe.IP PART #PlayStation :Leaving
        else if (args.Message.Contains(" :Leaving"))
        {
            string chan = args.Message.Split(' ').FirstOrDefault(part => part.StartsWith("#"));
            chan = chan.ToLower();
            irc.GetUsersInDifferentChannel(chan);
        }
        else if(args.Message.Contains(" isn't registered."))
        {
            // users needs to register
            Debug.WriteLine("ERROR: IRC nickname needs to be registered.");
            irc.SendMessageToChannel($"REGISTER {Account.tmpPassword} {Account.tmpUsername}@aolemu.com", "NickServ");
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
        else if (args.Message.Contains("PRIVMSG"))
        {
            // Split prefix, command, target, message
            // :prefix PRIVMSG target :message
            var msg = args.Message.Split($"PRIVMSG {Account.tmpUsername} :");
            var senderNick = args.Message.Split('!')[0].TrimStart(':');

            Debug.WriteLine($"Private message from {senderNick}: {msg.LastOrDefault()}");
            PrivateMessageReceived(senderNick, msg.LastOrDefault());
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
