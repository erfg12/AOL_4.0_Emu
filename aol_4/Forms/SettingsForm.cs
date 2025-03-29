using System;
using System.Collections.Generic;
using System.Windows.Forms;
using aol.Services;

namespace aol.Forms;
public partial class SettingsForm : Win95Theme
{
    #region winform_functions
    public SettingsForm()
    {
        InitializeComponent();
    }

    private void fullscreenCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.fullScreen = fullscreenCheckbox.Checked;
        Properties.Settings.Default.Save();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void settings_Load(object sender, EventArgs e)
    {

    }

    private void settings_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 0, 50);
        homePageBox.Text = Properties.Settings.Default.homeSite;
        cityBox.Text = Properties.Settings.Default.city;
        countryBox.Text = Properties.Settings.Default.country;
        fullscreenCheckbox.Checked = Properties.Settings.Default.fullScreen;
        fullnameBox.Text = SqliteAccountsService.getFullName();

        searchProvider.Text = Properties.Settings.Default.searchProvider;

        reloadBrowseHistory();
    }

    private void reloadBrowseHistory()
    {
        if (!Account.SignedIn())
            return;

        browseHistoryList.Items.Clear();
        List<string> tmpHistory = SqliteAccountsService.getHistory();
        tmpHistory.Sort();
        foreach (string l in tmpHistory)
        {
            browseHistoryList.Items.Add(l);
        }
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void updateFNBtn_Click(object sender, EventArgs e)
    {
        //RestAPI.updateFullName(fullnameBox.Text);
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void settings_FormClosing(object sender, FormClosingEventArgs e)
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
    #endregion

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void DeleteBrowserHistoryBtn_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem i in browseHistoryList.SelectedItems)
        {
            SqliteAccountsService.deleteHistory(i.Text);
        }
        reloadBrowseHistory();
    }

    private void DeleteAllBrowsingHistory_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem i in browseHistoryList.Items)
        {
            SqliteAccountsService.deleteHistory(i.Text);
        }
        reloadBrowseHistory();
    }
}
