using System.Windows.Forms;

namespace aol.Forms;
public partial class ChatroomForm : _Win95Theme
{
    private readonly string chatlog;
    private readonly string roomname;

    int pplCount = 0;
    FileSystemWatcher watch = null;
    bool formClosing = false;
    private readonly ChatService chat;
    private readonly AccountService account;

    public ChatroomForm(ChatService cs, AccountService acc, string channel)
    {
        InitializeComponent();
        chat = cs;
        account = acc;

        roomname = channel;
        chatlog = ChatHelper.GetChatPath(account.tmpUsername, channel);

        if (!chat.irc.IsClientRunning())
        {
            OpenMsgBox("ERROR", "Chat server not connected!");
            Close();
        }

        chat.irc.SendRawMessage("join #" + channel);

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

        try
        {
            using FileStream file = new FileStream(chatlog, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            using StreamReader sr = new StreamReader(file);

            while (!sr.EndOfStream)
            {
                if (init)
                {
                    try
                    {
                        var msg = sr.ReadLine() + Environment.NewLine;
                        if (msg.Contains(":"))
                        {
                            // color the usernames
                            string[] parts = msg.Split(new char[] { ':' }, 2);
                            string name = parts[0];
                            string message = parts.Length > 1 ? parts[1].Trim() : "";
                            AppendMessage(chatRoomTextBox, name, name.Equals(account.tmpUsername) ? Color.Blue : Color.Red, message);
                        }
                        else // not a user message
                            chatRoomTextBox.AppendText(msg);
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
                    var msg = lastLine + Environment.NewLine;
                    if (msg.Contains(":"))
                    {
                        // color the usernames
                        string[] parts = msg.Split(new char[] { ':' }, 2);
                        string name = parts[0];
                        string message = parts.Length > 1 ? parts[1].Trim() : "";
                        chatRoomTextBox.Invoke(new MethodInvoker(delegate
                        {
                            AppendMessage(chatRoomTextBox, name, name.Equals(account.tmpUsername) ? Color.Blue : Color.Red, message);
                        }));
                    }
                    else // not a user message
                        chatRoomTextBox.Invoke(new MethodInvoker(delegate
                        {
                            chatRoomTextBox.AppendText(msg);
                        }));
                }
                catch
                {
                    Debug.WriteLine("ERROR: writeFileToBox function crashed at AppendText[2].");
                }
            }
            chatRoomTextBox.Invoke(new MethodInvoker(delegate
            {
                chatRoomTextBox.ScrollToCaret();
            }));
        }
        catch {
            Debug.WriteLine("ERROR: Msgbox wasn't ready. I prevented a crash.");
        }
    }

    void AppendMessage(RichTextBox box, string name, Color nameColor, string message)
    {
        int start = box.TextLength;
        box.SelectionColor = nameColor;
        box.SelectionFont = new Font(box.Font, FontStyle.Bold);
        box.AppendText(name + ":");
        box.SelectionColor = Color.Black;
        box.SelectionFont = new Font(box.Font, FontStyle.Regular);

        // Check if message contains emojis
        bool hasEmoji = ChatHelper.emojis.Keys.Any(key => message.Contains(key));

        if (hasEmoji)
        {
            chat.ReplaceEmojisWithImage(box, message);
        }
        else
        {
            box.AppendText(" " + message);
        }

        box.AppendText("\n");
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
        InstantMessageForm im = new InstantMessageForm(chat, account, usersListView.SelectedItems[0].Text.ToString());
        im.Owner = this;
        im.MdiParent = MdiParent;
        im.Tag = usersListView.SelectedItems[0].Text.ToString();
        im.Show();
    }

    private void Chatroom_FormClosing(object sender, FormClosingEventArgs e)
    {
        formClosing = true;
        chat.irc.SendRawMessage($"PART #{roomname} :bye everyone");

        watch.EnableRaisingEvents = false;
        watch.Changed -= OnChanged;
        watch.Dispose();

        chatRoomTextBox?.Dispose();
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
        if (!chat.irc.IsClientRunning())
            MessageBox.Show("ERROR: IRC client is not running");

        if (!chat.irc.SendMessageToChannel(messageTextBox.Text, "#" + roomname))
        {
            MessageBox.Show("ERROR: Failed to send message!");
            return;
        }
        // write to file
        string privateLog = ChatHelper.GetChatPath(account.tmpUsername, roomname);
        File.AppendAllText(privateLog, account.tmpUsername + ": " + messageTextBox.Text + '\n');
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
        if (!IsHandleCreated || !account.SignedIn())
            return;

        if (!chat.irc.IrcClient.IsConnectionEstablished() || !chat.irc.IsClientRunning())
        {
            Debug.WriteLine("Client is not connected.");
            return;
        }

        if (!chat.users.ContainsKey(roomname))
        {
            Debug.WriteLine("chat.users key [" + roomname + "] doesn't exist");
            chat.irc.GetUsersInDifferentChannel("#" + roomname);
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
        pplQty.Text = pplCount.ToString();
    }
}
