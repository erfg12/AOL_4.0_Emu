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

namespace aol
{
    public partial class signup_form : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

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
            // insert into db
            int crAcc = accounts.createAcc(username.Text, fullname.Text, password.Text);
            if (crAcc == 0)
            {
                MessageBox.Show("Account Created");
                Close();
            }
            else
                MessageBox.Show("Error #" + crAcc.ToString());
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (newAOL.Checked)
            {
                panel2.SendToBack();
                panel3.BringToFront();
            }
            else
                Close();
        }

        private void signup_form_Shown(object sender, EventArgs e)
        {
            panel3.SendToBack();
            panel2.BringToFront();
        }
    }
}
