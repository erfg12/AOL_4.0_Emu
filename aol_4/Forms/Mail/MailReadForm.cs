using System;

namespace aol.Forms;
public partial class MailReadForm : _Win95Theme
{
    readonly string EmailID;
    private readonly MailService mail;
    private readonly ChatService chat;

    public MailReadForm(string subject, string emailID, MailService ms, ChatService cs)
    {
        InitializeComponent();

        mail = ms;
        chat = cs;

        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        Dock = DockStyle.Fill;

        EmailID = emailID;
        Text = subject;
        mainTitle.Text = subject;
        string tmpString = mail.ReadEmail(EmailID);
        mailViewer.DocumentText = tmpString;
        if (tmpString.Contains("msg NickServ"))
        {
            Debug.WriteLine("Found NickServ code for IRC chatrooms.");
            RegisterNickserv(tmpString);
        }

        this.LocationChanged += OnLocationChanged;
        maxBtn.Click += MaxRestoreButton_Click;
        TitleBar.DoubleClick += TitleBar_DoubleClick;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.DoubleClick += TitleBar_DoubleClick;
        mainTitle.MouseMove += MoveWindow;
    }

    public void RegisterNickserv(string m)
    {
        var match = Regex.Match(m, "NickServ CONFIRM (.*?) \"", RegexOptions.Singleline);
        string register = match.Groups[1].Value;
        Debug.WriteLine("nickserv code = \"" + register + "\"");
        chat.irc.SendMessageToChannel("CONFIRM " + register, "NickServ");
        OpenMsgBox("INFO", "Your username has been registered successfully! You can now access restricted chatrooms!");
    }

    private void ReplyBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm(() => new MailWriteForm(mail, mail.reply, "Re:" + Text), MdiParent);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }
}
