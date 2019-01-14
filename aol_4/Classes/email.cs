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
        public static Dictionary<string, string> emailsNew = new Dictionary<string, string>();
        public static Dictionary<string, string> emailsOld = new Dictionary<string, string>();
        public static Dictionary<string, string> emailsSent = new Dictionary<string, string>();
        public static string reply = "";

        public static bool checkNewEmail()
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;

                if (accInfo[2] == "" || accInfo[0] == "" || accInfo[1] == "")
                {
                    Debug.WriteLine("[MAIL] Missing some information, can't login.");
                    return false;
                }
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
            if (accounts.tmpUsername == "Guest" || accounts.tmpUsername == "")
                return;

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;

                if (accInfo[2] == "" || accInfo[0] == "" || accInfo[1] == "")
                {
                    Debug.WriteLine("[MAIL] Missing some information, can't login.");
                    return;
                }
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // new emails
                var uids = inbox.Search(SearchQuery.NotSeen);
                var items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Envelope | MessageSummaryItems.Flags);
                foreach (var i in items)
                {
                    if (i.Flags == MessageFlags.Deleted) continue;
                    var message = inbox.GetMessage(i.UniqueId);
                    //Debug.WriteLine("[MAIL] new id:" + message.MessageId + " subj:" + message.Subject);
                    emailsNew.Add(message.MessageId, message.Subject);
                }

                // old emails
                uids = inbox.Search(SearchQuery.Seen);
                items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Envelope | MessageSummaryItems.Flags);
                foreach (var i in items)
                {
                    var message = inbox.GetMessage(i.UniqueId);
                    //Debug.WriteLine("[MAIL] old id:" + message.MessageId + " subj:" + message.Subject);
                    emailsOld.Add(message.MessageId, message.Subject);
                }

                var outbox = client.GetFolder(SpecialFolder.Sent);
                outbox.Open(FolderAccess.ReadOnly);

                // sent emails
                for (int i = 0; i < outbox.Count; i++)
                {
                    var message = outbox.GetMessage(i);
                    //Debug.WriteLine("[MAIL] sent id:" + message.MessageId + " subj:" + message.Subject);
                    emailsSent.Add(message.MessageId, message.Subject);
                }

                client.Disconnect(true);
            }
        }

        public static void deleteEmail(string id)
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                inbox.AddFlags(uids.First(), MessageFlags.Deleted, true);
                var matchFolder = client.GetFolder(SpecialFolder.Trash);
                if (matchFolder != null)
                    inbox.MoveTo(uids.First(), matchFolder);
            }
        }

        public static void markAsSeen(string id)
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                inbox.AddFlags(uids.First(), MessageFlags.Seen, true);
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
            TextPart rawBody = null;
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                reply = ""; // clear before we start

                string[] accInfo = accounts.getEmailInfo();

                bool useSSL = Convert.ToInt32(accInfo[6]) != 0;
                client.Connect(accInfo[2], Convert.ToInt32(accInfo[3]), useSSL);
                client.Authenticate(accInfo[0], accInfo[1]);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                var items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Envelope);

                foreach (var item in items)
                {
                    if (item.TextBody != null)
                    {
                        rawBody = (TextPart) inbox.GetBodyPart(item.UniqueId, item.TextBody);
                        //var html = inbox.GetBodyPart(item.UniqueId, item.TextBody);
                    }

                    foreach (InternetAddress rt in item.Envelope.ReplyTo)
                    {
                        reply = reply + rt.ToString() + ";";
                    }
                    
                    //Debug.WriteLine("[MAIL] ReplyTo: " + item.Envelope.ReplyTo.First().ToString());
                    //Debug.WriteLine("[MAIL] Sender: " + item.Envelope.Sender.First().ToString());
                    //Debug.WriteLine("[MAIL] From: " + item.Envelope.From.First().ToString());
                }

                client.Disconnect(true);
            }
            body = rawBody.Text.Replace(Environment.NewLine, "<br>");
            body = WebUtility.HtmlDecode(body);

            return body;
        }
    }
}
