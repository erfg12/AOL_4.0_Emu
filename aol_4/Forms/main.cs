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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using aol.Classes;
using CefSharp;
using CefSharp.WinForms;

namespace aol.Forms
{
    public partial class main : Form
    {
        #region DLLImports
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);

        [DllImport("winmm.dll")]
        private static extern uint mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool IsWindow(IntPtr hWnd);
        #endregion

        #region win95_theme
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int cGrip = 16;
        private const int cCaption = 32;

        Rectangle FormBottom { get { return new Rectangle(padding, this.ClientSize.Height - padding, this.ClientSize.Width - (padding * 2), padding); } }
        Rectangle FormRight { get { return new Rectangle(this.ClientSize.Width - padding, padding, padding, this.ClientSize.Height - (padding * 2)); } }
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - padding, this.ClientSize.Height - padding, padding, padding); } }

        private const int
            HTLEFT = 10,
            HTRIGHT = 11,
            HTTOP = 12,
            HTTOPLEFT = 13,
            HTTOPRIGHT = 14,
            HTBOTTOM = 15,
            HTBOTTOMLEFT = 16,
            HTBOTTOMRIGHT = 17;

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
        #endregion

        #region shared_variables
        bool newWindow = true;
        string old_url = "";
        #endregion

        #region my_functions
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

        private void openAccWindow()
        {
            accForm acf = new accForm();
            acf.Owner = (Form)this;
            acf.MdiParent = this;
            acf.Show();

            if (MdiChildren.Length <= 0)
                return;

            Task taskA = new Task(() =>
            {
                while (true)
                {
                    try
                    {
                        if (!MdiChildren.Any())
                        {
                            startProgram();
                            break;
                        }
                    }
                    catch
                    {
                        //Debug.WriteLine("openAccWindow() crashed");
                        break;
                    }
                }
            });
            taskA.Start();
        }

        private void CheckEmail()
        {
            if (email.checkNewEmail())
            {
                if (!email.youGotMail)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.Stream = Properties.Resources.youGotmail;
                    player.Play();
                    read_mail_btn.Image = Properties.Resources.youve_got_mail_icon;
                    email.youGotMail = true;
                }
            }
        }

        private void startProgram()
        {
            Invoke((MethodInvoker)async delegate ()
            {
                try
                {
                    if (this == null)
                        return;

                    if (Handle == null)
                        return;

                    if (IsWindow(Handle) == false)
                        return;

                    // open fake dial up window
                    dial_up du = new dial_up();
                    du.Owner = (Form)this;
                    du.MdiParent = this;
                    du.Show();

                    // wait for dial up to finish
                    if (accForm.tmpLocation == "Dial-Up")
                        await Task.Delay(TimeSpan.FromSeconds(26));
                    else
                        await Task.Delay(TimeSpan.FromSeconds(1));

                    // open buddies online window
                    if (accForm.tmpUsername != "Guest")
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

                    if (accForm.tmpUsername != "Guest")
                    {
                        checkMail.Enabled = true;
                        checkMail.Start();

                        foreach (string i in sqlite_accounts.getHistory())
                        {
                            addrBox.Items.Add(i);
                        }
                    }
                }
                catch
                {
                    return; // object was disposed
                }
            });

            // enable buttons
            internet_btn.Image = Properties.Resources.internet_icon_enabled;
            channels_btn.Image = Properties.Resources.channels_icon_enabled;
            people_btn.Image = Properties.Resources.people_icon_enabled;
            quotes_btn.Image = Properties.Resources.quotes_icon_enabled;
            perks_btn.Image = Properties.Resources.perks_icon_enabled;
            weather_btn.Image = Properties.Resources.weather_icon_enabled;
            preferencesToolStripMenuItem.Enabled = true; // settings holds email info

            chat.startConnection();
        }

        public void GoToURL()
        {
            try
            {
                if (!newWindow)
                {
                    if (ActiveMdiChild is Browse)
                        ((Browse)ActiveMdiChild).goToUrl(addrBox.Text);
                    else // we don't have a browser window selected, open a new one anyways
                    {
                        openBrowser(addrBox.Text);
                        newWindow = false;
                    }
                }
                else
                {
                    openBrowser(addrBox.Text);
                    if (accForm.tmpUsername != "Guest" && addrBox.Text.Contains("."))
                        sqlite_accounts.addHistory(addrBox.Text);
                    if (!addrBox.Items.Contains(addrBox.Text))
                        addrBox.Items.Add(addrBox.Text);
                    newWindow = false;
                }
            }
            catch
            {
                if (MessageBox.Show("GoToURL() function crashed!" + Environment.NewLine + "Please install VC++ 2015 Redistributable!" + Environment.NewLine + "Would you like to go to https://www.microsoft.com/en-us/download/details.aspx?id=52685 ?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    Process.Start("https://support.google.com/accounts/answer/185833");
            }
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
        #endregion

        #region winform_functions
        public main()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            Close();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            miniMax();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Debug.WriteLine("ClientSize Width:" + this.ClientSize.Width);
            Debug.WriteLine("ClientSize Height:" + this.ClientSize.Height);
            if (Properties.Settings.Default.fullScreen)
                WindowState = FormWindowState.Maximized;

            preferencesToolStripMenuItem.Enabled = false;

            findDropDown.SelectedIndex = 0; // default find text selected

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

        private void fileBtn_Click(object sender, EventArgs e)
        {
            fileContextMenuStrip.Show(this.Location.X, this.Location.Y + 40);
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

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
        
        private void getMdiChildURL_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ActiveMdiChild is Browse)
                {
                    if (((Browse)ActiveMdiChild).loading)
                    {
                        loadingIcon.Enabled = true;
                    }
                    else
                    {
                        loadingIcon.Enabled = false;
                        loadingIcon.Image.SelectActiveFrame(new FrameDimension(loadingIcon.Image.FrameDimensionsList[0]), 0);
                        loadingIcon.Image = loadingIcon.Image;
                    }
                    if (((Browse)ActiveMdiChild).url != old_url)
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

        private void addrBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (addrBox.Text.Length <= 3)
                newWindow = true;

            if (e.KeyCode == Keys.Enter)
            {
                GoToURL();
                e.Handled = true;
                e.SuppressKeyPress = true;
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
            if (ActiveMdiChild is Browse)
                ((Browse)ActiveMdiChild).browser.Back();
        }

        private void forwardBtn_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Browse)
                ((Browse)ActiveMdiChild).browser.Forward();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Browse)
                ((Browse)ActiveMdiChild).browser.Stop();
        }

        private void reloadBtn_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild is Browse)
                ((Browse)ActiveMdiChild).browser.Reload();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ActiveMdiChild is Browse)
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
            SignOff();
        }

        // channels button
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (!channelsContextMenuStrip.Visible)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                channelsContextMenuStrip.Show(ptLowerLeft);
            }
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
        
        private void mail_center_btn_Click(object sender, EventArgs e)
        {
            if (!mailCenterContextMenuStrip.Visible)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                mailCenterContextMenuStrip.Show(ptLowerLeft);
            }
        }
        
        private void my_files_btn_Click(object sender, EventArgs e)
        {
            if (!myFilesContextMenuStrip.Visible)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                myFilesContextMenuStrip.Show(ptLowerLeft);
            }
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
            foreach (Form frm in MdiChildren)
            {
                //frm.Dispose();
                Debug.WriteLine("Closing " + frm.Text);
                frm.Close();
            }
        }

        private void SignOff()
        {
            if (accForm.tmpUsername == "")
                return;

            DisposeAllButThis();

            accForm.tmpUsername = "";
            accForm.tmpPassword = "";
            accForm.tmpLocation = "";

            if (chat.irc.IsClientRunning())
            {
                buddies_online.shuttingDown = true;
                chat.irc.StopClient();
            }

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Goodbye;
            player.Play();

            Thread.Sleep(1000);
        }

        private void signOffBtn_Click(object sender, EventArgs e)
        {
            SignOff();
            openAccWindow();
        }

        private void readMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailbox mb = new mailbox();
            mb.Owner = (Form)this;
            mb.MdiParent = this;
            mb.Show();
        }

        private void read_mail_btn_Click(object sender, EventArgs e)
        {
            mailbox mb = new mailbox();
            mb.Owner = (Form)this;
            mb.MdiParent = this;
            mb.Show();
        }

        private void write_mail_button_Click(object sender, EventArgs e)
        {
            write_mail wmf = new write_mail();
            wmf.Owner = (Form)this;
            wmf.MdiParent = this;
            wmf.Show();
        }

        private void mailCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailbox mb = new mailbox();
            mb.Owner = (Form)this;
            mb.MdiParent = this;
            mb.Show();
        }

        private void writeMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            write_mail wmf = new write_mail();
            wmf.Owner = (Form)this;
            wmf.MdiParent = this;
            wmf.Show();
        }

        private void oldMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailbox mb = new mailbox();
            mb.Owner = (Form)this;
            mb.MdiParent = this;
            mb.Show();
        }

        private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mailbox mb = new mailbox();
            mb.Owner = (Form)this;
            mb.MdiParent = this;
            mb.Show();
        }

        private void checkMail_Tick(object sender, EventArgs e)
        {
            if (accForm.tmpUsername == "" || accForm.tmpUsername == "Guest") // prevent crash on sign off
                return;

            read_mail_btn.Image = Properties.Resources.nomail_icon;
            Thread thread = new Thread(new ThreadStart(CheckEmail));
            thread.Start();
            //Debug.WriteLine("Checking for new mail");
            // FIXME - not reliable if receiving more than 1 message at a time.
            /*if (chat.newPM != "")
            {
                bool foundFrm = false;
                Debug.WriteLine("Checking for open form with username tag");
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Tag == null)
                        continue;

                    if (frm.Tag.ToString() == chat.newPM)
                        foundFrm = true;
                }

                if (!foundFrm)
                {
                    Debug.WriteLine("Opening IM for user " + chat.newPM);
                    instant_message im = new instant_message(chat.newPM);
                    im.Owner = this;
                    im.MdiParent = this;
                    im.Tag = chat.newPM;
                    im.Show();
                }
                chat.newPM = "";
            }*/
        }

        private void mailPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.Owner = (Form)this;
            sf.MdiParent = this;
            sf.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                return;

            if (RectangleToScreen(FormRight).Contains(MousePosition) && !resizeB && !resizeD)
            {
                Cursor = Cursors.SizeWE;
                if (MouseButtons == MouseButtons.Left) resizeR = true;
            }
            else if (RectangleToScreen(FormBottom).Contains(MousePosition) && !resizeR && !resizeD)
            {
                Cursor = Cursors.SizeNS;
                if (MouseButtons == MouseButtons.Left) resizeB = true;
            }
            else if (RectangleToScreen(BottomRight).Contains(MousePosition) && !resizeB && !resizeR)
            {
                Cursor = Cursors.SizeNWSE;
                if (MouseButtons == MouseButtons.Left) resizeD = true;
            }
            else
            {
                if (Cursor == Cursors.SizeNWSE || Cursor == Cursors.SizeNESW || Cursor == Cursors.SizeNS || Cursor == Cursors.SizeWE)
                {
                    Cursor = Cursors.Default;
                }
            }

            if (MouseButtons != MouseButtons.Left)
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
        
        private void my_aol_btn_Click(object sender, EventArgs e)
        {
            if (!myAOLContextMenuStrip.Visible)
            {
                PictureBox btnSender = (PictureBox)sender;
                Point ptLowerLeft = new Point(0, btnSender.Height);
                ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
                myAOLContextMenuStrip.Show(ptLowerLeft);
            }
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.Owner = (Form)this;
            sf.MdiParent = this;
            sf.Show();
        }

        private void downloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            miniMax();
        }
        #endregion
    }
}