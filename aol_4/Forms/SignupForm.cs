namespace aol.Forms;
public partial class SignupForm : _Win95Theme
{
    private readonly RestAPIService restApi;
    private readonly SqliteAccountsService sqliteAccountsService;
    public SignupForm(RestAPIService ras, SqliteAccountsService sql)
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
        restApi = ras;
        sqliteAccountsService = sql;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        panel2.BringToFront();
        panel3.SendToBack();
    }

    private async void RegisterBtn_Click(object sender, EventArgs e)
    {
        if (AccountHelper.notAllowedUsernames.Contains(username.Text.ToLower()))
        {
            OpenMsgBox("ERROR", "You cannot register this username.");
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        LoadingLabel.Text = "Creating account, please wait...";

        var createAccount = await restApi.CreateAccount(username.Text, password.Text, fullname.Text);

        if (createAccount.success)
        {
            this.Cursor = Cursors.Default;
            OpenMsgBox("SUCCESS", "Account has been created. Welcome!");
            Close();
        }
        else
        {
            this.Cursor = Cursors.Default;
            LoadingLabel.Text = "";
            OpenMsgBox("ERROR", createAccount.msg);
        }
    }

    private async void NextBtn_Click(object sender, EventArgs e)
    {
        if (newAOL.Checked)
        {
            panel2.SendToBack();
            panel3.BringToFront();
            if (username.Visible)
                username.Select();
        }
        else // recover acc from DB API
        {
            this.Cursor = Cursors.WaitCursor;
            string user = recoverUser.Text;
            string pass = recoverPass.Text;
            var userApi = await restApi.GetAccInfo(user, pass);
            this.Cursor = Cursors.Default;

            if (userApi != null)
            {
                int code = sqliteAccountsService.CreateAcc(userApi.account.username, userApi.account.id, userApi.account.fullname);
                List<UserAPI.Buddies> dbBuddies = sqliteAccountsService.GetBuddyList(userApi.account.id);

                if (code == 0)
                {
                    foreach (var t in userApi.buddies)
                    {
                        if (!dbBuddies.Any(x => x.id.Equals(t.id))) // if we deleted an account to re-create it, but we had our buddy list still there, prevent a crash
                            sqliteAccountsService.AddBuddy(t.id, t.username, userApi.account.id);
                    }

                    // update the sign on form's dropdown with the new account, if it exists
                    var parent = this.MdiParent;
                    if (parent != null)
                    {
                        foreach (var child in parent.MdiChildren)
                        {
                            if (child is SignOnForm other)
                            {
                                other.screenName.Items.Add(userApi.account.username);
                                other.screenName.SelectedItem = userApi.account.username;
                                other.passBox.Select();
                            }
                        }
                    }


                    OpenMsgBox("SUCCESS", "Account has been added. Welcome back!");
                    Close();
                }
                else
                {
                    if (code == 19)
                        OpenMsgBox("ERROR", "Account already exists.");
                    else
                        MessageBox.Show("SQLite error " + code.ToString() + " on account creation.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Cursor = Cursors.Default;
                OpenMsgBox("ERROR", "Account not found.");
            }
        }
    }

    private void SignupForm_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        panel3.SendToBack();
        panel2.BringToFront();
        recoverUser.Select();
    }

    private void RecoverUser_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) &&
        e.KeyChar != '_' &&
        e.KeyChar != '-' &&
        !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void SignupForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        this.Cursor = Cursors.Default;
    }
}
