using System;
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
    public partial class accForm : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

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

        public accForm()
        {
            InitializeComponent();
        }

        Dictionary<string, string> theAccs = accounts.listAccounts();

        private void accForm_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string, string> entry in accounts.listAccounts())
            {
                screenName.Items.Add(entry.Key);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void accForm_Shown(object sender, EventArgs e)
        {
            if (screenName.Items.Contains(Properties.Settings.Default.lastAcc))
                screenName.Text = Properties.Settings.Default.lastAcc;
            else
                screenName.SelectedIndex = 0;
            selectLocation.SelectedIndex = 0;
            if (passBox.Visible)
                this.ActiveControl = passBox;
        }

        private void signOnBtn_Click(object sender, EventArgs e)
        {
            if (screenName.Text == "New User")
            {
                signup_form suf = new signup_form();
                suf.Show();
            }
            else if (screenName.Text == "Guest")
            {
                accounts.tmpUsername = "Guest";
                Close();
            }
            else
            {
                if (accounts.loginAcc(screenName.Text, passBox.Text) != 0)
                    Close();
                else
                    MessageBox.Show("Account either deosn't exist, or incorrect password.");
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
            Dictionary<string, string> accsCheck = accounts.listAccounts();
            if (accsCheck.Count() != theAccs.Count())
            {
                screenName.Items.Clear();
                screenName.Items.Add("Guest");
                screenName.Items.Add("Existing Member");
                screenName.Items.Add("New User");
                foreach (KeyValuePair<string, string> entry in accounts.listAccounts())
                {
                    screenName.Items.Add(entry.Key);
                }
                theAccs = accsCheck; // update to stop refresh
            }
        }
    }
}
