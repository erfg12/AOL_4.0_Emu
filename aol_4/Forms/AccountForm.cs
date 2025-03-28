using aol.Classes;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace aol.Forms;
public partial class accForm : Win95Theme
{
    ConcurrentBag<string> theAccs = SqliteAccountsClass.listAccounts();

    public accForm()
    {
        InitializeComponent();
    }

    private void accForm_Load(object sender, EventArgs e)
    {
        foreach (string entry in SqliteAccountsClass.listAccounts())
        {
            screenName.Items.Add(entry);
        }
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void accForm_Shown(object sender, EventArgs e)
    {
        LocationClass.PositionWindow(this);
        if (screenName.Items.Contains(Properties.Settings.Default.lastAcc))
            screenName.Text = Properties.Settings.Default.lastAcc;
        else
            screenName.SelectedIndex = 0;
        selectLocation.Text = Properties.Settings.Default.connType;
        if (passBox.Visible)
            this.ActiveControl = passBox;
    }

    private async void signOnBtn_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;
        Account.tmpLocation = selectLocation.Text;

        Properties.Settings.Default.connType = Account.tmpLocation;
        Properties.Settings.Default.Save();

        if (screenName.Text == "New User" || screenName.Text == "Existing Member")
        {
            SignupForm suf = new SignupForm();
            suf.Owner = this;
            suf.MdiParent = MdiParent;
            suf.Show();
        }
        else if (screenName.Text == "Guest")
        {
            Account.tmpUsername = "Guest";
            Cursor.Current = Cursors.Default;
            Close();
        }
        else
        {
            if (await RestAPIClass.loginAccount(screenName.Text, passBox.Text))
            {
                Cursor.Current = Cursors.Default;
                Close();
            }
        }
    }

    private void setupBtn_Click(object sender, EventArgs e)
    {
        SignupForm suf = new SignupForm();
        suf.Owner = this;
        suf.MdiParent = MdiParent;
        suf.Show();
    }

    private void screenName_SelectedIndexChanged(object sender, EventArgs e)
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

    private void passBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
            signOnBtn.PerformClick();
    }

    private void accCheck_Tick(object sender, EventArgs e)
    {
        ConcurrentBag<string> accsCheck = SqliteAccountsClass.listAccounts();
        if (accsCheck.Count() != theAccs.Count())
        {
            screenName.Items.Clear();
            screenName.Items.Add("Guest");
            screenName.Items.Add("Existing Member");
            screenName.Items.Add("New User");
            foreach (string entry in SqliteAccountsClass.listAccounts())
            {
                screenName.Items.Add(entry);
            }
            theAccs = accsCheck; // update to stop refresh
        }
    }

    private void accForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        // start fake dial up/log in
        DialUpForm du = new DialUpForm();
        du.Owner = (Form)this.MdiParent;
        du.MdiParent = this.MdiParent;
        du.Show();
    }
}
