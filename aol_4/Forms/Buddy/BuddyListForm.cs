namespace aol.Forms;
public partial class BuddyListForm : _Win95Theme
{
    int total = 0;
    Models.Buddies selectedBuddy;
    TreeNode selectedNode;
    int online = 0;
    int offline = 0;

    public BuddyListForm()
    {
        InitializeComponent();
        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
    }

    private void BuddyListView_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        // disable buddies label
        if (e.Index == 0)
            e.NewValue = e.CurrentValue;
    }

    private void SetupBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<BuddyAddForm>(MdiParent);
    }

    private void BuddyTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (buddyTreeView.SelectedNode.Text == null || !ChatService.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;

        if (ChatService.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
        {
            InstantMessageForm im = new InstantMessageForm(buddyTreeView.SelectedNode.Text);
            im.Owner = this;
            im.MdiParent = MdiParent;
            im.Tag = buddyTreeView.SelectedNode.Text;
            im.Show();
        }
    }

    private void IMBtn_Click(object sender, EventArgs e)
    {
        if (buddyTreeView.SelectedNode == null || buddyTreeView.SelectedNode.Text == null || !ChatService.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;

        if (ChatService.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
        {
            InstantMessageForm im = new InstantMessageForm(buddyTreeView.SelectedNode.Text);
            im.Owner = this;
            im.MdiParent = MdiParent;
            im.Tag = buddyTreeView.SelectedNode.Text;
            im.Show();
        }
    }

    private void Buddies_online_FormClosing(object sender, FormClosingEventArgs e)
    {
        ConcurrentDictionary<string, bool> tmpList = new ConcurrentDictionary<string, bool>();
        foreach (KeyValuePair<string, bool> entry in ChatService.buddyStatus)
        {
            tmpList.TryAdd(entry.Key, entry.Value);
        }
        foreach (KeyValuePair<string, bool> entry in tmpList)
        {
            bool MyOut;
            ChatService.buddyStatus.TryRemove(entry.Key, out MyOut);
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

    private void BuddiesOnline_Shown(object sender, EventArgs e)
    {
        SetStyle(ControlStyles.ResizeRedraw, true);
        StartList(); // get buddy list

        LocationService.PositionWindow(this, 1);
        buddyTreeView.Nodes[0].Text = "Online 0/" + total.ToString();
        buddyTreeView.Nodes[1].Text = "Offline 0/" + total.ToString();
    }

    private void StartList()
    {
        foreach (var b in SqliteAccountsService.GetBuddyList())
        {
            if (!ChatService.buddyStatus.ContainsKey(b.username))
                ChatService.buddyStatus.TryAdd(b.username, false); // offline by default
        }
    }

    private async void UpdateTimer_Tick(object sender, EventArgs e)
    {
        if (!Account.SignedIn() || !MainForm.chat.irc.IsClientRunning())
        {
            Debug.WriteLine($"ERROR - SignedIn:{Account.SignedIn()}, IRCRunning:{MainForm.chat.irc.IsClientRunning()}");
            return;
        }

        foreach (KeyValuePair<string, bool> kvp in ChatService.buddyStatus.ToList())
        {
            if (string.IsNullOrEmpty(kvp.Key))
                continue;

            MainForm.chat.irc.SendRawMessage($"whois {kvp.Key}"); // send whois command, this will populate the buddyStatus dictionary

            if (kvp.Value == true) // remove from offline, add to online
            {
                //Debug.WriteLine("[BUD] " + kvp.Key + " is online");
                TreeNode[] nodes = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                if (nodes.Length > 0)
                {
                    buddyTreeView.Nodes.Remove(nodes[0]);
                    offline--;
                }
                TreeNode[] nodes2 = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                if (nodes2.Length <= 0)
                {
                    TreeNode ntn = new TreeNode();
                    ntn.Text = kvp.Key;
                    ntn.Name = kvp.Key;
                    ntn.Tag = kvp.Key;
                    buddyTreeView.Nodes[0].Nodes.Add(ntn);
                    online++;
                    buddyTreeView.Nodes[0].Expand();
                }
            }
            else
            {
                //Debug.WriteLine("[BUD] " + kvp.Key + " is offline");
                TreeNode[] nodes = buddyTreeView.Nodes[0].Nodes.Find(kvp.Key, true);
                if (nodes.Length > 0)
                {
                    buddyTreeView.Nodes.Remove(nodes[0]);
                    online--;
                }
                TreeNode[] nodes2 = buddyTreeView.Nodes[1].Nodes.Find(kvp.Key, true);
                if (nodes2.Length <= 0)
                {
                    TreeNode ntn = new TreeNode();
                    ntn.Text = kvp.Key;
                    ntn.Name = kvp.Key;
                    ntn.Tag = kvp.Key;
                    buddyTreeView.Nodes[1].Nodes.Add(ntn);
                    offline++;
                    buddyTreeView.Nodes[1].Expand();
                }
            }
            buddyTreeView.Nodes[0].Text = $"Online {online}/{total}";
            buddyTreeView.Nodes[1].Text = $"Offline {offline}/{total}";

        }

        total = ChatService.buddyStatus.Count();

    }

    private void BuddyTreeView_MouseUp(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Right)
        {
            TreeNode node = buddyTreeView.GetNodeAt(e.X, e.Y);
            if (node != null)
            {
                if (node.Text.Contains("Online ") || node.Text.Contains("Offline "))
                    return;

                buddyTreeView.SelectedNode = node;
                buddyContextMenuStrip.Show(buddyTreeView, e.Location);

                var buddyList = SqliteAccountsService.GetBuddyList();
                if (buddyList == null || buddyList.Count() <= 0)
                    return;

                selectedBuddy = buddyList.Where(x => x.buddy_name.Equals(node.Text)).FirstOrDefault();
                if (selectedBuddy != null)
                    selectedNode = node;

                Debug.WriteLine($"Right-clicked buddy {selectedBuddy?.buddy_name} with ID: {selectedBuddy?.id}");
            }
        }
    }

    private async void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (selectedBuddy == null || selectedNode == null)
            return;

        var result = MessageBox.Show($"Are you sure you want to delete buddy {selectedBuddy.buddy_name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            var removeBuddy = SqliteAccountsService.RemoveBuddy(selectedBuddy.id, selectedBuddy.buddy_name);
            if (removeBuddy)
            {
                selectedNode.Remove();
                MessageBox.Show($"Buddy {selectedBuddy.buddy_name} has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedBuddy = null;
                selectedNode = null;
            }
            else
                MessageBox.Show($"Buddy {selectedBuddy.buddy_name} was not removed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
