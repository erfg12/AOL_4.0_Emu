namespace aol.Forms;
public partial class MainForm : _Win95Theme
{
    bool newWindow = true;
    string old_url = "";
    public List<string> tmpHistory = new();
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

    private void CheckEmail()
    {
        if (MailService.CheckNewEmail() && !MailService.youGotMail)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.youGotmail;
            player.Play();

            read_mail_btn.Image = Properties.Resources.youve_got_mail_icon;
            MailService.youGotMail = true;
        }
    }

    private void FaveBtn_Click(object sender, EventArgs e)
    {
        var btn = sender as Button; // TEST
        MessageBox.Show(btn.Tag.ToString());
    }

    public static void GoToChannel(string channel, Form owner, Form mdiParent, int width = 736, int height = 422)
    {
        string title = $"{channel.ToTitleCase()} Channel";
        string path = $"{Directory.GetCurrentDirectory()}\\Channels\\{channel}\\index.html";
        Form BrowseWnd = new ChannelViewForm(path, title);
        BrowseWnd.Owner = owner;
        BrowseWnd.MdiParent = mdiParent;
        BrowseWnd.Width = width + 6;
        BrowseWnd.Height = height + 26;
        BrowseWnd.Show();
    }

    public void StartProgram()
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

        ChatService.StartConnection();
    }

    public void ReloadAddressBarHistory()
    {
        try
        {
            addrBox.Items.Clear();
            tmpHistory.Clear();
            foreach (string i in SqliteAccountsService.GetHistory())
            {
                if (string.IsNullOrEmpty(i))
                    continue;
                addrBox.Items.Add(i);
                tmpHistory.Add(i);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error in reloadAddressBarHistory() " + ex.Message);
        }
    }

    public void GoToURL()
    {
        if (addrBox.Text == "Type Keyword or Web Address here and click Go")
            addrBox.Text = ""; // clear it

        if (!newWindow)
        {
            if (ActiveMdiChild is BrowserForm)
                ((BrowserForm)ActiveMdiChild).GoToUrl(addrBox.Text);
            else // we don't have a browser window selected, open a new one anyways
            {
                OpenBrowser(addrBox.Text);
                newWindow = false;
            }
        }
        else
        {
            OpenBrowser(addrBox.Text);
            if (Account.SignedIn() && addrBox.Text.Contains("."))
                SqliteAccountsService.AddHistory(addrBox.Text);
            if (!addrBox.Items.Contains(addrBox.Text))
            {
                addrBox.Items.Add(addrBox.Text);
                tmpHistory.Add(addrBox.Text);
            }
            newWindow = false;
        }
    }

    public void OpenBrowser(string url = "")
    {
        MDIHelper.OpenForm(() => new BrowserForm(url), this);
    }

    public MainForm()
    {
        InitializeComponent();
        
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        ConfigurationManager.AppSettings.Set("APIKey", "d8f6deea88bb177513cc8a14cf629020"); // for WeatherNet
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {
        MiniMax(maxBtn);
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void MainForm_Shown(object sender, EventArgs e)
    {
        Debug.WriteLine("ClientSize Width:" + ClientSize.Width);
        Debug.WriteLine("ClientSize Height:" + ClientSize.Height);

        if (Properties.Settings.Default.fullScreen)
            WindowState = FormWindowState.Maximized;

        ChatService.irc.IrcClient.OnDebugMessage += ChatService.DebugOutputCallback;
        ChatService.irc.IrcClient.OnMessageReceived += ChatService.ChatOutputCallback;
        ChatService.irc.IrcClient.OnRawMessageReceived += ChatService.RawOutputCallback;
        ChatService.irc.IrcClient.OnUserListReceived += ChatService.UserListCallback;
        //chat.irc.DccClient.OnDccDebugMessage += chat.dccDebugCallback;
        ChatService.irc.DccClient.OnDccEvent += ChatService.DownloadStatusChanged;

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
        MDIHelper.OpenForm<SignOnForm>(this);
    }

    private void FileBtn_Click(object sender, EventArgs e)
    {
        fileContextMenuStrip.Show(this.Location.X, Location.Y + topMenuPadding);
    }

    private void CloseForm_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MainForm_MdiChildActivate(object sender, EventArgs e)
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

    private void GetMdiChildURL_Tick(object sender, EventArgs e)
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
                    loadingIcon.Image.SelectActiveFrame(new FrameDimension(loadingIcon.Image.FrameDimensionsList[0]), 0);
                    loadingIcon.Image = loadingIcon.Image;
                }

                if (((BrowserForm)ActiveMdiChild).url != null && ((BrowserForm)ActiveMdiChild).url != old_url)
                {
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
        }
        catch
        {
            MessageBox.Show("getMdiChildURL_Tick() crashed!");
        }
    }

    private void AddrBox_KeyDown(object sender, KeyEventArgs e)
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

    private void GoBtn_Click(object sender, EventArgs e)
    {
        GoToURL();
    }

    private void TableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) 
            return;

        SolidBrush brush1 = new SolidBrush(Color.FromArgb(102, 51, 102));
        if (e.Column == 13)
            e.Graphics.FillRectangle(brush1, e.CellBounds);
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).WebView.GoBack();
    }

    private void ForwardBtn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).WebView.GoForward();
    }

    private void StopBtn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).WebView.Stop();
    }

    private void ReloadBtn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).WebView.Reload();
    }

    private void HomeBtn_Click(object sender, EventArgs e)
    {
        try
        {
            if (ActiveMdiChild is BrowserForm)
                ((BrowserForm)this.ActiveMdiChild).GoToUrl(Properties.Settings.Default.homeSite);
            else // we don't have a browser window selected, open a new one anyways
            {
                OpenBrowser(Properties.Settings.Default.homeSite);
                newWindow = false;
            }
        }
        catch
        { // something in the settings was messed up, load a default
            OpenBrowser(Account.homePageUrl);
            newWindow = false;
        }
    }

    private void AddrBox_MouseClick(object sender, MouseEventArgs e)
    {
        if (addrBox.Text == "Type Keyword or Web Address here and click Go")
            addrBox.Text = "";
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SignOff();
    }

    private void ChannelsBtn_Click(object sender, EventArgs e)
    {
        if (!Account.SignedIn())
            return;

        if (!channelsContextMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            channelsContextMenuStrip.Show(ptLowerLeft);
        }
    }

    private void MainTitle_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void AOLTodayToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<HomeMenuForm>(this);
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        editContextMenuStrip.Show(this.Location.X + 28, this.Location.Y + topMenuPadding);
    }

    private void WindowBtn_Click(object sender, EventArgs e)
    {
        windowContextMenuStrip.Show(this.Location.X + 54, this.Location.Y + topMenuPadding);
    }

    private void HelpBtn_Click(object sender, EventArgs e)
    {
        helpContextMenuStrip.Show(this.Location.X + 155, this.Location.Y + topMenuPadding);
    }

    private void MailCenterBtn_Click(object sender, EventArgs e)
    {
        if (!mailCenterContextMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            mailCenterContextMenuStrip.Show(ptLowerLeft);
        }
    }

    private void MyFilesBtn_Click(object sender, EventArgs e)
    {
        if (!myFilesContextMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            myFilesContextMenuStrip.Show(ptLowerLeft);
        }
    }

    private void MainForm_SizeChanged(object sender, EventArgs e)
    {
        ResizeMaximizedChildren();
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
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
        if (!Account.SignedIn())
            return;

        DisposeAllButThis();

        Account.tmpUsername = "";
        Account.tmpPassword = "";
        Account.tmpLocation = "";

        if (ChatService.irc.IsClientRunning())
            ChatService.irc.IrcClient.WriteIrc("QUIT"); //chat.irc.StopClient(); // causes a hang on shutdown

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
        MailService.youGotMail = false;
        signOffBtn.Text = "Sign On";
    }

    private void SignOffBtn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
        {
            SignOff();
            MDIHelper.OpenForm<SignOnForm>(this);
        }
    }

    private void ReadMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<MailboxForm>(this);
    }

    private void ReadMailBtn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<MailboxForm>(this);
    }

    private void WriteMailBtn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm(() => new MailWriteForm(), this);
    }

    private void MailCenterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<MailboxForm>(this);
    }

    private void WriteMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm(() => new MailWriteForm(), this);
    }

    private void FavoritesBtn_Click(object sender, EventArgs e)
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
        if (Account.SignedIn() && !internetMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            internetMenuStrip.Show(ptLowerLeft);
        }
    }

    private void People_btn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn() && !peopleMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            peopleMenuStrip.Show(ptLowerLeft);
        }
    }

    private void FindBtn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn() && !findMenuStrip.Visible)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            findMenuStrip.Show(ptLowerLeft);
        }
    }

    private void KeywordBtn_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<KeywordForm>(this);
    }

    private void Quotes_btn_Click(object sender, EventArgs e)
    {
        if (!Account.SignedIn())
            return;
    }

    private void Perks_btn_Click(object sender, EventArgs e)
    {
        if (!Account.SignedIn())
            return;
    }

    private void Weather_btn_Click(object sender, EventArgs e)
    {
        WeatherForm w = new WeatherForm();
        w.Owner = (Form)this;
        w.MdiParent = this;
        w.Show();
    }

    private void ChatNowStripMenuItem_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<ChatroomListForm>(this);
    }

    private void Print_page_btn_Click(object sender, EventArgs e)
    {
        if (ActiveMdiChild is BrowserForm)
            ((BrowserForm)ActiveMdiChild).WebView.ExecuteScriptAsync("window.print();");
        else if (ActiveMdiChild is MailReadForm)
            ((MailReadForm)ActiveMdiChild).mailViewer.Print();
        else
            OpenMsgBox("ERROR", "Sorry, you can only print mail or web pages.");
    }

    private void GoToKeywordMenuItem_Click(object sender, EventArgs e)
    {
        keywordBtn.PerformClick();
    }

    private void FavoritePlacesMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<FavoritePlacesForm>(this);
    }

    private void KidsOnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        GoToChannel("kids", this, this);
    }

    private void BuddyListToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<BuddyListForm>(this);
    }

    private void SearchTheWebMenuItem_Click(object sender, EventArgs e)
    {
        GoToURL();
    }

    private void FindonTheWebMenuItem_Click(object sender, EventArgs e)
    {
        GoToURL();
    }

    private void OldMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<MailboxForm>(this);
    }

    private void SentMailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (Account.SignedIn())
            MDIHelper.OpenForm<MailboxForm>(this);
    }

    private void CheckMail_Tick(object sender, EventArgs e)
    {
        if (Account.SignedIn())
        {
            if (!MailService.youGotMail)
                read_mail_btn.Image = Properties.Resources.nomail_icon;
            Thread thread = new Thread(new ThreadStart(CheckEmail));
            thread.Start();
        }
    }

    private void MailPreferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SettingsForm sf = new SettingsForm()
        {
            Owner = (Form)this,
            MdiParent = this
        };
        sf.Show();
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Maximized)
            return;

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

    private void MyAolBtn_Click(object sender, EventArgs e)
    {
        if (!myAOLContextMenuStrip.Visible)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            myAOLContextMenuStrip.Show(ptLowerLeft);
        }
    }

    private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<PreferencesForm>(this);
    }

    private void DownloadManagerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.Personal));
    }

    private void TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        MiniMax(maxBtn);
    }
}