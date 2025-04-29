namespace aol.Forms;
public partial class ChannelViewForm : _Win95Theme
{
    public ChannelViewForm(string url = "", string title = "")
    {
        InitializeComponent();
        this.Text = title;
        labelTitle.Text = title;
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        WebView.Source = new Uri(url);

        TitlePanel.DoubleClick += MaxRestoreButton_Click;
        labelTitle.DoubleClick += MaxRestoreButton_Click;
        TitlePanel.MouseMove += MoveWindow;
        labelTitle.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
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
}
