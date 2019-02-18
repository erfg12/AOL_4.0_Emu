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

            if (args.Channel == accounts.tmpUsername) // PRIVMSG
            {
                newPM = args.User;
                string logpath = Application.StartupPath + @"\chatlogs";
                string privateLog = logpath + @"\PM_" + args.User + ".txt";

                if (!Directory.Exists(logpath))
                    Directory.CreateDirectory(logpath);
                if (!File.Exists(privateLog))
                    File.Create(privateLog).Dispose();

                File.AppendAllText(privateLog, msg + '\n');
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
            string[] info = args.Message.Split(' ');
            // buddy is offline ([RO]::veronica.snoonet.org 401 erfg12 NeWaGe :No such nick/channel)
            if (args.Message.Contains("No such nick/channel"))
            {
                //Debug.WriteLine("user is dead");
                buddyStatus[info[3]] = false;
            }
            // buddy is online ([RO]::veronica.snoonet.org 318 erfg12 NeWaGe :End of /WHOIS list.)
            else if (args.Message.Contains(" 311 " + accounts.tmpUsername))
            {
                //Debug.WriteLine("user is alive!!");
                buddyStatus[info[3]] = true;
            }
            else if (args.Message.Contains(" JOIN :#"))
            {
                irc.GetUsersInCurrentChannel(); // GetUsersInDifferentChannel("#chanName");
            }
            else if (args.Message.Contains(" PART #"))
            {
                string logpath = Application.StartupPath + @"\chatlogs";
                string privateLog = logpath + @"\" + pChat + ".txt";
                string[] getUN = args.Message.Split('!');
                File.AppendAllText(privateLog, getUN[0] + " has left." + '\n');
                irc.GetUsersInCurrentChannel(); // GetUsersInDifferentChannel("#chanName");
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
            //else
                Debug.WriteLine("[RO]:" + args.Message);
        }

        public static void debugOutputCallback(object source, IrcDebugMessageEventArgs args)
        {
            Debug.WriteLine(args.Type + " | " + args.Message);
        }

        public static void userListCallback(object source, IrcUserListReceivedEventArgs args)
        {
            foreach (KeyValuePair<string, List<string>> usersPerChannel in args.UsersPerChannel)
            {
                if (!users.ContainsKey(usersPerChannel.Key))
                {
                    Debug.WriteLine("Creating users key " + usersPerChannel.Key);
                    users.Add(usersPerChannel.Key.Replace("#",""), args.UsersPerChannel[usersPerChannel.Key]);
                    continue;
                }
                // check if offline user is still in list
                for (int i = 0; i < users[usersPerChannel.Key].Count; i++)
                {
                    if (!usersPerChannel.Value.Contains(users[usersPerChannel.Key][i]))
                        users[usersPerChannel.Key].Remove(users[usersPerChannel.Key][i]);
                }
                // if user is not in list, add them
                for (int i = 0; i < usersPerChannel.Value.Count; i++)
                {
                    if (usersPerChannel.Value[i] == "") // there's always 1 empty user for some reason
                        continue;
                    //Debug.WriteLine("[UL]: " + user);
                    if (!users[usersPerChannel.Key].Contains(usersPerChannel.Value[i]))
                        users[usersPerChannel.Key].Add(usersPerChannel.Value[i]);
                }
            }
        }

        public static void startConnection()
        {
            if (accounts.tmpUsername == "Guest" || accounts.tmpUsername == "")
                return;

            Task taskA = new Task(() =>
            {
                irc.SetupIrc(server, accounts.tmpUsername, "", port, "", 5000, true);

                irc.IrcClient.OnDebugMessage += debugOutputCallback;
                irc.IrcClient.OnMessageReceived += chatOutputCallback;
                irc.IrcClient.OnRawMessageReceived += rawOutputCallback;
                irc.IrcClient.OnUserListReceived += userListCallback;

                //irc.DccClient.OnDccDebugMessage += dccDebugCallback;
                irc.DccClient.OnDccEvent += downloadStatusChanged;

                irc.StartClient();

                while (!irc.IsClientRunning())
                {
                    Debug.WriteLine("not connected yet");
                    Thread.Sleep(1000); // wait 1 sec
                }
            });
            taskA.Start();
        }
    }
}
