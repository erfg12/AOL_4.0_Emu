namespace aol.Forms;
public partial class accForm : _Win95Theme
{
    ConcurrentBag<string> theAccs = SqliteAccountsService.ListAccounts();

    public accForm()
    {
        InitializeComponent();
    }

    private void AccForm_Load(object sender, EventArgs e)
    {
        foreach (string entry in SqliteAccountsService.ListAccounts())
        {
            screenName.Items.Add(entry);
        }
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void AccForm_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        if (screenName.Items.Contains(Properties.Settings.Default.lastAcc))
            screenName.Text = Properties.Settings.Default.lastAcc;
        else
            screenName.SelectedIndex = 0;
        selectLocation.Text = Properties.Settings.Default.connType;
        if (passBox.Visible)
            this.ActiveControl = passBox;
    }

    private async void SignOnBtn_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        Account.tmpLocation = selectLocation.Text;

        Properties.Settings.Default.connType = Account.tmpLocation;
        Properties.Settings.Default.Save();

        if (screenName.Text == "New User" || screenName.Text == "Existing Member")
        {
            MDIHelper.OpenForm<SignupForm>(MdiParent);
        }
        else if (screenName.Text == "Guest")
        {
            Account.tmpUsername = "Guest";
            Cursor.Current = Cursors.Default;
            Close();
        }
        else
        {
            if (await RestAPIService.LoginAccount(screenName.Text, passBox.Text))
            {
                Cursor.Current = Cursors.Default;
                Close();
            }
        }
    }

    private void SetupBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<SignupForm>(MdiParent);
    }

    private void ScreenName_SelectedIndexChanged(object sender, EventArgs e)
    {
        Properties.Settings.Default.lastAcc = screenName.Text;
        Properties.Settings.Default.Save();
        Debug.WriteLine("changing lastAcc to " + screenName.Text);
        // remember password code
        /*if (theAccs.ContainsKey(screenName.Text))
        {
            string accPass;
            theAccs.TryGetValue(screenName.Text, out accPass);
        }*/
        if (screenName.Text != "Guest" && screenName.Text != "Existing Member" && screenName.Text != "New User")
        {
            passLabel.Visible = true;
            passBox.Visible = true;
        }
        else
        {
            passLabel.Visible = false;
            passBox.Visible = false;
        }
    }

    private void PassBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            signOnBtn.PerformClick();
    }

    private void AccCheck_Tick(object sender, EventArgs e)
    {
        ConcurrentBag<string> accsCheck = SqliteAccountsService.ListAccounts();
        if (accsCheck.Count() != theAccs.Count())
        {
            screenName.Items.Clear();
            screenName.Items.Add("Guest");
            screenName.Items.Add("Existing Member");
            screenName.Items.Add("New User");
            foreach (string entry in SqliteAccountsService.ListAccounts())
            {
                screenName.Items.Add(entry);
            }
            theAccs = accsCheck; // update to stop refresh
        }
    }

    private void AccForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        MDIHelper.OpenForm<DialUpForm>(MdiParent);
    }

    private void ScreenName_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) &&
        e.KeyChar != '_' &&
        e.KeyChar != '-' &&
        !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void AccForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
