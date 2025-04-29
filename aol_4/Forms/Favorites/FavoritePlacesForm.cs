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

    private async Task ReloadFavorites()
    {
        if (!IsHandleCreated)
            return;

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
    }

    private async void Favorite_places_Shown(object sender, EventArgs e)
    {
        await ReloadFavorites();
    }

    public FavoritePlacesForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        TitleBar.DoubleClick += TitleBar_DoubleClick;
        titleLabel.MouseMove += MoveWindow;
        titleLabel.DoubleClick += TitleBar_DoubleClick;
        this.LocationChanged += OnLocationChanged;
        maxBtn.Click += MaxRestoreButton_Click;
    }
}
