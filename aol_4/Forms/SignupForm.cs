﻿using aol.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace aol.Forms;
public partial class SignupForm : Win95Theme
{
    public SignupForm()
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
        MoveWindow(sender, e, maxBtn);
    }

    private void backBtn_Click(object sender, EventArgs e)
    {
        panel2.BringToFront();
        panel3.SendToBack();
    }

    private async void registerBtn_Click(object sender, EventArgs e)
    {
        if (username.Text == "Guest")
        {
            OpenMsgBox("ERROR", "You cannot use the username Guest.");
            return;
        }

        if (await RestAPIService.createAccount(username.Text, password.Text, fullname.Text))
        {
            OpenMsgBox("SUCCESS", "Account has been created. Welcome!");
            Close();
        }
        else
        {
            OpenMsgBox("ERROR", "Account creation has failed. Please email support@aolemu.com");
        }
    }

    private async void nextBtn_Click(object sender, EventArgs e)
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
            if (await RestAPIService.loginAccount(user, pass))
            {
                var userApi = Account.accountInfo;
                int code = SqliteAccountsService.createAcc(userApi.account.username, userApi.account.id, userApi.account.fullname);
                List<userAPI.Buddies> tmpBuddies = SqliteAccountsService.getBuddyList(userApi.account.username, pass);

                if (code == 0)
                {
                    foreach (var t in Account.accountInfo.buddies)
                    {
                        if (!tmpBuddies.Any(x => x.id.Equals(t.id))) // if we deleted an account to re-create it, but we had our buddy list still there, prevent a crash
                            SqliteAccountsService.addBuddy(t.id, t.username);
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
            }
            else
                OpenMsgBox("ERROR", "Account not found.");
        }
        this.Cursor = Cursors.Default;
    }

    private void signup_form_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        panel3.SendToBack();
        panel2.BringToFront();
    }

    private void recoverUser_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsLetterOrDigit(e.KeyChar) &&
        e.KeyChar != '_' &&
        e.KeyChar != '-' &&
        !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void recoverPass_KeyPress(object sender, KeyPressEventArgs e)
    {

    }

    private void SignupForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
