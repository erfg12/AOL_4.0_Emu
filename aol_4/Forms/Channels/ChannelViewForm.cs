using System;
using System.Windows.Forms;
using aol.Classes;

namespace aol.Forms;
public partial class ChannelViewForm : Win95Theme
{
    public bool loading = false;
    public string url = "";
    public string title = "";

    public ChannelViewForm(string url = "", string title = "")
    {
        InitializeComponent();
        this.Text = title;
        labelTitle.Text = title;
        this.FormBorderStyle = FormBorderStyle.None;
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        WebView.Source = new Uri(url);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void FavoriteBtn_Click(object sender, EventArgs e)
    {
        FavoritesAddForm af = new FavoritesAddForm(url, title);
        af.Owner = this;
        af.MdiParent = MdiParent;
        af.Show();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        LocationClass.PositionWindow(this);
        ToolTip toolTip1 = new ToolTip();
        toolTip1.SetToolTip(this.closeBtn, "Close Window");
        toolTip1.SetToolTip(this.maxBtn, "Maximize Window");
        toolTip1.SetToolTip(this.miniBtn, "Minimize Window");
    }

    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        maxiMini(maxBtn);
    }
}
