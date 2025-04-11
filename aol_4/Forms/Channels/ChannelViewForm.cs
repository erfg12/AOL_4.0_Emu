namespace aol.Forms;
public partial class ChannelViewForm : _Win95Theme
{
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

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void ChannelView_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
        ToolTip toolTip1 = new ToolTip();
        toolTip1.SetToolTip(this.closeBtn, "Close Window");
        toolTip1.SetToolTip(this.maxBtn, "Maximize Window");
        toolTip1.SetToolTip(this.miniBtn, "Minimize Window");
    }

    private void TitleBar_TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void ChannelViewForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
