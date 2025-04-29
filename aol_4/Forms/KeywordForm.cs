namespace aol.Forms;
public partial class KeywordForm : _Win95Theme
{
    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    public KeywordForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
    }
}
