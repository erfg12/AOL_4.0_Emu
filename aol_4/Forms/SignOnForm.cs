namespace aol.Forms;
public partial class SignOnForm : _Win95Theme
{
    ConcurrentBag<string> theAccs = SqliteAccountsService.ListAccounts();

    public SignOnForm()
    {
        InitializeComponent();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
    }

    private void AccForm_Load(object sender, EventArgs e)
    {
        foreach (string entry in SqliteAccountsService.ListAccounts())
        {
            screenName.Items.Add(entry);
        }
    }

    private void AccForm_Shown(object sender, EventArgs e)
    {
        if (Properties.Settings.Default.connType != null)
            selectLocation.Text = Properties.Settings.Default.connType;

        LocationService.PositionWindow(this);
        if (screenName.Items.Contains(Properties.Settings.Default.lastAcc))
            screenName.Text = Properties.Settings.Default.lastAcc;
        else
            screenName.SelectedIndex = 0;
        
        if (passBox.Visible)
            this.ActiveControl = passBox;
    }

    private async void SignOnBtn_Click(object sender, EventArgs e)
    {
        await SignIn();
    }

    private async Task SignIn()
    {
        Cursor = Cursors.WaitCursor;

        if (screenName.Text == "New User" || screenName.Text == "Existing Member")
        {
            MDIHelper.OpenForm<SignupForm>(MdiParent);
        }
        else if (screenName.Text == "Guest")
        {
            Account.tmpUsername = "Guest";
            Cursor = Cursors.Default;
            Close();
        }
        else
        {
            if (await RestAPIService.LoginAccount(screenName.Text, passBox.Text))
            {
                Cursor = Cursors.Default;
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

    private async void PassBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            await SignIn();
        }
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

    private void selectLocation_SelectedIndexChanged(object sender, EventArgs e)
    {
        Account.tmpLocation = selectLocation.Text;
        Properties.Settings.Default.connType = selectLocation.Text;
        Properties.Settings.Default.Save();
    }
}
