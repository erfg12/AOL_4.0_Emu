using aol.Classes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace aol.Forms;
public partial class BuddyListForm : Win95Theme
{
    int total = 0;

    public BuddyListForm()
    {
        InitializeComponent();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void buddyListView_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        // disable buddies label
        if (e.Index == 0)
            e.NewValue = e.CurrentValue;
    }

    private void setupBtn_Click(object sender, EventArgs e)
    {
        BuddyAddForm ab = new BuddyAddForm();
        ab.Owner = this;
        ab.MdiParent = MdiParent;
        ab.Show();
    }

    public bool CheckIRCRunning()
    {
        int c = 0;
        if (!ChatClass.irc.IsClientRunning())
        {
            Debug.WriteLine("IRC buddy list not connected yet...");
            c++;
            if (c > 50)
            {
                Debug.WriteLine("IRC reconnecting");
                ChatClass.startConnection();
                c = 0;
            }
            Thread.Sleep(5000);
            return false;
        }
        return true;
    }

    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void buddyTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        if (buddyTreeView.SelectedNode.Text == null)
            return;
        if (!ChatClass.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;
        if (ChatClass.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
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
        if (buddyTreeView.SelectedNode == null || buddyTreeView.SelectedNode.Text == null)
            return;
        if (!ChatClass.buddyStatus.ContainsKey(buddyTreeView.SelectedNode.Text))
            return;
        if (ChatClass.buddyStatus[buddyTreeView.SelectedNode.Text] == true) // have to be online to IM
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
        foreach (KeyValuePair<string, bool> entry in ChatClass.buddyStatus)
        {
            tmpList.TryAdd(entry.Key.ToLower(), entry.Value);
        }
        foreach (KeyValuePair<string, bool> entry in tmpList)
        {
            bool MyOut;
            ChatClass.buddyStatus.TryRemove(entry.Key, out MyOut);
        }
    }

    private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {
        //maxiMini();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void buddies_online_Shown(object sender, EventArgs e)
    {
        FormBorderStyle = FormBorderStyle.None;
        DoubleBuffered = true;
        SetStyle(ControlStyles.ResizeRedraw, true);
        StartList(); // get buddy list
        UpdateTimer.Start();

        LocationClass.PositionWindow(this, 1);
        buddyTreeView.Nodes[0].Text = "Online 0/" + total.ToString();
        buddyTreeView.Nodes[1].Text = "Offline 0/" + total.ToString();
    }

    private void StartList()
    {
        foreach (var b in SqliteAccountsClass.getBuddyList())
        {
            if (!ChatClass.buddyStatus.ContainsKey(b.username.ToLower()))
                ChatClass.buddyStatus.TryAdd(b.username.ToLower(), false); // offline by default
        }
    }

    private void buddies_online_Load(object sender, EventArgs e)
    {

    }

    private void UpdateTimer_Tick(object sender, EventArgs e)
    {
        int online = 0;
        int offline = 0;

        if (Account.tmpUsername == "" || Account.tmpUsername == "Guest" || !CheckIRCRunning())
            return;

        foreach (KeyValuePair<string, bool> kvp in ChatClass.buddyStatus.ToList())
        {
            ChatClass.irc.SendRawMessage("whois " + kvp.Key); // send whois command, this will populate the buddyStatus dictionary
          
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
                buddyTreeView.Nodes[0].Text = "Online " + online.ToString() + "/" + total.ToString();
                buddyTreeView.Nodes[1].Text = "Offline " + offline.ToString() + "/" + total.ToString();
            
        }

        total = ChatClass.buddyStatus.Count();

    }
}
