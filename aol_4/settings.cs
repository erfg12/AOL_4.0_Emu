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
    public partial class settings : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        public settings()
        {
            InitializeComponent();
        }

        private void fullscreenCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.fullScreen = fullscreenCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void settings_Shown(object sender, EventArgs e)
        {
            homePageBox.Text = Properties.Settings.Default.homeSite;
            //saveWndP.Checked = Properties.Settings.Default.windowSize;
            fullscreenCheckbox.Checked = Properties.Settings.Default.fullScreen;
        }

        private void homePageBox_TextChanged(object sender, EventArgs e)
        {
            if (homePageBox.Text.Length > 4)
            { // make sure it's not blank
                Properties.Settings.Default.homeSite = homePageBox.Text;
                Properties.Settings.Default.Save();
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
    }
}
