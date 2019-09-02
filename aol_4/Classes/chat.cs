using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using aol.Forms;
using SimpleIRCLib;
using System.IO;
using System.Windows.Forms;

namespace aol.Classes
{
    class chat
    {
        private static int port = 6697;
        private static string server = "irc.snoonet.org";
        public static SimpleIRC irc = new SimpleIRC();
        public static string pChat = "";
        public static Dictionary<string, List<string>> users = new Dictionary<string, List<string>>(); // key: channel, value: users
        public static string newPM = "";
        public static Dictionary<string, bool> buddyStatus = new Dictionary<string, bool>(); // key: name, value: online status

        public static void downloadStatusChanged(object source, DCCEventArgs args)
        {
            Debug.WriteLine("DOWNLOAD STATUS: " + args.Status);
            Debug.WriteLine("DOWNLOAD FILENAME: " + args.FileName);
            Debug.WriteLine("DOWNLOAD PROGRESS: " + args.Progress + "%");
        }

        public static void chatOutputCallback(object source, IrcReceivedEventArgs args)
        {
            string msg = args.User + ": " + args.Message;
            Debug.WriteLine("[CO]:" + msg);
            string cleanChannel = args.Channel.Replace("#", "");

            if (args.Channel == accForm.tmpUsername) // PRIVMSG
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
                        instant_message im = new instant_message(newPM);
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

        public static void rawOutputCallback(object source, IrcRawReceivedEventArgs args)
        {
            if (accForm.tmpUsername == "Guest" || accForm.tmpUsername == "") // prevents crash if signing off
                return;

            Debug.WriteLine("[RO]:" + args.Message);
            string[] info = args.Message.Split(' ');
            // buddy is offline ([RO]::veronica.snoonet.org 401 erfg12 NeWaGe :No such nick/channel)
            if (args.Message.Contains("No such nick/channel"))
            {
                //Debug.WriteLine("user is dead");
                buddyStatus[info[3]] = false;
            }
            // buddy is online ([RO]::veronica.snoonet.org 318 erfg12 NeWaGe :End of /WHOIS list.)
            else if (args.Message.Contains(" 311 " + accForm.tmpUsername))
            {
                //Debug.WriteLine("user is alive!!");
                buddyStatus[info[3]] = true;
            }
            else if (args.Message.Contains("NickServ!NickServ@services NOTICE " + accForm.tmpUsername + " :       Registered"))
            {
                irc.SendMessageToChannel("IDENTIFY " + accForm.tmpPassword, "NickServ");
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
                string logpath = Application.StartupPath + @"\chatlogs";
                string privateLog = logpath + @"\" + pChat + ".txt";
                string[] getUN = args.Message.Split('!');
                File.AppendAllText(privateLog, getUN[0] + " has left." + '\n');
                irc.GetUsersInCurrentChannel(); // GetUsersInDifferentChannel("#chanName");
            }
            else if(args.Message.Contains(":You need to be identified to a registered account to join this channel"))
            {
                // users needs to register
                Debug.WriteLine("ERROR: IRC nickname needs to be registered.");
                string logpath = Application.StartupPath + @"\chatlogs";
                string privateLog = logpath + @"\" + pChat + ".txt";
                File.AppendAllText(privateLog, "IMPORTANT NOTICE: This is a registered users only chatroom. We will send an authentication request to the NickServ. Open an email with the subject \"Nickname registration for " + accForm.tmpUsername + "\" please." + '\n');
                irc.SendMessageToChannel("REGISTER " + accForm.tmpPassword + " " + accForm.tmpUsername + "@aolemu.com", "NickServ");
            }
            else if (args.Message.Contains("This nickname is registered and protected."))
            {
                // user needs to authenticate
                irc.SendMessageToChannel("IDENTIFY " + accForm.tmpPassword, "NickServ");
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

        public static void debugOutputCallback(object source, IrcDebugMessageEventArgs args)
        {
            Debug.WriteLine(args.Type + " | " + args.Message);
            if (args.Message == "STARTING LISTENER!")
            {
                irc.SendMessageToChannel("INFO " + accForm.tmpUsername, "NickServ"); // send a request to see if our username is registered
            }
        }

        public static void userListCallback(object source, IrcUserListReceivedEventArgs args)
        {
            Debug.WriteLine("Creating user list...");
            Debug.WriteLine("Users in channel: " + args.UsersPerChannel.Count);

            foreach (KeyValuePair<string, List<string>> usersPerChannel in args.UsersPerChannel)
            {
                string channel = usersPerChannel.Key.ToLower();
                channel = channel.Replace("#", "");
                if (!users.ContainsKey(channel))
                {
                    Debug.WriteLine("Creating users key " + channel);
                    users.Add(channel, args.UsersPerChannel[usersPerChannel.Key]);
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

        public static void startConnection()
        {
            if (accForm.tmpUsername == "Guest" || accForm.tmpUsername == "" || irc.IsClientRunning())
                return;

            Task taskA = new Task(() =>
            {
                irc.SetupIrc(server, accForm.tmpUsername, "", port, "", 1000, true);

                if (!irc.IsClientRunning())
                    irc.StartClient();

                while (!irc.IsClientRunning())
                {
                    Debug.WriteLine("not connected yet");
                    Thread.Sleep(250); // wait
                }
            });
            taskA.Start();
        }
    }
}
