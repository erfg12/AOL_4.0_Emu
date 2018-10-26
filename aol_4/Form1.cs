using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        private const int cGrip = 16;
        private const int cCaption = 32;

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public static int GetSoundLength(string fileName)
        {
            StringBuilder lengthBuf = new StringBuilder(32);

            mciSendString(string.Format("open \"{0}\" type waveaudio alias wave", fileName), null, 0, IntPtr.Zero);
            mciSendString("status wave length", lengthBuf, lengthBuf.Capacity, IntPtr.Zero);
            mciSendString("close wave", null, 0, IntPtr.Zero);

            int length = 0;
            int.TryParse(lengthBuf.ToString(), out length);

            return length;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miniMax()
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;

            if (this.ActiveMdiChild != null)
            {
                bool resize = false;
                if (this.ActiveMdiChild is Browse && ((Browse)ActiveMdiChild).maximized)
                    resize = true;
                if (this.ActiveMdiChild is buddies_online && ((buddies_online)ActiveMdiChild).maximized)
                    resize = true;

                if (resize)
                {
                    this.ActiveMdiChild.Width = this.Width - 4;
                    this.ActiveMdiChild.Height = this.Height - 121;
                }
            }
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            miniMax();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        const int tenDigit = 2; // you can rename this variable if you like

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, tenDigit); } }
        Rectangle Left { get { return new Rectangle(0, 0, tenDigit, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - tenDigit, this.ClientSize.Width, tenDigit); } }

        new Rectangle Right { get { return new Rectangle(this.ClientSize.Width - tenDigit, 0, tenDigit, this.ClientSize.Height); } }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.closeBtn, "Close Browser");
            toolTip1.SetToolTip(this.maxBtn, "Maximize Browser");
            toolTip1.SetToolTip(this.miniBtn, "Minimize Browser");
            toolTip1.SetToolTip(this.backBtn, "Back");
            toolTip1.SetToolTip(this.forwardBtn, "Forward");
            toolTip1.SetToolTip(this.reloadBtn, "Refresh");
            toolTip1.SetToolTip(this.write_mail_button, "Write mail and send files.");
            toolTip1.SetToolTip(this.my_files_btn, "Your Personal Documents.");
            toolTip1.SetToolTip(this.print_page_btn, "Print text or pictures.");

            // open fake dial up window
            dial_up du = new dial_up();
            du.Owner = (Form)this;
            du.MdiParent = this;
            du.Show();

            await Task.Delay(TimeSpan.FromSeconds(1)); // wait for dial up to finish

            // open buddies online window
            buddies_online bo = new buddies_online();
            bo.Owner = (Form)this;
            bo.MdiParent = this;
            bo.Show();

            // open home menu
            home_menu hm = new home_menu();
            hm.Owner = (Form)this;
            hm.MdiParent = this;
            hm.Show();

            // enable buttons
            internet_btn.Image = Properties.Resources.internet_icon_enabled;
            channels_btn.Image = Properties.Resources.channels_icon_enabled;
            people_btn.Image = Properties.Resources.people_icon_enabled;
            quotes_btn.Image = Properties.Resources.quotes_icon_enabled;
            perks_btn.Image = Properties.Resources.perks_icon_enabled;
            weather_btn.Image = Properties.Resources.weather_icon_enabled;

            findDropDown.SelectedIndex = 0; // default find text selected
        }

        private void openBrowser(string url = "")
        {
            string goTo = "";
            if (url == "")
                goTo = addrBox.Text;
            else
                goTo = url;
            Form BrowseWnd = new Browse(goTo);
            BrowseWnd.Owner = (Form)this;
            BrowseWnd.MdiParent = this;
            BrowseWnd.Show();
        }

        private Point FindLocation(Control ctrl)
        {
            if (ctrl.Parent is Form)
                return ctrl.Location;
            else
            {
                Point p = FindLocation(ctrl.Parent);
                p.X += ctrl.Location.X;
                p.Y += ctrl.Location.Y;
                return p;
            }
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            fileContextMenuStrip.Show(this.Location.X, this.Location.Y + 40);
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool newWindow = true;

        private void Form1_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
            {
                stopBtn.Image = Properties.Resources.stop_btn_enabled;
                forwardBtn.Image = Properties.Resources.forward_btn_enabled;
                stopBtn.Image = Properties.Resources.stop_btn_enabled;
                reloadBtn.Image = Properties.Resources.reload_btn_enabled;
                backBtn.Image = Properties.Resources.back_btn_enabled;
            }
        }

        string old_url = "";

        private void getMdiChildURL_Tick(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
            {
                if (((Browse)this.ActiveMdiChild).loading)
                {
                    loadingIcon.Enabled = true;
                }
                else
                {
                    loadingIcon.Enabled = false;
                    loadingIcon.Image.SelectActiveFrame(new FrameDimension(loadingIcon.Image.FrameDimensionsList[0]), 0);
                    loadingIcon.Image = loadingIcon.Image;
                }
                if (((Browse)this.ActiveMdiChild).url != old_url)
                {
                    addrBox.Text = ((Browse)this.ActiveMdiChild).url;
                    old_url = addrBox.Text = ((Browse)this.ActiveMdiChild).url;
                    mie_badge.Image = Properties.Resources.mie_badge;
                }
            } else
            {
                mie_badge.Image = null;
            }
        }

        public void GoToURL()
        {
            if (!newWindow)
            {
                if (this.ActiveMdiChild is Browse)
                    ((Browse)this.ActiveMdiChild).goToUrl(addrBox.Text);
                else // we don't have a browser window selected, open a new one anyways
                {
                    openBrowser();
                    newWindow = false;
                }
            }
            else
            {
                openBrowser();
                newWindow = false;
            }
        }

        private void addrBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (addrBox.Text.Length <= 3)
                newWindow = true;

            if (e.KeyCode == Keys.Enter)
            {
                GoToURL();
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            GoToURL();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            SolidBrush brush1 = new SolidBrush(Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(51)))), ((int)(((byte)(102))))));
            if (e.Column == 13)
                e.Graphics.FillRectangle(brush1, e.CellBounds);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addrBox_KeyUp_1(object sender, KeyEventArgs e)
        {
            
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Back();
        }

        private void forwardBtn_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Forward();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Stop();
        }

        private void reloadBtn_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).browser.Reload();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is Browse)
                ((Browse)this.ActiveMdiChild).goToUrl("google.com");
            else // we don't have a browser window selected, open a new one anyways
            {
                openBrowser("google.com");
                newWindow = false;
            }
        }

        private void addrBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (addrBox.Text == "Type Keyword or Web Address here and click Go")
                addrBox.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Goodbye;
            player.Play();

            System.Threading.Thread.Sleep(1000);
        }

        bool channelsOpen = false;
        // channels button
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!channelsOpen)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                channelsContextMenuStrip.Show(ptLowerLeft);
                channelsOpen = true;
            }
            else
                channelsOpen = false;
            // this form doesn't open from the top bar button, only from the AOL today window
            /*channels ch = new channels();
            ch.Owner = (Form)this;
            ch.MdiParent = this;
            ch.Show();*/
        }

        private void mainTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void aOLTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open home menu
            home_menu hm = new home_menu();
            hm.Owner = (Form)this;
            hm.MdiParent = this;
            hm.Show();
        }

        Rectangle TopLeft { get { return new Rectangle(0, 0, tenDigit, tenDigit); } }
        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - tenDigit, 0, tenDigit, tenDigit); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - tenDigit, tenDigit, tenDigit); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - tenDigit, this.ClientSize.Height - tenDigit, tenDigit, tenDigit); } }

        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (TopLeft.Contains(cursor)) message.Result = (IntPtr)HTTOPLEFT;
                else if (TopRight.Contains(cursor)) message.Result = (IntPtr)HTTOPRIGHT;
                else if (BottomLeft.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMLEFT;
                else if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;

                else if (Top.Contains(cursor)) message.Result = (IntPtr)HTTOP;
                else if (Left.Contains(cursor)) message.Result = (IntPtr)HTLEFT;
                else if (Right.Contains(cursor)) message.Result = (IntPtr)HTRIGHT;
                else if (Bottom.Contains(cursor)) message.Result = (IntPtr)HTBOTTOM;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            miniMax();
        }
    }
}
