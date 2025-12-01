using Microsoft.VisualBasic.ApplicationServices;

namespace aol.Forms;
public partial class SignupForm : _Win95Theme
{
    public SignupForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
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
        if (username.Text.ToLower() == "Guest")
        {
            OpenMsgBox("ERROR", "You cannot use the username Guest.");
            return;
        }

        this.Cursor = Cursors.WaitCursor;
        LoadingLabel.Text = "Creating account, please wait...";

        int code = SqliteAccountsService.CreateAccount(username.Text, password.Text, fullname.Text);

        if (code == 0)
        {
            this.Cursor = Cursors.Default;
            OpenMsgBox("SUCCESS", "Account has been created. Welcome!");
            Close();
        }
        else
        {
            this.Cursor = Cursors.Default;
            OpenMsgBox("ERROR", "Account creation has failed.");

            Close();
        }
    }

    private async void NextBtn_Click(object sender, EventArgs e)
    {
        this.Cursor = Cursors.WaitCursor;
        if (newAOL.Checked)
        {
            panel2.SendToBack();
            panel3.BringToFront();
        }
        else // recover acc from DB API
        {
            string user = recoverUser.Text;
            string pass = recoverPass.Text;
            //if (await RestAPIService.LoginAccount(user, pass))
            //{
                int code = SqliteAccountsService.CreateAccount(Account.Info.username, Account.Info.password, Account.Info.fullname);
                List<Models.Buddies> tmpBuddies = SqliteAccountsService.GetBuddyList(Account.Info.username, pass);

                if (code == 0)
                {
                    foreach (var t in Account.Buddies)
                    {
                        //if (!tmpBuddies.Any(x => x.id.Equals(t.id))) // if we deleted an account to re-create it, but we had our buddy list still there, prevent a crash
                            SqliteAccountsService.AddBuddy(t.buddy_name);
                    }
                    OpenMsgBox("SUCCESS", "Account has been added. Welcome back!");
                    this.Cursor = Cursors.Default;
                    Close();
                }
                else
                {
                    if (code == 19)
                        OpenMsgBox("ERROR", "Account already exists.");
                    else
                        MessageBox.Show("SQLite error " + code.ToString() + " on account creation.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //else
            //    OpenMsgBox("ERROR", "Account not found.");
        }
        this.Cursor = Cursors.Default;
    }

    private void SignupForm_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        panel3.SendToBack();
        panel2.BringToFront();
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
