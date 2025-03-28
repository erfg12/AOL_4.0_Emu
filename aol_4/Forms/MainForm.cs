using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using aol.Classes;
using System.Configuration;

namespace aol.Forms;
public partial class MainForm : Win95Theme
{
    bool newWindow = true;
    string old_url = "";
    public List<string> tmpHistory = new List<string>();
    bool formClosing = false;
    int topMenuPadding = 42;

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

    public void goToChannel(string channel, int width = 736, int height = 420)
    {
        string path = Directory.GetCurrentDirectory() + @"\Channels\" + channel + ".htm";
        Debug.WriteLine(path);
        Form BrowseWnd = new ChannelViewForm(path);
        BrowseWnd.Owner = this;
        BrowseWnd.MdiParent = this;
        BrowseWnd.Width = width + 6;
        BrowseWnd.Height = height + 26;
        BrowseWnd.Show();
    }

    private async Task openAccWindow()
    {
        accForm acf = new accForm();
        acf.Owner = (Form)this;
        acf.MdiParent = this;
        acf.Show();
    }

    private void CheckEmail()
    {
        if (MailClass.checkNewEmail())
        {
            if (!MailClass.youGotMail)
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.Stream = Properties.Resources.youGotmail;
                    player.Play();
                }
                read_mail_btn.Image = Properties.Resources.youve_got_mail_icon;
                MailClass.youGotMail = true;
            }
        }
    }

    private void faveBtn_Click(object sender, EventArgs e)
    {
        var btn = sender as Button; // TEST
        MessageBox.Show(btn.Tag.ToString());
    }

    public void startProgram()
    {
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

        // enable buttons
        internet_btn.Image = Properties.Resources.internet_icon_enabled;
        channels_btn.Image = Properties.Resources.channels_icon_enabled;
        people_btn.Image = Properties.Resources.people_icon_enabled;
        quotes_btn.Image = Properties.Resources.quotes_icon_enabled;
        perks_btn.Image = Properties.Resources.perks_icon_enabled;
        weather_btn.Image = Properties.Resources.weather_icon_enabled;
        preferencesToolStripMenuItem.Enabled = true; // settings holds email info

        ChatClass.startConnection();
    }

    public void OpenBuddyList()
    {
        BuddyListForm bo = new BuddyListForm();
        this.Invoke(new MethodInvoker(delegate
        {
            bo.Owner = (Form)this;
            bo.MdiParent = this;
            bo.Show();
        }));
    }

    public void OpenHomeWindow()
    {
        HomeMenuForm hm = new HomeMenuForm();
        this.Invoke(new MethodInvoker(delegate
        {
            hm.Owner = (Form)this;
            hm.MdiParent = this;
            hm.Show();
        }));
    }

    public void reloadAddressBarHistory()
    {
        try
        {
            addrBox.Items.Clear();
            tmpHistory.Clear();
            foreach (string i in SqliteAccountsClass.getHistory())
            {
                if (string.IsNullOrEmpty(i))
                    continue;
                addrBox.Items.Add(i);
                tmpHistory.Add(i);
            }
        }
        catch
        {
            Debug.WriteLine("Prevented a crash at reloadAddressBarHistory()");
        }
    }

    public void GoToURL()
    {
        if (addrBox.Text == "Type Keyword or Web Address here and click Go")
            addrBox.Text = ""; // clear it

        //try
        //{
            if (!newWindow)
            {
                if (ActiveMdiChild is BrowserForm)
                    ((BrowserForm)ActiveMdiChild).goToUrl(addrBox.Text);
                else // we don't have a browser window selected, open a new one anyways
                {
                    openBrowser(addrBox.Text);
                    newWindow = false;
                }
            }
            else
            {
                openBrowser(addrBox.Text);
                if (Account.tmpUsername != "Guest" && addrBox.Text.Contains("."))
                    SqliteAccountsClass.addHistory(addrBox.Text);
                if (!addrBox.Items.Contains(addrBox.Text))
                {
                    addrBox.Items.Add(addrBox.Text);
                    tmpHistory.Add(addrBox.Text);
                }
                newWindow = false;
            }
        //}
        //catch
        //{
            //if (MessageBox.Show("GoToURL() function crashed!" + Environment.NewLine + "Please install VC++ 2015 Redistributable!" + Environment.NewLine + "Would you like to go to https://www.microsoft.com/en-us/download/details.aspx?id=52685 ?", "Visit", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
            //    Process.Start("https://support.google.com/accounts/answer/185833");
        //}
    }

    public void openBrowser(string url = "")
    {
        Form BrowseWnd = new BrowserForm(url);
        BrowseWnd.Owner = (Form)this;
        BrowseWnd.MdiParent = this;
        BrowseWnd.Show();
    }

    public MainForm()
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.None;
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        ConfigurationManager.AppSettings.Set("APIKey", "d8f6deea88bb177513cc8a14cf629020"); // for WeatherNet
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
        //miniMax(maxBtn);
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private async void Form1_Shown(object sender, EventArgs e)
    {
        Debug.WriteLine("ClientSize Width:" + ClientSize.Width);
        Debug.WriteLine("ClientSize Height:" + ClientSize.Height);
        if (Properties.Settings.Default.fullScreen)
            WindowState = FormWindowState.Maximized;

        ChatClass.irc.IrcClient.OnDebugMessage += ChatClass.debugOutputCallback;
        ChatClass.irc.IrcClient.OnMessageReceived += ChatClass.chatOutputCallback;
        ChatClass.irc.IrcClient.OnRawMessageReceived += ChatClass.rawOutputCallback;
        ChatClass.irc.IrcClient.OnUserListReceived += ChatClass.userListCallback;
        //chat.irc.DccClient.OnDccDebugMessage += chat.dccDebugCallback;
        ChatClass.irc.DccClient.OnDccEvent += ChatClass.downloadStatusChanged;

        preferencesToolStripMenuItem.Enabled = false;

        ToolTip toolTip1 = new ToolTip();
        toolTip1.SetToolTip(backBtn, "Back");
        toolTip1.SetToolTip(forwardBtn, "Forward");
        toolTip1.SetToolTip(reloadBtn, "Refresh");
        toolTip1.SetToolTip(write_mail_button, "Write mail and send files.");
        toolTip1.SetToolTip(my_files_btn, "Your Personal Documents.");
        toolTip1.SetToolTip(print_page_btn, "Print text or pictures.");
        toolTip1.SetToolTip(mail_center_btn, "Everything about mail.");
        toolTip1.SetToolTip(my_aol_btn, "Customize AOL for YOU.");
        toolTip1.SetToolTip(favorites_btn, "See your favorite places.\nDrag heart icons here.");

        // open account form window
        await openAccWindow();
    }

    private void fileBtn_Click(object sender, EventArgs e)
    {
        fileContextMenuStrip.Show(this.Location.X, Location.Y + topMenuPadding);
    }

    private void closeForm_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Form1_MdiChildActivate(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
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
            if (ActiveMdiChild is BrowserForm)
            {
                if (((BrowserForm)ActiveMdiChild).loading)
                {
                    loadingIcon.Enabled = true;
                }
                else
                {
                    loadingIcon.Enabled = false;
                    if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        loadingIcon.Image.SelectActiveFrame(new FrameDimension(loadingIcon.Image.FrameDimensionsList[0]), 0);
                    loadingIcon.Image = loadingIcon.Image;
                }

                if (((BrowserForm)ActiveMdiChild).url != old_url)
                {
                    addrBox.Text = ((BrowserForm)this.ActiveMdiChild).url;
                    old_url = addrBox.Text = ((BrowserForm)this.ActiveMdiChild).url;
                    mie_badge.Image = Properties.Resources.mie_badge;
                }
            }
            else // if we're not selecting a browser window
            {
                mie_badge.Image = null;
                loadingIcon.Enabled = false;
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    loadingIcon.Image.SelectActiveFrame(new FrameDimension(loadingIcon.Image.FrameDimensionsList[0]), 0);
                loadingIcon.Image = loadingIcon.Image;
            }
        } catch
        {
            MessageBox.Show("getMdiChildURL_Tick() function crashed!");
        }
    }

    private void addrBox_KeyDown_1(object sender, KeyEventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

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
        if (Account.tmpUsername == "")
            return;

        GoToURL();
    }

    private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
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
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).wv2.GoBack();
    }

    private void forwardBtn_Click_1(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).wv2.GoForward();
    }

    private void stopBtn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).wv2.Stop();
    }

    private void reloadBtn_Click_1(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).wv2.Reload();
    }

    private void homeBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (ActiveMdiChild is BrowserForm)
                ((BrowserForm)this.ActiveMdiChild).goToUrl(Properties.Settings.Default.homeSite);
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
        formClosing = true;
        SignOff();
    }

    // channels button
    private void pictureBox10_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

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
        HomeMenuForm hm = new HomeMenuForm();
        hm.Owner = (Form)this;
        hm.MdiParent = this;
        hm.Show();
    }

    private void editBtn_Click(object sender, EventArgs e)
    {
        editContextMenuStrip.Show(this.Location.X + 28, this.Location.Y + topMenuPadding);
    }

    private void windowBtn_Click(object sender, EventArgs e)
    {
        windowContextMenuStrip.Show(this.Location.X + 54, this.Location.Y + topMenuPadding);
    }

    private void helpBtn_Click(object sender, EventArgs e)
    {
        helpContextMenuStrip.Show(this.Location.X + 155, this.Location.Y + topMenuPadding);
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
            Debug.WriteLine("Closing " + frm.Text);
            try
            {
                frm.Close();
            }
            catch { }
        }
    }

    private void SignOff()
    {
        if (Account.tmpUsername == "")
            return;

        DisposeAllButThis();
        
        Account.tmpUsername = "";
        Account.tmpPassword = "";
        Account.tmpLocation = "";

        if (ChatClass.irc.IsClientRunning())
            ChatClass.irc.IrcClient.WriteIrc("QUIT"); //chat.irc.StopClient(); // causes a hang on shutdown

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.Goodbye;
            player.Play();
        }

        Thread.Sleep(1000);

        internet_btn.Image = Properties.Resources.internet_icon;
        channels_btn.Image = Properties.Resources.channels_icon;
        people_btn.Image = Properties.Resources.people_icon;
        quotes_btn.Image = Properties.Resources.quotes_icon;
        perks_btn.Image = Properties.Resources.perks_icon;
        weather_btn.Image = Properties.Resources.weather_icon;
        preferencesToolStripMenuItem.Enabled = false; // settings holds email info
        MailClass.youGotMail = false;
        signOffBtn.Text = "Sign On";
    }

    private async void signOffBtn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "") // not signed in yet
            return;

        SignOff();
        await openAccWindow();
    }

    private void readMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailboxForm mb = new MailboxForm();
        mb.Owner = (Form)this;
        mb.MdiParent = this;
        mb.Show();
    }

    private void read_mail_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailboxForm mb = new MailboxForm();
        mb.Owner = (Form)this;
        mb.MdiParent = this;
        mb.Show();
    }

    private void write_mail_button_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;



        MailWriteForm wmf = new MailWriteForm();
        wmf.Owner = (Form)this;
        wmf.MdiParent = this;
        wmf.Show();
    }

    private void mailCenterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailboxForm mb = new MailboxForm();
        mb.Owner = (Form)this;
        mb.MdiParent = this;
        mb.Show();
    }

    private void writeMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailWriteForm wmf = new MailWriteForm();
        wmf.Owner = (Form)this;
        wmf.MdiParent = this;
        wmf.Show();
    }

    private void Favorites_btn_Click(object sender, EventArgs e)
    {
        if (!myFavoritesContextMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            myFavoritesContextMenuStrip.Show(ptLowerLeft);
        }
    }

    private void Internet_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        if (!internetMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            internetMenuStrip.Show(ptLowerLeft);
        }
    }

    private void People_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        if (!peopleMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            peopleMenuStrip.Show(ptLowerLeft);
        }
    }

    private void FindBtn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        if (!findMenuStrip.Visible)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            findMenuStrip.Show(ptLowerLeft);
        }
    }

    private void KeywordBtn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        KeywordForm kw = new KeywordForm();
        kw.Owner = (Form)this;
        kw.MdiParent = this;
        kw.Show();
    }

    private void Quotes_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;
    }

    private void Perks_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;
    }

    private void Weather_btn_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        WeatherForm w = new WeatherForm();
        w.Owner = (Form)this;
        w.MdiParent = this;
        w.Show();
    }

    private void ChatNowStripMenuItem_Click(object sender, EventArgs e)
    {
        ChatroomListForm cl = new ChatroomListForm();
        cl.Owner = this;
        cl.MdiParent = this;
        cl.Show();
    }

    private void Print_page_btn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).wv2.ExecuteScriptAsync("window.print();");
        else if (ActiveMdiChild is MailReadForm)
            ((MailReadForm)ActiveMdiChild).mailViewer.Print();
        else
            MessageBox.Show("Sorry, you can only print mail or web pages.");
    }

    private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        while (true)
        {
            if (formClosing)
                break;
            // check for new history items
            List<string> tmpList = new List<string>();
            tmpList.AddRange(tmpHistory);

            foreach (string t in tmpList)
            {
                if (!SqliteAccountsClass.getHistory().Contains(t))
                    reloadAddressBarHistory();
            }
            Thread.Sleep(1000);
        }
    }

    private void GoToKeywordMenuItem_Click(object sender, EventArgs e)
    {
        keywordBtn.PerformClick();
    }

    private void FavoritePlacesMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        FavoritePlacesForm fp = new FavoritePlacesForm();
        fp.Owner = (Form)this;
        fp.MdiParent = this;
        fp.Show();
    }

    private void KidsOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        goToChannel("kids");
    }

    private void buddyListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        BuddyListForm bo = new BuddyListForm();
        bo.Owner = (Form)this;
        bo.MdiParent = this;
        bo.Show();
    }

    private void searchTheWebMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        GoToURL();
    }

    private void findonTheWebMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "")
            return;

        GoToURL();
    }

    private void oldMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailboxForm mb = new MailboxForm();
        mb.Owner = (Form)this;
        mb.MdiParent = this;
        mb.Show();
    }

    private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest")
            return;

        MailboxForm mb = new MailboxForm();
        mb.Owner = (Form)this;
        mb.MdiParent = this;
        mb.Show();
    }

    private void checkMail_Tick(object sender, EventArgs e)
    {
        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest") // prevent crash on sign off
            return;

        if (!MailClass.youGotMail)
            read_mail_btn.Image = Properties.Resources.nomail_icon;
        Thread thread = new Thread(new ThreadStart(CheckEmail));
        thread.Start();
    }

    private void mailPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SettingsForm sf = new SettingsForm();
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
        PreferencesForm sf = new PreferencesForm();
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
        miniMax(maxBtn);
    }
}