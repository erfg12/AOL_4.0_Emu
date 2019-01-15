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
        #endregion
    }
}
