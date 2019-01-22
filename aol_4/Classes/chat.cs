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
        public static string pLog = "";
        public static List<string> users = new List<string>();

        public static void downloadStatusChanged(object source, DCCEventArgs args)
        {
            Debug.WriteLine("DOWNLOAD STATUS: " + args.Status);
            Debug.WriteLine("DOWNLOAD FILENAME: " + args.FileName);
            Debug.WriteLine("DOWNLOAD PROGRESS: " + args.Progress + "%");
        }

        public static void chatOutputCallback(object source, IrcReceivedEventArgs args)
        {
            string msg = args.Channel + " | " + args.User + ": " + args.Message;
            Debug.WriteLine(msg);

            File.WriteAllText(pLog, msg);
        }

        public static void rawOutputCallback(object source, IrcRawReceivedEventArgs args)
        {
            // buddy is offline
            if (args.Message.Contains("no such nick/channel"))
            {
                Debug.WriteLine("user is dead");
            }
            // buddy is online
            else if (args.Message.Contains("End of /WHOIS list"))
            {
                Debug.WriteLine("user is alive!!");
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
            else
                Debug.WriteLine(args.Message);
        }

        public static void debugOutputCallback(object source, IrcDebugMessageEventArgs args)
        {
            Debug.WriteLine(args.Type + " | " + args.Message);
        }

        public static void userListCallback(object source, IrcUserListReceivedEventArgs args)
        {
            users.Clear();
            foreach (KeyValuePair<string, List<string>> usersPerChannel in args.UsersPerChannel)
            {
                foreach (string user in usersPerChannel.Value)
                {
                    if (user == "")
                        continue;
                    Debug.WriteLine("ULC: " + user);
                    users.Add(user);
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
