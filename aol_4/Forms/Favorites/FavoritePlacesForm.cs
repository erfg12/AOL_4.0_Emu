namespace aol.Forms;
public partial class FavoritePlacesForm : _Win95Theme
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
        MaxiMini(maxBtn);
    }

    private void FpTreeView_DoubleClick(object sender, EventArgs e)
    {
        GoToURL();
    }

    private void GoBtn_Click(object sender, EventArgs e)
    {
        GoToURL();
    }

    private void GoToURL()
    {
        if (fpTreeView.SelectedNode == null || fpTreeView.SelectedNode.Text == null || fpTreeView.SelectedNode.Tag == null)
            return;

        MDIHelper.OpenForm(() => new BrowserForm(fpTreeView.SelectedNode.Tag.ToString()), MdiParent);
    }

    private void NewBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm(() => new FavoritesAddForm("",""), MdiParent);
    }

    private void DeleteBtn_Click(object sender, EventArgs e)
    {
        if (fpTreeView.SelectedNode == null || fpTreeView.SelectedNode.Text == null || fpTreeView.SelectedNode.Tag == null)
            return;

        SqliteAccountsService.DeleteFavorite(fpTreeView.SelectedNode.Tag.ToString());
        fpTreeView.SelectedNode.Remove();
    }

    private void EditBtn_Click(object sender, EventArgs e)
    {
        if (fpTreeView.SelectedNode == null || fpTreeView.SelectedNode.Text == null || fpTreeView.SelectedNode.Tag == null)
            return;

        MDIHelper.OpenForm(() => new FavoritesAddForm(fpTreeView.SelectedNode.Tag.ToString(), fpTreeView.SelectedNode.Text, true), MdiParent);
    }

    private async void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
        while (true)
        {
            // check for new favorite items
            foreach (KeyValuePair<string, string> t in await SqliteAccountsService.GetFavoritesList())
            {
                if (!fpTreeView.Nodes[0].Nodes.ContainsKey(t.Key))
                    ReloadFavorites();
            }
            Thread.Sleep(1000);
        }
    }

    private void ReloadFavorites()
    {
        fpTreeView.Invoke(new MethodInvoker(async () =>
        {
            fpTreeView.Nodes[0].Nodes.Clear();

            foreach (KeyValuePair<string, string> t in await SqliteAccountsService.GetFavoritesList())
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
        ReloadFavorites();
        if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
    }

    public FavoritePlacesForm()
    {
        InitializeComponent();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void FavoritePlacesForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
