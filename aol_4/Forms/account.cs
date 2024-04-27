using aol.Classes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class accForm : Win95Theme
    {

        ConcurrentBag<string> theAccs = sqlite_accounts.listAccounts();
        public static string tmpLocation = "";
        public static string tmpPassword = "";
        public static string tmpUsername = "";

        #region winform_functions
        public accForm()
        {
            InitializeComponent();
        }
        
        private void accForm_Load(object sender, EventArgs e)
        {
            foreach(string entry in sqlite_accounts.listAccounts())
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
            location.PositionWindow(this);
            if (screenName.Items.Contains(Properties.Settings.Default.lastAcc))
                screenName.Text = Properties.Settings.Default.lastAcc;
            else
                screenName.SelectedIndex = 0;
            selectLocation.Text = Properties.Settings.Default.connType;
            if (passBox.Visible)
                this.ActiveControl = passBox;
        }

        private void signOnBtn_Click(object sender, EventArgs e)
        {
            tmpLocation = selectLocation.Text;

            Properties.Settings.Default.connType = tmpLocation;
            Properties.Settings.Default.Save();

            if (screenName.Text == "New User" || screenName.Text == "Existing Member")
            {
                signup_form suf = new signup_form();
                suf.Owner = this;
                suf.MdiParent = MdiParent;
                suf.Show();
            }
            else if (screenName.Text == "Guest")
            {
                tmpUsername = "Guest";
                Close();
            }
            else
            {
                if (RestAPI.loginAccount(screenName.Text, passBox.Text))
                    Close();
            }
        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            signup_form suf = new signup_form();
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
            ConcurrentBag<string> accsCheck = sqlite_accounts.listAccounts();
            if (accsCheck.Count() != theAccs.Count())
            {
                screenName.Items.Clear();
                screenName.Items.Add("Guest");
                screenName.Items.Add("Existing Member");
                screenName.Items.Add("New User");
                foreach (string entry in sqlite_accounts.listAccounts())
                {
                    screenName.Items.Add(entry);
                }
                theAccs = accsCheck; // update to stop refresh
            }
        }
        #endregion
    }
}
