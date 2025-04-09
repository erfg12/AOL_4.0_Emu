namespace aol.Forms;
public partial class MailReadForm : _Win95Theme
{
    string EmailID = "";

    public MailReadForm(string subject, string emailID)
    {
        InitializeComponent();
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        Dock = DockStyle.Fill;

        EmailID = emailID;
        Text = subject;
        mainTitle.Text = subject;
        string tmpString = MailService.readEmail(EmailID);
        mailViewer.DocumentText = tmpString;
        if (tmpString.Contains("msg NickServ"))
        {
            Debug.WriteLine("Found NickServ code for IRC chatrooms.");
            registerNickserv(tmpString);
        }
    }

    public void registerNickserv(string m)
    {
        var match = Regex.Match(m, "NickServ CONFIRM (.*?) \"", RegexOptions.Singleline);
        string register = match.Groups[1].Value;
        Debug.WriteLine("nickserv code = \"" + register + "\"");
        ChatService.irc.SendMessageToChannel("CONFIRM " + register, "NickServ");
        OpenMsgBox("INFO", "Your username has been registered successfully! You can now access restricted chatrooms!");
    }

    private void read_mail_Shown(object sender, EventArgs e)
    {

    }

    private void replyButton_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm(() => new MailWriteForm(MailService.reply, "Re:" + Text), MdiParent);
    }

    private void read_mail_Load(object sender, EventArgs e)
    {

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void MailReadForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
