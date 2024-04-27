using aol.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class signup_form : Win95Theme
    {
        #region winform_functions
        public signup_form()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveWindow(sender, e);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel3.SendToBack();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "Guest")
            {
                MessageBox.Show("You cannot use the username Guest.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RestAPI.createAccount(username.Text, password.Text, fullname.Text))
            {
                MessageBox.Show("Account has been created. Welcome!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } else
            {
                MessageBox.Show("Account creation has failed." + Environment.NewLine + "Please email support@aolemu.com", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (newAOL.Checked)
            {
                panel2.SendToBack();
                panel3.BringToFront();
            }
            else // recover acc from DB API
            {
                string user = recoverUser.Text;
                string pass = recoverPass.Text;
                if (RestAPI.loginAccount(user, pass))
                {
                    string fn = RestAPI.getAccInfo("fullname", user, pass);
                    int code = sqlite_accounts.createAcc(user, fn);
                    List<string> tmpBuddies = sqlite_accounts.getBuddyList(user, pass);

                    if (code == 0)
                    {
                        foreach (var t in RestAPI.getBuddyList(user, pass))
                        {
                            if (!tmpBuddies.Contains(t)) // if we deleted an account to re-create it, but we had our buddy list still there, prevent a crash
                                sqlite_accounts.addBuddy(t.ToString());
                        }
                        MessageBox.Show("Account has been added. Welcome back!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        if (code == 19)
                            MessageBox.Show("Account already exists.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("SQLite error " + code.ToString() + " on account creation.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Account not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signup_form_Shown(object sender, EventArgs e)
        {
            location.PositionWindow(this);
            panel3.SendToBack();
            panel2.BringToFront();
        }
        #endregion
    }
}
