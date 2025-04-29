namespace aol.Forms;
public partial class MsgBoxForm : _Win95Theme
{
    public MsgBoxForm(string title, string msg)
    {
        InitializeComponent();

        titleLabel.Text = title;
        this.Text = title;
        richTextBox.Text = msg;

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
    }

    private void CloseBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void OkBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }
}
