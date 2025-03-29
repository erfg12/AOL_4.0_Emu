using aol.Services;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace aol.Forms;
public partial class InstantMessageForm : Win95Theme
{
    string privateLog = "";
    string user = "";
    FileSystemWatcher watch = null;

    private void instant_message_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        Text = user + " Instant Message";
        mainTitle.Text = user + " Instant Message";
        if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
    }

    private void sendBtn_Click(object sender, EventArgs e)
    {
        // send to server
        ChatService.irc.SendMessageToChannel(myMessageBox.Text, user);
        // write to file
        string logpath = Application.StartupPath + @"\chatlogs";
        string privateLog = logpath + @"\PM_" + user + ".txt";
        try
        {
            File.AppendAllText(privateLog, Account.tmpUsername + ": " + myMessageBox.Text + '\n');
            sendMsgSound();
        }
        catch
        {
            MessageBox.Show("ERROR: There was an issue writing to log file: " + privateLog);
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
        string logpath = Application.StartupPath + @"\chatlogs";
        privateLog = logpath + @"\PM_" + u + ".txt";
        user = u;

        try
        {
            if (!Directory.Exists(logpath))
                Directory.CreateDirectory(logpath);
        } catch
        {
            MessageBox.Show("ERROR: There was an issue creating log directory: " + logpath);
        }

        try
        {
            if (!File.Exists(privateLog))
                File.Create(privateLog).Dispose();
        } catch
        {
            MessageBox.Show("ERROR: There was an issue creating log file: " + privateLog);
        }

        InitializeComponent();
    }

    private void instant_message_Load(object sender, EventArgs e)
    {
        
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void myMessageBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            sendBtn.PerformClick();
            e.Handled = true;
            e.SuppressKeyPress = true;
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

    private void receivedMsgSound()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        player.Stream = Properties.Resources.imrcv;
        player.Play();
    }

    private void SmiliesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-)";
    }

    private void frowningCtrl2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-(";
    }

    private void winkingCtrl3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ";-)";
    }

    private void sendMsgSound()
    {
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        player.Stream = Properties.Resources.imsend;
        player.Play();
    }

    private void pStickingouttongueCtrl4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-P";
    }

    private void oSurprisedCtrl5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "=-O";
    }

    private void kissingCtrl6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-*";
    }

    private void oYellingCtrl7ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ">:o";
    }

    private void coolCtrl8ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "8-)";
    }

    private void moneymouthCtrlShift1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-$";
    }

    private void footinmouthCtrlShift2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-!";
    }

    private void embarrassedCtrlShift3ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-[";
    }

    private void oInnocentCtrlShift4ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += "O:-)";
    }

    private void undecidedCtrlShift5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += @":-\";
    }

    private void cryingCtrlShift6ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += @":'(";
    }

    private void xLipsaresealedCtrlShift7ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-X";
    }

    private void dLaughingCtrlShift8ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        myMessageBox.Text += ":-D";
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void writeFileToBox(bool init = false) // THIS CRASHES ON PRIV MSG 2
    {
        string lastLine = "";
        //try
        //{
            messagesBox.Invoke(new MethodInvoker(delegate
            {
                using (FileStream file = new FileStream(privateLog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            if (init)
                            {
                                try
                                {
                                    messagesBox.AppendText(sr.ReadLine() + Environment.NewLine);
                                    receivedMsgSound();
                                }
                                catch
                                {
                                    Debug.WriteLine("ERROR: writeFileToBox function crashed at AppendText[1].");
                                }
                            }
                            else
                                lastLine = sr.ReadLine();
                        }
                    }
                }
                if (!init)
                {
                    try
                    {
                        messagesBox.AppendText(lastLine + Environment.NewLine);
                        receivedMsgSound();
                    }
                    catch
                    {
                        Debug.WriteLine("ERROR: writeFileToBox function crashed at AppendText[2].");
                    }
                }
                messagesBox.ScrollToCaret();
            }));
        /*} catch
        {
            Debug.WriteLine("ERROR: Msgbox wasn't ready. I prevented a crash.");
        }*/
    }

    private void OnChanged(object source, FileSystemEventArgs e)
    {
        Debug.WriteLine("onchanged");
        writeFileToBox();
    }

    private void keepReading()
    {
        try
        {
            watch = new FileSystemWatcher();
            watch.Path = Path.GetDirectoryName(privateLog);
            watch.Filter = Path.GetFileName(privateLog);
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.EnableRaisingEvents = true;
        } catch
        {
            MessageBox.Show("ERROR: keepReading function has crashed.");
        }
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        Thread.Sleep(1000);
        writeFileToBox(true);
        keepReading();
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}
