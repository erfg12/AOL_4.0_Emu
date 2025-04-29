namespace aol.Forms;
public partial class ChannelsListForm : _Win95Theme
{

    private void Channels_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
    }

    private void KidsOnlyBtn_Click(object sender, EventArgs e)
    {
        MainForm.GoToChannel("kids", this, MdiParent);
    }

    public ChannelsListForm()
    {
        InitializeComponent();

        TitleLabel.MouseMove += MoveWindow;
        TitleBar.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
