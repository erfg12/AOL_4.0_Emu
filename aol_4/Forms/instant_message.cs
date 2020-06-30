using aol.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    public partial class instant_message : Form
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

        int wndX = 0;
        int wndY = 0;
        int wndWidth = 0;
        int wndHeight = 0;
        public bool maximized = false;

        void maxiMini()
        {
            if (maximized)
            {
                Location = new Point(wndX, wndY);
                Width = wndWidth;
                Height = wndHeight;
                maximized = false;
            }
            else
            {
                wndX = Location.X;
                wndY = Location.Y;
                wndWidth = Width;
                wndHeight = Height;
                maximized = true;
                Location = new Point(0, 106);
                Width = Parent.Width - 4;
                Height = Parent.Height - 110;
            }
        }

        const int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }

        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

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
        #endregion

        #region public_variables
        string privateLog = "";
        string user = "";
        #endregion

        #region winform_functions
        private void instant_message_Shown(object sender, EventArgs e)
        {
            Text = user + " Instant Message";
            mainTitle.Text = user + " Instant Message";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            // send to server
            chat.irc.SendMessageToChannel(myMessageBox.Text, user);
            // write to file
            string logpath = Application.StartupPath + @"\chatlogs";
            string privateLog = logpath + @"\PM_" + user + ".txt";
            //try
            //{
                File.AppendAllText(privateLog, accForm.tmpUsername + ": " + myMessageBox.Text + '\n');
                sendMsgSound();
            //}
            //catch
            //{
                MessageBox.Show("ERROR: There was an issue writing to log file: " + privateLog);
            //}
            // clear msg box
            myMessageBox.Clear();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            myMessageBox.Clear();
        }
        
        public instant_message(string u)
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
            maxiMini();
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
            maxiMini();
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
                var watch = new FileSystemWatcher();
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
        #endregion
    }
}
