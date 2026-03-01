using Microsoft.Extensions.DependencyInjection;
using static UserAPI;

namespace aol.Forms;
public partial class SignOnForm : _Win95Theme
{
    private readonly RestAPIService restApi;
    private readonly AccountService account;
    private readonly SqliteService sqLite;
    public IServiceProvider ServiceProvider { get; }

    public SignOnForm(RestAPIService restApi, SqliteService sql, AccountService acc, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        sqLite = sql;

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        mainTitle.MouseMove += MoveWindow;
        this.restApi = restApi;
        account = acc;
        ServiceProvider = serviceProvider;
    }

    private void AccForm_Load(object sender, EventArgs e)
    {
        foreach (string entry in sqLite.ListAccounts())
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
            var signupForm = this.ServiceProvider.GetRequiredService<SignupForm>();
            MDIHelper.OpenForm(signupForm, MdiParent);
        }
        else if (screenName.Text == "Guest")
        {
            account.tmpUsername = "Guest";
            Close();
        }
        else
        {
            Cursor = Cursors.WaitCursor;
            if (!await restApi.LoginAccount(screenName.Text, passBox.Text))
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
        var signupForm = this.ServiceProvider.GetRequiredService<SignupForm>();
        MDIHelper.OpenForm(signupForm, MdiParent);
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
        var dialUpForm = this.ServiceProvider.GetRequiredService<DialUpForm>();
        MDIHelper.OpenForm(dialUpForm, MdiParent);
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

        account.tmpLocation = selectLocation.Text;
        Properties.Settings.Default.connType = selectLocation.Text;
        Properties.Settings.Default.Save();
    }
}
