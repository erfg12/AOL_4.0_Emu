namespace aol.Forms;
public partial class PreferencesForm : _Win95Theme
{
    private void MiniBtn_Click(object sender, EventArgs e)
    {
        this.WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void GeneralBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm<SettingsForm>(MdiParent);
    }

    public PreferencesForm()
    {
        InitializeComponent();

        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
        this.LocationChanged += OnLocationChanged;
    }
}
