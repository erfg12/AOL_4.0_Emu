using aol.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace aol.Forms;
public partial class ChatroomForm : Win95Theme
{
    string chatlog = "";
    string roomname = "";
    string pChat = "";
    int pplCount = 0;
    FileSystemWatcher watch = null;
    List<Rectangle> rects = new();
    bool formClosing = false;

    public ChatroomForm(string channel)
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
        while (!ChatService.irc.IsClientRunning())
        {
            Debug.WriteLine("not connected yet");
            Thread.Sleep(500); // wait 1/2 sec
            c++;
            if (c > 20)
            {
                ChatService.startConnection();
                Debug.WriteLine("ERROR: Trying connection again.");
                c = 0;
            }
        }
        ChatService.irc.SendRawMessage("join #" + channel);

        keepReading();

        InitializeComponent();
    }

    private void chatroom_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        //chat.users.Clear();
        Text = pChat + " Chatroom";
        mainTitle.Text = pChat + " Chatroom";

        writeFileToBox(true);

        if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();

        //rects.Add(new Rectangle(423, 467, 54, 23)); // 0 send button
        //rects.Add(new Rectangle(532, 265, 39, 50)); // 1 buddy info
        //rects.Add(new Rectangle(574, 265, 39, 50)); // 2 ignore user
    }

    private void writeFileToBox(bool init = false)
    {
        string lastLine = "";
        //try
        //{
        if (chatRoomTextBox.IsHandleCreated)
        {
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
        }
        else
        {
            Debug.WriteLine("[ERROR] handle creation failed?");
        }
        //} catch { Debug.WriteLine("writeFileToBox just crashed."); }
    }

    public void OnChanged(object source, FileSystemEventArgs e)
    {
        if (e.ChangeType == WatcherChangeTypes.Changed)
        {
            Debug.WriteLine($"Changed: {e.FullPath}");
            writeFileToBox();
        }
    }

    private void keepReading()
    {
        watch = new FileSystemWatcher();
        watch.Path = Path.GetDirectoryName(chatlog);
        watch.Filter = Path.GetFileName(chatlog);
        watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
        watch.Changed += new FileSystemEventHandler(OnChanged);
        watch.EnableRaisingEvents = true;
        Debug.WriteLine($"watching {chatlog} for changes");
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        // keep users list up to date
        while (true)
        {
            if (!Account.SignedIn())
                continue;

            if (!IsHandleCreated)
                continue;

            if (!ChatService.irc.IrcClient.IsConnectionEstablished() || !ChatService.irc.IsClientRunning())
            {
                Debug.WriteLine("Client is not connected, breaking BGWorker");
                break;
            }

            if (formClosing)
                break;

            usersListView.Invoke(new MethodInvoker(delegate
            {
                if (!ChatService.irc.IsClientRunning())
                {
                    MessageBox.Show("ERROR: IRC client not connected");
                    return;
                }
                if (!ChatService.users.ContainsKey(roomname))
                {
                    Debug.WriteLine("chat.users key [" + roomname + "] doesn't exist");
                    ChatService.irc.GetUsersInDifferentChannel("#" + roomname);
                    //System.Threading.Thread.Sleep(2000);
                    return;
                }
                // remove offline users
                foreach (ListViewItem item in usersListView.Items)
                {
                    if (!ChatService.users[roomname].Contains(item.Text))
                    {
                        usersListView.Items.Remove(item);
                        pplCount--;
                    }
                }
                // add online users
                List<string> usersList = ChatService.users[roomname]; // gotta declare it, so we can use it
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
        InstantMessageForm im = new InstantMessageForm(usersListView.SelectedItems[0].Text.ToString());
        im.Owner = this;
        im.MdiParent = MdiParent;
        im.Tag = usersListView.SelectedItems[0].Text.ToString();
        im.Show();
    }

    private void chatroom_FormClosing(object sender, FormClosingEventArgs e)
    {
        formClosing = true;
        ChatService.irc.SendRawMessage("part #" + pChat);
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
        if (!ChatService.irc.IsClientRunning())
            MessageBox.Show("ERROR: IRC client is not running");

        if (!ChatService.irc.SendMessageToChannel(messageTextBox.Text, "#" + pChat))
        {
            MessageBox.Show("ERROR: Failed to send message!");
            return;
        }
        // write to file
        string logpath = Application.StartupPath + @"\chatlogs";
        string privateLog = logpath + @"\" + pChat + ".txt";
        File.AppendAllText(privateLog, Account.tmpUsername + ": " + messageTextBox.Text + '\n');
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

    private void ChatroomForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
