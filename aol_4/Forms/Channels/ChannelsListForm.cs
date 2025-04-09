namespace aol.Forms;
public partial class ChannelsListForm : _Win95Theme
{
    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void channels_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this);
    }

    private void KidsOnlyBtn_Click(object sender, EventArgs e)
    {
        MainForm.goToChannel("kids", this, MdiParent);
    }

    private void channels_Load(object sender, EventArgs e)
    {

    }

    public ChannelsListForm()
    {
        InitializeComponent();
    }

    private void miniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void ChannelsListForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
