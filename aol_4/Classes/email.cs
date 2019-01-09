using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using MailKit.Search;
using System.Diagnostics;

namespace aol.Classes
{
    class email
    {
        public static Dictionary<string, string> emails = new Dictionary<string, string>();

        public static bool checkNewEmail()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);
                
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                if (inbox.Search(SearchQuery.NotSeen).Count() > 0)
                {
                    Debug.WriteLine("YOU'VE GOT MAIL!!");
                    return true;
                }
                else
                    Debug.WriteLine("no new mail");

                client.Disconnect(true);

                return false;
            }
        }

        public static void getEmail()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    Debug.WriteLine("[MAIL] id:" + message.MessageId + " subj:" + message.Subject);
                    emails.Add(message.MessageId, message.Subject);
                }

                client.Disconnect(true);
            }
        }
    }
}
