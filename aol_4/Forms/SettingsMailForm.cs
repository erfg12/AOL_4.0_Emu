namespace aol.Forms;
public partial class SettingsMailForm : _Win95Theme
{
    public SettingsMailForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        
    }

    private void CloseBlueBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Settings_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 50);
        SqliteAccountsService.GetEmail();

        emailAddressBox.Text = Account.Email.address;
        emailUsernameBox.Text = Account.Email.username;
        emailPasswordBox.Text = Account.Email.password;
        emailImapHost.Text = Account.Email.host;
        emailImapPortBox.Text = Account.Email.imapPort.ToString();
        emailSmtpHostBox.Text = Account.Email.host;
        emailSmtpPortBox.Text = Account.Email.smtpPort.ToString();
        sslCheckbox.Checked = Account.Email.useSSL == 1;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Settings_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!Account.Info.username.IsNullOrEmpty() && Account.Info.username != "Guest")
        {
            if (!emailAddressBox.Text.IsNullOrEmpty() && !emailUsernameBox.Text.IsNullOrEmpty() &&
                !emailPasswordBox.Text.IsNullOrEmpty() && !emailImapHost.Text.IsNullOrEmpty() && !emailImapPortBox.Text.IsNullOrEmpty() &&
                !emailSmtpHostBox.Text.IsNullOrEmpty() && !emailSmtpPortBox.Text.IsNullOrEmpty())
            SqliteAccountsService.SetEmailAccount(emailAddressBox.Text, emailUsernameBox.Text, 
                emailPasswordBox.Text, emailImapHost.Text, Convert.ToInt32(emailImapPortBox.Text, sslCheckbox.Checked ? 1 : 0),
                emailSmtpHostBox.Text, Convert.ToInt32(emailSmtpPortBox.Text), 1);

            Properties.Settings.Default.Save();

            //int ssl = useSSL.Checked ? 1 : 0;
            //sqlite_accounts.emailAcc(emailAddress.Text, emailPassword.Text, imapServer.Text, Convert.ToInt32(imapPort.Text), smtpServer.Text, Convert.ToInt32(smtpPort.Text), ssl);
        }
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }
}
