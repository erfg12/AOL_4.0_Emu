using System;
using System.Windows.Forms;
using aol.Classes;

namespace aol.Forms;
public partial class FavoritesAddForm : Win95Theme
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
        MoveWindow(sender, e);
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
            SqliteAccountsClass.addFavorite(internetAddrBox.Text, placeDescBox.Text);
        else
            SqliteAccountsClass.updateFavorite(internetAddrBox.Text, placeDescBox.Text);
        Close();
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void Add_favorite_Shown(object sender, EventArgs e)
    {
        LocationClass.PositionWindow(this);
        placeDescBox.Text = name;
        internetAddrBox.Text = url;
        if (edit)
            internetAddrBox.ReadOnly = true;
    }
}
