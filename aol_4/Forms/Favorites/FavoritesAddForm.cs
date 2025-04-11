namespace aol.Forms;
public partial class FavoritesAddForm : _Win95Theme
{
    private void CancelBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    public bool maximized = false;

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    string url = "";
    string name = "";
    bool edit = false;

    public FavoritesAddForm(string url1, string name1, bool edit1 = false)
    {
        InitializeComponent();
        url = url1;
        name = name1;
        edit = edit1;
    }

    private void OkBtn_Click(object sender, EventArgs e)
    {
        if (!edit)
            SqliteAccountsService.AddFavorite(internetAddrBox.Text, placeDescBox.Text);
        else
            SqliteAccountsService.UpdateFavorite(internetAddrBox.Text, placeDescBox.Text);
        Close();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void AddFavorite_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        placeDescBox.Text = name;
        internetAddrBox.Text = url;
        if (edit)
            internetAddrBox.ReadOnly = true;
    }

    private void FavoritesAddForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
