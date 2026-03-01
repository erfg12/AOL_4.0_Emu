using Microsoft.Extensions.DependencyInjection;

namespace aol.Forms;
public partial class BuddyListForm : _Win95Theme
{
    int total = 0;
    UserAPI.Buddies selectedBuddy;
    TreeNode selectedNode;
    int online = 0;
    int offline = 0;
    public IServiceProvider ServiceProvider { get; }

    private readonly RestAPIService restApi;
    private readonly AccountService account;
    private readonly ChatService chat;
    private readonly SqliteAccountsService sqliteAccountsService;

    public BuddyListForm(RestAPIService ras, ChatService cs, AccountService acc, SqliteAccountsService sql, IServiceProvider serviceProvider)
    {
        InitializeComponent();
        ServiceProvider = serviceProvider;

        restApi = ras;
        account = acc;
        chat = cs;
        sqliteAccountsService = sql;

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
        var addBuddyForm = this.ServiceProvider.GetRequiredService<BuddyAddForm>();
        MDIHelper.OpenForm(addBuddyForm, MdiParent);
    }

    private void BuddyTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (buddyTreeView.SelectedNode.Text == null || !chat.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;

        if (chat.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
        {
            InstantMessageForm im = new InstantMessageForm(chat, account, buddyTreeView.SelectedNode.Text);
            im.Owner = this;
            im.MdiParent = MdiParent;
            im.Tag = buddyTreeView.SelectedNode.Text;
            im.Show();
        }
    }

    private void IMBtn_Click(object sender, EventArgs e)
    {
        if (buddyTreeView.SelectedNode == null || buddyTreeView.SelectedNode.Text == null || !chat.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;

        if (chat.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
        {
            InstantMessageForm im = new InstantMessageForm(chat, account, buddyTreeView.SelectedNode.Text);
            im.Owner = this;
            im.MdiParent = MdiParent;
            im.Tag = buddyTreeView.SelectedNode.Text;
            im.Show();
        }
    }

    private void Buddies_online_FormClosing(object sender, FormClosingEventArgs e)
    {
        ConcurrentDictionary<string, bool> tmpList = new ConcurrentDictionary<string, bool>();
        foreach (KeyValuePair<string, bool> entry in chat.buddyStatus)
        {
            tmpList.TryAdd(entry.Key, entry.Value);
        }
        foreach (KeyValuePair<string, bool> entry in tmpList)
        {
            bool MyOut;
            chat.buddyStatus.TryRemove(entry.Key, out MyOut);
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

    private async void BuddiesOnline_Shown(object sender, EventArgs e)
    {
        SetStyle(ControlStyles.ResizeRedraw, true);
        StartList(); // get buddy list

        LocationService.PositionWindow(this, 1);
        buddyTreeView.Nodes[0].Text = "Online 0/" + total.ToString();
        buddyTreeView.Nodes[1].Text = "Offline 0/" + total.ToString();

        await UpdateBuddyStatus();
    }

    private void StartList()
    {
        foreach (var b in sqliteAccountsService.GetBuddyList())
        {
            if (!chat.buddyStatus.ContainsKey(b.username))
                chat.buddyStatus.TryAdd(b.username, false); // offline by default
        }
    }

    private async void UpdateTimer_Tick(object sender, EventArgs e)
    {
        await UpdateBuddyStatus();
    }

    public async Task UpdateBuddyStatus()
    {
        if (!account.SignedIn())// || !MainForm.chat.irc.IsClientRunning())
        {
            Debug.WriteLine($"ERROR - SignedIn:{account.SignedIn()}, IRCRunning:{chat.irc.IsClientRunning()}");
            return;
        }

        // send heartbeat so users know im online
        // send a /Buddy GET for buddy list including if they're online
        await restApi.SendHeartbeat();
        var buddyList = await restApi.GetBuddyList();

        if (buddyList != null)
            foreach (var buddy in buddyList)
            {
                if (chat.buddyStatus.ContainsKey(buddy.username))
                    chat.buddyStatus[buddy.username] = buddy.online;
            }

        total = chat.buddyStatus.Count();

        foreach (KeyValuePair<string, bool> kvp in chat.buddyStatus.ToList())
        {
            if (string.IsNullOrEmpty(kvp.Key))
                continue;

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

                var buddyList = sqliteAccountsService.GetBuddyList();
                if (buddyList == null || buddyList.Count() <= 0)
                    return;

                selectedBuddy = buddyList.Where(x => x.username.Equals(node.Text)).FirstOrDefault();
                if (selectedBuddy != null)
                    selectedNode = node;

                Debug.WriteLine($"Right-clicked buddy {selectedBuddy?.username} with ID: {selectedBuddy?.id}");
            }
        }
    }

    private async void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (selectedBuddy == null || selectedNode == null)
            return;

        var result = MessageBox.Show($"Are you sure you want to delete buddy {selectedBuddy.username}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            var removeBuddy = await restApi.RemoveBuddy(selectedBuddy.id, selectedBuddy.username);
            if (removeBuddy.Item1)
            {
                selectedNode.Remove();
                MessageBox.Show($"Buddy {selectedBuddy.username} has been removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedBuddy = null;
                selectedNode = null;
            }
            else
                MessageBox.Show($"Buddy {selectedBuddy.username} was not removed! {removeBuddy.Item2}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
