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
using System.Windows.Forms;

namespace aol.Classes
{
    class email
    {
        public static Dictionary<string, string> emailsNew = new Dictionary<string, string>();
        public static Dictionary<string, string> emailsOld = new Dictionary<string, string>();
        public static Dictionary<string, string> emailsSent = new Dictionary<string, string>();
        public static string reply = "";
        public static bool youGotMail = false;
        private static string host = "mail.newagesoftware.net";
        private static int imapPort = 993;
        private static int smtpPort = 465;

        public static bool checkNewEmail()
        {
            if (youGotMail)
                return true;

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                try
                {
                    client.Connect(host, imapPort, true);
                }
                catch
                {
                    return false;
                }

                try
                {
                    client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);
                }
                catch
                {
                    return false;
                }

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
            if (accForm.tmpUsername == "Guest" || accForm.tmpUsername == "")
                return;

            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                try
                {
                    client.Connect(host, imapPort, true);
                }
                catch
                {
                    MessageBox.Show("Connection to email server failed!");
                    return;
                }

                try
                {
                    client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);
                }
                catch
                {
                    MessageBox.Show("Authentication Failed!");
                    return;
                }

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
                    if (!emailsNew.ContainsKey(message.MessageId))
                        emailsNew.Add(message.MessageId, message.Subject);
                }

                // old emails
                uids = inbox.Search(SearchQuery.Seen);
                items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Envelope | MessageSummaryItems.Flags);
                foreach (var i in items)
                {
                    var message = inbox.GetMessage(i.UniqueId);
                    //Debug.WriteLine("[MAIL] old id:" + message.MessageId + " subj:" + message.Subject);
                    if (message.MessageId == null)
                        break;
                    if (!emailsOld.ContainsKey(message.MessageId))
                        emailsOld.Add(message.MessageId, message.Subject);
                }

                var outbox = client.GetFolder(SpecialFolder.Sent);
                outbox.Open(FolderAccess.ReadOnly);
                Debug.WriteLine("outbox items: " + outbox.Count);

                // sent emails
                for (int i = 0; i < outbox.Count; i++)
                {
                    var message = outbox.GetMessage(i);
                    //Debug.WriteLine("[MAIL] sent id:" + message.MessageId + " subj:" + message.Subject);
                    if (!emailsSent.ContainsKey(message.MessageId))
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

                client.Connect(host, imapPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                try
                {
                    var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                    inbox.AddFlags(uids.First(), MessageFlags.Deleted, true); // crashes if deleting sent mail
                    var matchFolder = client.GetFolder(SpecialFolder.Trash);
                    if (matchFolder != null)
                        inbox.MoveTo(uids.First(), matchFolder);
                } catch
                {
                    Debug.WriteLine("ERROR: Crashed on deleting mail!");
                }
            }
        }

        public static void markAsSeen(string id)
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(host, imapPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                inbox.AddFlags(uids.First(), MessageFlags.Seen, true);
            }
        }

        public static void markAsUnseen(string id)
        {
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(host, imapPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadWrite);

                var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
                inbox.RemoveFlags(uids.First(), MessageFlags.Seen, true);
            }
        }

        public static void sendEmail(string toName, string toAddress, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(sqlite_accounts.getFullName(), accForm.tmpUsername +"@aolemu.com"));
            message.To.Add(new MailboxAddress(toName, toAddress));
            message.Subject = subject;

            message.Body = new TextPart("plain")
            {
                Text = body
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(host, smtpPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

                client.Send(message);
                client.Disconnect(true);
            }

            // make a copy in SENT folder (not needed for some services, ex: GMail)
            using (var client = new ImapClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect(host, imapPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

                var folderSend = client.GetFolder(SpecialFolder.Sent);
                folderSend.Append(message, MessageFlags.Seen);
                
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

                client.Connect(host, imapPort, true);
                client.Authenticate(accForm.tmpUsername + "@aolemu.com", accForm.tmpPassword);

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
