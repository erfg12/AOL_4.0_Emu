using System;
using System.Linq;
using MailKit.Net.Imap;
using MailKit;
using MimeKit;
using MailKit.Search;
using System.Diagnostics;
using System.Net;
using MailKit.Net.Smtp;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace aol.Classes;
class MailClass
{
    public static ConcurrentDictionary<string, string> emailsNew = new ConcurrentDictionary<string, string>();
    public static ConcurrentDictionary<string, string> emailsOld = new ConcurrentDictionary<string, string>();
    public static ConcurrentDictionary<string, string> emailsSent = new ConcurrentDictionary<string, string>();
    public static string reply = "";
    public static bool youGotMail = false;
    private static string host = "s3122.usc1.stableserver.net";
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
                client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);
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
            //else
            //{
            //    Debug.WriteLine("[MAIL] nothing new");
            //}

            client.Disconnect(true);

            return false;
        }
    }

    public static void getEmail()
    {
        if (Account.tmpUsername == "Guest" || Account.tmpUsername == "")
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
                client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);
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
                if (message.MessageId != null)
                {
                    if (!emailsNew.ContainsKey(message.MessageId))
                        emailsNew.TryAdd(message.MessageId, message.Subject);
                } else
                {
                    Debug.WriteLine("ERROR: Email MessageId was null.");
                }
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
                    emailsOld.TryAdd(message.MessageId, message.Subject);
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
                    emailsSent.TryAdd(message.MessageId, message.Subject);
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
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

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
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

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
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadWrite);

            var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
            inbox.RemoveFlags(uids.First(), MessageFlags.Seen, true);
        }
    }

    public static void sendEmail(string toName, string toAddress, string subject, string body)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(SqliteAccountsClass.getFullName(), Account.tmpUsername +"@aolemu.com"));
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
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

            client.Send(message);
            client.Disconnect(true);
        }

        // make a copy in SENT folder (not needed for some services, ex: GMail)
        using (var client = new ImapClient())
        {
            client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            client.Connect(host, imapPort, true);
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

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
            client.Authenticate(Account.tmpUsername + "@aolemu.com", Account.tmpPassword);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            var uids = inbox.Search(SearchQuery.HeaderContains("Message-ID", id));
            var items = inbox.Fetch(uids, MessageSummaryItems.UniqueId | MessageSummaryItems.BodyStructure | MessageSummaryItems.Envelope);

            foreach (var item in items)
            {
                if (item.TextBody != null)
                {
                    rawBody = (TextPart) inbox.GetBodyPart(item.UniqueId, item.TextBody);
                }

                foreach (InternetAddress rt in item.Envelope.ReplyTo)
                {
                    reply = reply + rt.ToString() + ";";
                }
            }

            client.Disconnect(true);
        }
        if (rawBody != null)
        {
            body = rawBody.Text.Replace(Environment.NewLine, "<br>");
        } else
        {
            Debug.WriteLine("ERROR: Email rawBody was null.");
        }
        body = WebUtility.HtmlDecode(body);

        return body;
    }
}
