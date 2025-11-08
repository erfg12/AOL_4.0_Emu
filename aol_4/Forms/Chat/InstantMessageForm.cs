using System.Windows.Forms;

namespace aol.Forms;
public partial class InstantMessageForm : _Win95Theme
{
    private readonly string privateLog;
    private readonly string user;

    FileSystemWatcher watch = null;

    protected override bool ShowKeyboardCues => true;

    private void instant_message_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        Text = user + " Instant Message";
        mainTitle.Text = user + " Instant Message";

        TitleBar.BringToFront();
        topMenuPanel.SendToBack();

        WriteFileToBox(true);
        KeepReading();
    }

    private void cancelBtn_Click(object sender, EventArgs e)
    {
        myMessageBox.Clear();
    }

    public InstantMessageForm(string u)
    {
        InitializeComponent();

        user = u;

        string logpath = Application.StartupPath + @"\chatlogs";
        privateLog = $"{logpath}\\PM_{user}.txt";

        try
        {
            if (!Directory.Exists(logpath))
                Directory.CreateDirectory(logpath);
            if (!File.Exists(privateLog))
                File.Create(privateLog).Dispose();
        }
        catch
        {
            OpenMsgBox("ERROR", $"There was an issue creating log file {privateLog}. Does the app have permission?");
        }

        TitleBar.MouseMove += MoveWindow;
        TitleBar.DoubleClick += TitleBar_DoubleClick;
        mainTitle.MouseMove += MoveWindow;
        mainTitle.DoubleClick += TitleBar_DoubleClick;
        maxBtn.Click += MaxRestoreButton_Click;
        this.LocationChanged += OnLocationChanged;
    }

    private void MyMessageBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter && sendBtn.Enabled)
        {
            SendMessage();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    void AppendMessage(RichTextBox box, string name, Color nameColor, string message)
    {
        box.SelectionColor = nameColor;
        box.SelectionFont = new Font(box.Font, FontStyle.Bold);
        box.AppendText(name + ":");

        box.SelectionColor = Color.Black;
        box.SelectionFont = new Font(box.Font, FontStyle.Regular);
        box.AppendText(" " + message + "\n");
    }

    private void SendMessage()
    {
        // send to server
        MainForm.chat.irc.SendMessageToChannel(myMessageBox.Text, user);

        try
        {
            File.AppendAllText(privateLog, Account.tmpUsername + ": " + myMessageBox.Text + '\n');
            SendMsgSound();
        }
        catch
        {
            OpenMsgBox("ERROR", "There was an issue writing to log file: " + privateLog);
        }
        // clear msg box
        myMessageBox.Clear();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void ReceivedMsgSound()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        player.Stream = Properties.Resources.imrcv;
        player.Play();
    }

    private void SmiliesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-)";
    }

    private void FrowningCtrl2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-(";
    }

    private void WinkingCtrl3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ";-)";
    }

    private void SendMsgSound()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return;

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        player.Stream = Properties.Resources.imsend;
        player.Play();
    }

    private void PStickingouttongueCtrl4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-P";
    }

    private void OSurprisedCtrl5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "=-O";
    }

    private void KissingCtrl6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-*";
    }

    private void OYellingCtrl7ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ">:o";
    }

    private void CoolCtrl8ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "8-)";
    }

    private void MoneymouthCtrlShift1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-$";
    }

    private void FootinmouthCtrlShift2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-!";
    }

    private void EmbarrassedCtrlShift3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-[";
    }

    private void OInnocentCtrlShift4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "O:-)";
    }

    private void UndecidedCtrlShift5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += @":-\";
    }

    private void CryingCtrlShift6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += @":'(";
    }

    private void XLipsaresealedCtrlShift7ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-X";
    }

    private void DLaughingCtrlShift8ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-D";
    }

    private void WriteFileToBox(bool init = false) // THIS CRASHES ON PRIV MSG 2
    {
        string lastLine = "";
        try
        {
            using FileStream file = new FileStream(privateLog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                if (init)
                {
                    try
                    {
                        messagesBox.Invoke(new MethodInvoker(delegate
                        {
                            var msg = sr.ReadLine() + Environment.NewLine;
                            if (msg.Contains(":"))
                            {
                                // color the usernames
                                string[] parts = msg.Split(new char[] { ':' }, 2);
                                string name = parts[0];
                                string message = parts.Length > 1 ? parts[1].Trim() : "";
                                AppendMessage(messagesBox, name, name.Equals(Account.tmpUsername) ? Color.Blue : Color.Red, message);
                            } else // not a user message
                                messagesBox.AppendText(msg);
                        }));
                        ReceivedMsgSound();
                    }
                    catch
                    {
                        Debug.WriteLine("ERROR: writeFileToBox function crashed at AppendText[1].");
                    }
                }
                else
                    lastLine = sr.ReadLine();
            }

            if (!init)
            {
                try
                {
                    messagesBox.Invoke(new MethodInvoker(delegate
                    {
                        var msg = lastLine + Environment.NewLine;
                        if (msg.Contains(":"))
                        {
                            // color the usernames
                            string[] parts = msg.Split(new char[] { ':' }, 2);
                            string name = parts[0];
                            string message = parts.Length > 1 ? parts[1].Trim() : "";
                            AppendMessage(messagesBox, name, name.Equals(Account.tmpUsername) ? Color.Blue : Color.Red, message);
                        }
                        else // not a user message
                            messagesBox.AppendText(msg);
                    }));
                    ReceivedMsgSound();
                }
                catch
                {
                    Debug.WriteLine("ERROR: writeFileToBox function crashed at AppendText[2].");
                }
            }
            messagesBox.Invoke(new MethodInvoker(delegate
            {
                messagesBox.ScrollToCaret();
            }));
        }
        catch
        {
            Debug.WriteLine("ERROR: Msgbox wasn't ready. I prevented a crash.");
        }
    }

    private void OnChanged(object source, FileSystemEventArgs e)
    {
        Debug.WriteLine("onchanged");
        WriteFileToBox();
    }

    private void KeepReading()
    {
        try
        {
            watch = new FileSystemWatcher();
            watch.Path = Path.GetDirectoryName(privateLog);
            watch.Filter = Path.GetFileName(privateLog);
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.EnableRaisingEvents = true;
        }
        catch
        {
            MessageBox.Show("ERROR: keepReading function has crashed.");
        }
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Update messages received. To-Do: Make this event driven.
    /// </summary>
    private void UpdateMessagesTimer_Tick(object sender, EventArgs e)
    {

    }

    private void sendBtn_Click_1(object sender, EventArgs e)
    {
        SendMessage();
    }

    private void myMessageBox_TextChanged(object sender, EventArgs e)
    {
        if (myMessageBox.Text.Length > 0)
        {
            sendBtn.Image = Properties.Resources.im_send_enabled;
            sendBtn.Enabled = true;
        }
        else
        {
            sendBtn.Image = Properties.Resources.im_send_disabled;
            sendBtn.Enabled = false;
        }
    }
}
