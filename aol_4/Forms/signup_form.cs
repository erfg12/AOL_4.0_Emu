//using aol.Classes;
using aol.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class signup_form : Form
    {
        #region DLLImports
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
        #endregion

        #region win95_theme
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }
        #endregion

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
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
                    if (code == 0)
                    { // store in sqlite db for reference
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
            panel3.SendToBack();
            panel2.BringToFront();
        }
        #endregion
    }
}
