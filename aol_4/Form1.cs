﻿using System;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace aol
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

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);

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
                    this.ActiveMdiChild.Height = this.Height - 110;
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("ClientSize Width:" + this.ClientSize.Width);
            Debug.WriteLine("ClientSize Height:" + this.ClientSize.Height);
            if (Properties.Settings.Default.fullScreen)
                WindowState = FormWindowState.Maximized;

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.backBtn, "Back");
            toolTip1.SetToolTip(this.forwardBtn, "Forward");
            toolTip1.SetToolTip(this.reloadBtn, "Refresh");
            toolTip1.SetToolTip(this.write_mail_button, "Write mail and send files.");
            toolTip1.SetToolTip(this.my_files_btn, "Your Personal Documents.");
            toolTip1.SetToolTip(this.print_page_btn, "Print text or pictures.");
            toolTip1.SetToolTip(this.mail_center_btn, "Everything about mail.");
            toolTip1.SetToolTip(this.my_aol_btn, "Customize AOL for YOU.");
            toolTip1.SetToolTip(this.favorites_btn, "See your favorite places.\nDrag heart icons here.");

            // open account form window
            openAccWindow();
        }

        private void openAccWindow()
        {
            accForm acf = new accForm();
            acf.Owner = (Form)this;
            acf.MdiParent = this;
            acf.Show();
            
            Task taskA = new Task(() => {
                while (true)
                {
                    if (!MdiChildren.Any())
                    {
                        startProgram();
                        break;
                    }
                }
            });
            taskA.Start();
        }

        private void startProgram()
        {
            this.Invoke((MethodInvoker)async delegate ()
            {
                try
                {
                    if (IsWindow(this.Handle) == false)
                        return;
                }
                catch
                {
                    return; // object was disposed
                }

                // open fake dial up window
                dial_up du = new dial_up();
                du.Owner = (Form)this;
                du.MdiParent = this;
                du.Show();

                await Task.Delay(TimeSpan.FromSeconds(1)); // wait for dial up to finish

                // open buddies online window
                if (accounts.tmpUsername != "Guest")
                {
                    buddies_online bo = new buddies_online();
                    bo.Owner = (Form)this;
                    bo.MdiParent = this;
                    bo.Show();
                }

                // open home menu
                home_menu hm = new home_menu();
                hm.Owner = (Form)this;
                hm.MdiParent = this;
                hm.Show();
            });

            // enable buttons
            internet_btn.Image = Properties.Resources.internet_icon_enabled;
            channels_btn.Image = Properties.Resources.channels_icon_enabled;
            people_btn.Image = Properties.Resources.people_icon_enabled;
            quotes_btn.Image = Properties.Resources.quotes_icon_enabled;
            perks_btn.Image = Properties.Resources.perks_icon_enabled;
            weather_btn.Image = Properties.Resources.weather_icon_enabled;

            findDropDown.Invoke((MethodInvoker)delegate ()
            {
                findDropDown.SelectedIndex = 0; // default find text selected
            });
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
            try
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
                }
                else
                {
                    mie_badge.Image = null;
                }
            } catch
            {
                MessageBox.Show("getMdiChildURL_Tick() function crashed!");
            }
        }

        public void GoToURL()
        {
            try
            {
                if (!newWindow)
                {
                    if (this.ActiveMdiChild is Browse)
                        ((Browse)this.ActiveMdiChild).goToUrl(addrBox.Text);
                    else // we don't have a browser window selected, open a new one anyways
                    {
                        openBrowser(addrBox.Text);
                        newWindow = false;
                    }
                }
                else
                {
                    openBrowser(addrBox.Text);
                    newWindow = false;
                }
            } catch
            {
                MessageBox.Show("GoToURL() function crashed!" + Environment.NewLine + "Please install VC++ 2015 Redistributable!" + Environment.NewLine + "https://www.microsoft.com/en-us/download/details.aspx?id=52685");
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
            try
            {
                if (this.ActiveMdiChild is Browse)
                    ((Browse)this.ActiveMdiChild).goToUrl(Properties.Settings.Default.homeSite);
                else // we don't have a browser window selected, open a new one anyways
                {
                    openBrowser(Properties.Settings.Default.homeSite);
                    newWindow = false;
                }
            }
            catch
            { // something in the settings was messed up, load a default
                openBrowser("https://google.com");
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            editContextMenuStrip.Show(this.Location.X + 28, this.Location.Y + 40);
        }

        private void windowBtn_Click(object sender, EventArgs e)
        {
            windowContextMenuStrip.Show(this.Location.X + 54, this.Location.Y + 40);
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpContextMenuStrip.Show(this.Location.X + 155, this.Location.Y + 40);
        }

        bool mailCenterOpen = false;
        private void mail_center_btn_Click(object sender, EventArgs e)
        {
            if (!mailCenterOpen)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                mailCenterContextMenuStrip.Show(ptLowerLeft);
                mailCenterOpen = true;
            }
            else
                mailCenterOpen = false;
        }

        bool myFilesOpen = false;
        private void my_files_btn_Click(object sender, EventArgs e)
        {
            if (!myFilesOpen)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                myFilesContextMenuStrip.Show(ptLowerLeft);
                myFilesOpen = true;
            }
            else
                myFilesOpen = false;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            // doesnt trigger
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // doesnt trigger
        }

        private bool resizeR, resizeD, resizeB = false;
        const int padding = 5;

        public void DisposeAllButThis()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        private void signOffBtn_Click(object sender, EventArgs e)
        {
            DisposeAllButThis();
            openAccWindow();
        }

        Rectangle FormBottom { get { return new Rectangle(padding, this.ClientSize.Height - padding, this.ClientSize.Width - (padding * 2), padding); } }
        Rectangle FormRight { get { return new Rectangle(this.ClientSize.Width - padding, padding, padding, this.ClientSize.Height - (padding * 2)); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - padding, this.ClientSize.Height - padding, padding, padding); } }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                return;

            if (RectangleToScreen(FormRight).Contains(MousePosition) && !resizeB && !resizeD)
            {
                Cursor = Cursors.SizeWE;
                if (Control.MouseButtons == MouseButtons.Left) resizeR = true;
            }
            else if (RectangleToScreen(FormBottom).Contains(MousePosition) && !resizeR && !resizeD)
            {
                Cursor = Cursors.SizeNS;
                if (Control.MouseButtons == MouseButtons.Left) resizeB = true;
            }
            else if (RectangleToScreen(BottomRight).Contains(MousePosition) && !resizeB && !resizeR)
            {
                Cursor = Cursors.SizeNWSE;
                if (Control.MouseButtons == MouseButtons.Left) resizeD = true;
            }
            else
            {
                if (Cursor == Cursors.SizeNWSE || Cursor == Cursors.SizeNESW || Cursor == Cursors.SizeNS || Cursor == Cursors.SizeWE)
                {
                    Cursor = Cursors.Default;
                }
            }

            if (Control.MouseButtons != MouseButtons.Left)
            {
                resizeD = false; resizeR = false; resizeB = false;
            }

            if (resizeR)
                Width = Cursor.Position.X - Location.X;
            else if (resizeB)
                Height = Cursor.Position.Y - Location.Y;
            else if (resizeD)
            {
                Width = Cursor.Position.X - Location.X;
                Height = Cursor.Position.Y - Location.Y;
            }
        }

        bool myAOLOpen = false;
        private void my_aol_btn_Click(object sender, EventArgs e)
        {
            if (!myAOLOpen)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                myAOLContextMenuStrip.Show(ptLowerLeft);
                myAOLOpen = true;
            }
            else
                myAOLOpen = false;
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings();
            settingsForm.Show();
        }

        private void downloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            miniMax();
        }
    }
}