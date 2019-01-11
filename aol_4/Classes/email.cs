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
using aol.Forms;
using MimeKit.Text;
using System.IO;
using System.Web;
using System.Net;
using MailKit.Net.Smtp;

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
                    Debug.WriteLine("[MAIL] YOU'VE GOT NEW MAIL!!");
                    return true;
                }
                else
                    Debug.WriteLine("[MAIL] nothing new");

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
                    //Debug.WriteLine("[MAIL] id:" + message.MessageId + " subj:" + message.Subject);
                    emails.Add(message.MessageId, message.Subject);
                }

                client.Disconnect(true);
            }
        }

        public static void sendEmail(string toName, string toAddress, string subject, string body)
        {
            var message = new MimeMessage();

            string[] accInfo = accounts.getEmailInfo();

            message.From.Add(new MailboxAddress(accounts.getFullName(), accInfo[0]));
            message.To.Add(new MailboxAddress(toName, toAddress));
            message.Subject = subject;

            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;

                client.Connect(accInfo[4], Convert.ToInt32(accInfo[5]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                client.Send(message);
                client.Disconnect(true);
            }
        }

        public static string readEmail(string id)
        {
            string body = "";
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                var items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure);

                foreach (var item in items)
                {
                    body = client.Inbox.GetBodyPart(item.UniqueId, item.TextBody).ToString();
                }

                client.Disconnect(true);
            }
            body = body.Replace(Environment.NewLine, "<br>");
            body = WebUtility.HtmlDecode(body);

            return body;
        }
    }
}
