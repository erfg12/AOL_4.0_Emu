﻿namespace aol.Forms;
public partial class InstantMessageForm : _Win95Theme
{
    private readonly string privateLog;
    private readonly string user;

    FileSystemWatcher watch = null;

    private void instant_message_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        Text = user + " Instant Message";
        mainTitle.Text = user + " Instant Message";
        WriteFileToBox(true);
        KeepReading();
    }

    private void sendBtn_Click(object sender, EventArgs e)
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
        if (e.KeyCode == Keys.Enter)
        {
            sendBtn.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
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
                            messagesBox.AppendText(sr.ReadLine() + Environment.NewLine);
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
                        messagesBox.AppendText(lastLine + Environment.NewLine);
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
}
