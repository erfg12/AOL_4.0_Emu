namespace aol.Forms;
public partial class MailWriteForm : _Win95Theme
{
    public MailWriteForm(string sendTo = "", string subject = "")
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.None;
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        Dock = DockStyle.Fill;

        sendToBox.Text = sendTo;
        subjectBox.Text = subject;

        this.LocationChanged += OnLocationChanged;
        maxBtn.Click += MaxRestoreButton_Click;
        TitleBar.MouseMove += MoveWindow;
        TitleBar.DoubleClick += TitleBar_DoubleClick;
        TitleLabel.MouseMove += MoveWindow;
        TitleLabel.DoubleClick += TitleBar_DoubleClick;
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void SendButton_Click(object sender, EventArgs e)
    {
        // parse <name> "address"; format
        var entries = MailHelper.ParseEmails(sendToBox.Text); // name, address
        if (entries.Count == 0 || !entries.Values.Any(x => x.Contains("@") && x.Contains(".")))
        {
            OpenMsgBox("ERROR", "Please enter at least one valid email address.");
            return;
        }

        foreach (KeyValuePair<string, string> entry in entries)
        {
            MailService.SendEmail(entry.Key, entry.Value, subjectBox.Text, messageBox.Text);
        }
        OpenMsgBox("INFO", "Your email has been sent!");
        Close();
    }

    private void WriteMail_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 55);

        if (!MailService.CheckEmailSetup())
        {
            OpenMsgBox("ERROR", "No email address found for this account.\nOpen My AOL > Preferences > Mail.");
            Close();
            return;
        }
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
