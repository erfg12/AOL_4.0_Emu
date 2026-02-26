namespace aol.Forms;
public partial class SettingsForm : _Win95Theme
{
    public SettingsForm()
    {
        InitializeComponent();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;

    }

    private void fullscreenCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.fullScreen = fullscreenCheckbox.Checked;
        Properties.Settings.Default.Save();
    }

    private void CloseBlueBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Settings_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 50);
        homePageBox.Text = Properties.Settings.Default.homeSite;
        cityBox.Text = Properties.Settings.Default.city;
        countryBox.Text = Properties.Settings.Default.country;
        fullscreenCheckbox.Checked = Properties.Settings.Default.fullScreen;
        checkForUpdates.Checked = Properties.Settings.Default.disableVersionCheck;
        fullnameBox.Text = SqliteAccountsService.GetFullName();

        searchProvider.Text = Properties.Settings.Default.searchProvider;

        UIScaleBox.Text = Properties.Settings.Default.uiScale ?? "1.0";

        ReloadBrowseHistory();
    }

    private void ReloadBrowseHistory()
    {
        if (!Account.SignedIn())
            return;

        browseHistoryList.Items.Clear();
        List<string> tmpHistory = SqliteAccountsService.GetHistory();
        tmpHistory.Sort();
        foreach (string l in tmpHistory)
        {
            browseHistoryList.Items.Add(l);
        }
    }

    private void UpdateFNBtn_Click(object sender, EventArgs e)
    {
        //RestAPI.updateFullName(fullnameBox.Text);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Settings_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (Account.tmpUsername != "Guest" && Account.tmpUsername != "")
        {
            if (homePageBox.Text.Length > 4) // make sure it's not blank
                Properties.Settings.Default.homeSite = homePageBox.Text;
            if (cityBox.Text.Length > 0)
                Properties.Settings.Default.city = cityBox.Text;
            if (countryBox.Text.Length > 0)
                Properties.Settings.Default.country = countryBox.Text;

            Properties.Settings.Default.searchProvider = searchProvider.Text;

            Properties.Settings.Default.Save();

            //int ssl = useSSL.Checked ? 1 : 0;
            //sqlite_accounts.emailAcc(emailAddress.Text, emailPassword.Text, imapServer.Text, Convert.ToInt32(imapPort.Text), smtpServer.Text, Convert.ToInt32(smtpPort.Text), ssl);
        }
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void DeleteBrowserHistoryBtn_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem i in browseHistoryList.SelectedItems)
        {
            SqliteAccountsService.DeleteHistory(i.Text);
        }
        ReloadBrowseHistory();
    }

    private void DeleteAllBrowsingHistory_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem i in browseHistoryList.Items)
        {
            SqliteAccountsService.DeleteHistory(i.Text);
        }
        ReloadBrowseHistory();
    }

    private void UIScaleBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.uiScale = UIScaleBox.Text;
        Properties.Settings.Default.Save();
    }

    private void checkForUpdates_CheckedChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.disableVersionCheck = checkForUpdates.Checked;
        Properties.Settings.Default.Save();
    }
}
