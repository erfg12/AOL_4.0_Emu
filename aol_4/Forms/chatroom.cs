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
    public partial class chatroom : Form
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

        const int _ = 2;

        Rectangle Top { get { return new Rectangle(0, 0, this.ClientSize.Width, _); } }
        Rectangle Left { get { return new Rectangle(0, 0, _, this.ClientSize.Height); } }
        Rectangle Bottom { get { return new Rectangle(0, this.ClientSize.Height - _, this.ClientSize.Width, _); } }
        Rectangle Right { get { return new Rectangle(this.ClientSize.Width - _, 0, _, this.ClientSize.Height); } }

        Rectangle TopLeft { get { return new Rectangle(0, 0, _, _); } }

        Rectangle TopRight { get { return new Rectangle(this.ClientSize.Width - _, 0, _, _); } }
        Rectangle BottomLeft { get { return new Rectangle(0, this.ClientSize.Height - _, _, _); } }

        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, Top);
            e.Graphics.FillRectangle(Brushes.Gray, Left);
            e.Graphics.FillRectangle(Brushes.Gray, Right);
            e.Graphics.FillRectangle(Brushes.Gray, Bottom);
        }
        #endregion

        string chatlog = "";
        string roomname = "";
        string pChat = "";
        int pplCount = 0;
        List<Rectangle> rects = new List<Rectangle>();
        bool formClosing = false;

        #region winform_functions
        public chatroom(string channel)
        {
            pChat = channel;
            roomname = channel;
            string logpath = Application.StartupPath + @"\chatlogs";
            chatlog = logpath + @"\" + channel + ".txt";
            
            if (!Directory.Exists(logpath))
                Directory.CreateDirectory(logpath);
            if (!File.Exists(chatlog))
                File.Create(chatlog).Dispose();

            int c = 0;
            while (!chat.irc.IsClientRunning())
            {
                Debug.WriteLine("not connected yet");
                Thread.Sleep(500); // wait 1/2 sec
                c++;
                if (c > 20)
                {
                    chat.startConnection();
                    c = 0;
                }
            }
            chat.irc.SendRawMessage("join #" + channel);

            InitializeComponent();
        }

        private void chatroom_Shown(object sender, EventArgs e)
        {
            //chat.users.Clear();
            Text = pChat + " Chatroom";
            mainTitle.Text = pChat + " Chatroom";
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            rects.Add(new Rectangle(423, 467, 54, 23)); // 0 send button
            rects.Add(new Rectangle(532, 265, 39, 50)); // 1 buddy info
            rects.Add(new Rectangle(574, 265, 39, 50)); // 2 ignore user
        }

        private void writeFileToBox(bool init = false)
        {
            string lastLine = "";
            //try
            //{
                chatRoomTextBox.Invoke(new MethodInvoker(delegate
                {
                    using (FileStream file = new FileStream(chatlog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {
                        using (StreamReader sr = new StreamReader(file))
                        {
                            while (!sr.EndOfStream)
                            {
                                if (init)
                                    chatRoomTextBox.AppendText(sr.ReadLine() + Environment.NewLine);
                                else
                                    lastLine = sr.ReadLine();
                            }
                        }
                    }
                    if (!init)
                        chatRoomTextBox.AppendText(lastLine + Environment.NewLine);
                    chatRoomTextBox.ScrollToCaret();
                }));
            //} catch { Debug.WriteLine("writeFileToBox just crashed."); }
        }

        public void OnChanged(object source, FileSystemEventArgs e)
        {
            writeFileToBox();
        }

        public void keepReading()
        {
            var watch = new FileSystemWatcher();
            watch.Path = Path.GetDirectoryName(chatlog);
            watch.Filter = Path.GetFileName(chatlog);
            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
            watch.Changed += new FileSystemEventHandler(OnChanged);
            watch.EnableRaisingEvents = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            writeFileToBox(true);
            keepReading();

            // keep users list up to date
            while (true)
            {
                if (accForm.tmpUsername == "" || accForm.tmpUsername == "Guest")
                    continue;

                if (!IsHandleCreated)
                    continue;

                if (!chat.irc.IrcClient.IsConnectionEstablished() || !chat.irc.IsClientRunning())
                {
                    Debug.WriteLine("Client is not connected, breaking BGWorker");
                    break;
                }

                if (formClosing)
                    break;

                usersListView.Invoke(new MethodInvoker(delegate
                {
                    if (!chat.irc.IsClientRunning())
                    {
                        MessageBox.Show("ERROR: IRC client not connected");
                        return;
                    }
                    if (!chat.users.ContainsKey(roomname))
                    {
                        Debug.WriteLine("chat.users key [" + roomname + "] doesn't exist");
                        chat.irc.GetUsersInDifferentChannel("#" + roomname);
                        //System.Threading.Thread.Sleep(2000);
                        return;
                    }
                    // remove offline users
                    foreach (ListViewItem item in usersListView.Items)
                    {
                        if (!chat.users[roomname].Contains(item.Text))
                        {
                            usersListView.Items.Remove(item);
                            pplCount--;
                        }
                    }
                    // add online users
                    List<string> usersList = chat.users[roomname]; // gotta declare it, so we can use it
                    for (int i = 0; i < usersList.Count; i++)
                    {
                        if (usersList[i] == "")
                            continue;
                        if (!usersListView.Items.ContainsKey(usersList[i]))
                        {
                            ListViewItem lvi = new ListViewItem();
                            lvi.Text = usersList[i];
                            lvi.Tag = usersList[i];
                            lvi.Name = usersList[i];
                            usersListView.Items.Add(lvi);
                            pplCount++;
                        }
                    }
                }));
                pplQty.Invoke(new MethodInvoker(delegate
                {
                    pplQty.Text = pplCount.ToString();
                }));
                Thread.Sleep(2000);
            }
        }

        private void usersListView_DoubleClick(object sender, EventArgs e)
        {
            instant_message im = new instant_message(usersListView.SelectedItems[0].Text.ToString());
            im.Owner = this;
            im.MdiParent = MdiParent;
            im.Tag = usersListView.SelectedItems[0].Text.ToString();
            im.Show();
        }

        private void chatroom_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosing = true;
            chat.irc.SendRawMessage("part #" + pChat);
        }

        private void messageTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendMsg();
                e.Handled = true;
                e.SuppressKeyPress = true;
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

        private void sendMsg()
        {
            if (!chat.irc.IsClientRunning())
                MessageBox.Show("ERROR: IRC client is not running");

            string RawMsg = "PRIVMSG " + "#" + pChat + " :" + messageTextBox.Text;
            Debug.WriteLine(RawMsg);
            if (!chat.irc.SendRawMessage(RawMsg))
            {
                MessageBox.Show("ERROR: Failed to send message!");
            }
            // write to file
            string logpath = Application.StartupPath + @"\chatlogs";
            string privateLog = logpath + @"\" + pChat + ".txt";
            File.AppendAllText(privateLog, accForm.tmpUsername + ": " + messageTextBox.Text + '\n');
            messageTextBox.Clear();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in rects)
            {
                if (r.Contains(e.Location) && rects.IndexOf(r) == 0) // send message
                {
                    sendMsg();
                }
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Rectangle r in rects)
            {
                if (r.Contains(e.Location))
                {
                    Cursor = Cursors.Hand;
                    return;
                }
            }
            Cursor = Cursors.Default;
        }

        private void ChatSendBtn_Click(object sender, EventArgs e)
        {
            sendMsg();
        }

        private void chatroom_Load(object sender, EventArgs e)
        {

        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
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

        private void maxBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
