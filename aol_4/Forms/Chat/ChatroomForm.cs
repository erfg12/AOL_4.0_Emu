﻿namespace aol.Forms;
public partial class ChatroomForm : _Win95Theme
{
    private readonly string chatlog;
    private readonly string roomname;

    int pplCount = 0;
    FileSystemWatcher watch = null;
    bool formClosing = false;

    public ChatroomForm(string channel)
    {
        InitializeComponent();

        roomname = channel;
        var chatLogDir = $"{Application.StartupPath}\\chatlogs";
        chatlog = $"{chatLogDir}\\{channel}.txt";

        if (!Directory.Exists(chatLogDir))
            Directory.CreateDirectory(chatLogDir);
        if (!File.Exists(chatlog))
            File.Create(chatlog).Dispose();

        if (!MainForm.chat.irc.IsClientRunning())
        {
            OpenMsgBox("ERROR", "Chat server not connected!");
            Close();
        }

        MainForm.chat.irc.SendRawMessage("join #" + channel);

        KeepReading();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        //TitleBar.DoubleClick += TitleBar_DoubleClick;
        mainTitle.MouseMove += MoveWindow;
        //mainTitle.DoubleClick += TitleBar_DoubleClick;
        //maxBtn.Click += MaxRestoreButton_Click;
    }

    private void Chatroom_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        //chat.users.Clear();
        Text = roomname + " Chatroom";
        mainTitle.Text = roomname + " Chatroom";

        WriteFileToBox(true);
    }

    private void WriteFileToBox(bool init = false)
    {
        string lastLine = "";

        using FileStream file = new FileStream(chatlog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using StreamReader sr = new StreamReader(file);

        try
        {
            while (!sr.EndOfStream)
            {
                if (init)
                {
                    chatRoomTextBox.Invoke(new MethodInvoker(delegate
                    {
                        chatRoomTextBox.AppendText(sr.ReadLine() + Environment.NewLine);
                    }));
                }
                else
                    lastLine = sr.ReadLine();
            }

            if (!init)
            {
                chatRoomTextBox.Invoke(new MethodInvoker(delegate
                {
                    chatRoomTextBox.AppendText(lastLine + Environment.NewLine);
                }));
            }
            chatRoomTextBox.Invoke(new MethodInvoker(delegate
            {
                chatRoomTextBox.ScrollToCaret();
            }));
        }
        catch { }
    }

    public void OnChanged(object source, FileSystemEventArgs e)
    {
        if (e.ChangeType == WatcherChangeTypes.Changed)
        {
            Debug.WriteLine($"Changed: {e.FullPath}");
            WriteFileToBox();
        }
    }

    private void KeepReading()
    {
        watch = new FileSystemWatcher();
        watch.Path = Path.GetDirectoryName(chatlog);
        watch.Filter = Path.GetFileName(chatlog);
        watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite;
        watch.Changed += new FileSystemEventHandler(OnChanged);
        watch.EnableRaisingEvents = true;
        Debug.WriteLine($"watching {chatlog} for changes");
    }

    private void UsersListView_DoubleClick(object sender, EventArgs e)
    {
        InstantMessageForm im = new InstantMessageForm(usersListView.SelectedItems[0].Text.ToString());
        im.Owner = this;
        im.MdiParent = MdiParent;
        im.Tag = usersListView.SelectedItems[0].Text.ToString();
        im.Show();
    }

    private void Chatroom_FormClosing(object sender, FormClosingEventArgs e)
    {
        formClosing = true;
        MainForm.chat.irc.SendRawMessage("part #" + roomname);
    }

    private void MessageTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            SendMsg();
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private void SendMsg()
    {
        if (!MainForm.chat.irc.IsClientRunning())
            MessageBox.Show("ERROR: IRC client is not running");

        if (!MainForm.chat.irc.SendMessageToChannel(messageTextBox.Text, "#" + roomname))
        {
            MessageBox.Show("ERROR: Failed to send message!");
            return;
        }
        // write to file
        string logpath = Application.StartupPath + @"\chatlogs";
        string privateLog = logpath + @"\" + roomname + ".txt";
        File.AppendAllText(privateLog, Account.tmpUsername + ": " + messageTextBox.Text + '\n');
        messageTextBox.Clear();
    }

    private void ChatSendBtn_Click(object sender, EventArgs e)
    {
        SendMsg();
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
    /// Update users list per second. To-Do: think about changing this to an event driven system
    /// </summary>
    private void UpdateUsersTimer_Tick(object sender, EventArgs e)
    {
        if (!IsHandleCreated || !Account.SignedIn())
            return;

        if (!MainForm.chat.irc.IrcClient.IsConnectionEstablished() || !MainForm.chat.irc.IsClientRunning())
        {
            Debug.WriteLine("Client is not connected.");
            return;
        }

        if (!MainForm.chat.users.ContainsKey(roomname))
        {
            Debug.WriteLine("chat.users key [" + roomname + "] doesn't exist");
            MainForm.chat.irc.GetUsersInDifferentChannel("#" + roomname);
            return;
        }

        // remove offline users
        foreach (ListViewItem item in usersListView.Items)
        {
            if (!MainForm.chat.users[roomname].Contains(item.Text))
            {
                usersListView.Items.Remove(item);
                pplCount--;
            }
        }

        // add online users
        List<string> usersList = MainForm.chat.users[roomname]; // gotta declare it, so we can use it
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
        pplQty.Text = pplCount.ToString();
    }
}
