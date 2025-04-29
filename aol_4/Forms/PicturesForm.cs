namespace aol.Forms;
public partial class PicturesForm : _Win95Theme
{
    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    public PicturesForm()
    {
        InitializeComponent();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
    }

    private void Pictures_Load(object sender, EventArgs e)
    {

    }
}
