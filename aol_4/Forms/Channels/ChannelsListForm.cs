namespace aol.Forms;
public partial class ChannelsListForm : _Win95Theme
{
    private void TitleBar_TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void Channels_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
    }

    private void KidsOnlyBtn_Click(object sender, EventArgs e)
    {
        MainForm.GoToChannel("kids", this, MdiParent);
    }

    private void Channels_Load(object sender, EventArgs e)
    {

    }

    public ChannelsListForm()
    {
        InitializeComponent();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {

    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void ChannelsListForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
