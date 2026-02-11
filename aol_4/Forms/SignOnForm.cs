namespace aol.Forms;
public partial class SignOnForm : _Win95Theme
{
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
        if (screenName.Text == "New User" || screenName.Text == "Existing Member")
        {
            MDIHelper.OpenForm<SignupForm>(MdiParent);
        }
        else if (screenName.Text == "Guest")
        {
            Account.tmpUsername = "Guest";
            Close();
        }
        else
        {
            Cursor = Cursors.WaitCursor;
            if (!await RestAPIService.LoginAccount(screenName.Text, passBox.Text))
            {
                Cursor = Cursors.Default;
                OpenMsgBox("ERROR", "Incorrect username/password or account doesn't exist.");
            }
            else
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
        if (!screenName.Text.IsNullOrEmpty() &&
            !screenName.Text.Equals("New User") &&
            !screenName.Text.Equals("Existing Member") &&
            !screenName.Text.Equals("Guest"))
        {
            if (Properties.Settings.Default.lastAcc != screenName.Text) 
            {
                Properties.Settings.Default.lastAcc = screenName.Text;
                Properties.Settings.Default.Save();
                Debug.WriteLine("changing lastAcc to " + screenName.Text);
            }
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
        if (selectLocation.Text.IsNullOrEmpty())
            return;

        Account.tmpLocation = selectLocation.Text;
        Properties.Settings.Default.connType = selectLocation.Text;
        Properties.Settings.Default.Save();
    }
}
