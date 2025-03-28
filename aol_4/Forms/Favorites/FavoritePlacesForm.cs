using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using aol.Classes;

namespace aol.Forms;
public partial class FavoritePlacesForm : Win95Theme
{
    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void FpTreeView_DoubleClick(object sender, EventArgs e)
    {
        goToURL();
    }

    private void GoBtn_Click(object sender, EventArgs e)
    {
        goToURL();
    }

    private void goToURL()
    {
        if (fpTreeView.SelectedNode == null)
            return;
        if (fpTreeView.SelectedNode.Text == null)
            return;
        if (fpTreeView.SelectedNode.Tag == null)
            return;

        Form BrowseWnd = new BrowserForm(fpTreeView.SelectedNode.Tag.ToString());
        BrowseWnd.Owner = (Form)MdiParent;
        BrowseWnd.MdiParent = MdiParent;
        BrowseWnd.Show();
    }

    private void NewBtn_Click(object sender, EventArgs e)
    {
        FavoritesAddForm af = new FavoritesAddForm("", "");
        af.Owner = this;
        af.MdiParent = MdiParent;
        af.Show();
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        if (fpTreeView.SelectedNode == null)
            return;
        if (fpTreeView.SelectedNode.Text == null)
            return;
        if (fpTreeView.SelectedNode.Tag == null)
            return;

        SqliteAccountsClass.deleteFavorite(fpTreeView.SelectedNode.Tag.ToString());
        fpTreeView.SelectedNode.Remove();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        if (fpTreeView.SelectedNode == null)
            return;
        if (fpTreeView.SelectedNode.Text == null)
            return;
        if (fpTreeView.SelectedNode.Tag == null)
            return;

        FavoritesAddForm af = new FavoritesAddForm(fpTreeView.SelectedNode.Tag.ToString(), fpTreeView.SelectedNode.Text, true);
        af.Owner = this;
        af.MdiParent = MdiParent;
        af.Show();
    }

    private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        while (true)
        {
            // check for new favorite items
            foreach (KeyValuePair<string, string> t in await SqliteAccountsClass.getFavoritesList())
            {
                if (!fpTreeView.Nodes[0].Nodes.ContainsKey(t.Key))
                    reloadFavorites();
            }
            Thread.Sleep(1000);
        }
    }

    private void reloadFavorites()
    {
        fpTreeView.Invoke(new MethodInvoker(async () =>
        {
            fpTreeView.Nodes[0].Nodes.Clear();

            foreach (KeyValuePair<string, string> t in await SqliteAccountsClass.getFavoritesList())
            {
                TreeNode ntn = new TreeNode();
                ntn.Text = t.Value;
                ntn.Name = t.Key;
                ntn.Tag = t.Key;
                fpTreeView.Nodes[0].Nodes.Add(ntn);
                fpTreeView.Nodes[0].Expand();
            }
        }));
    }

    private void Favorite_places_Shown(object sender, EventArgs e)
    {
        reloadFavorites();
        if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
    }

    public FavoritePlacesForm()
    {
        InitializeComponent();
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }
}
