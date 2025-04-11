namespace aol.Forms;
public partial class MsgBoxForm : _Win95Theme
{
    public MsgBoxForm(string title, string msg)
    {
        InitializeComponent();

        titleLabel.Text = title;
        this.Text = title;
        richTextBox.Text = msg;
    }

    private void MsgBoxForm_LocationChanged(object sender, System.EventArgs e)
    {
        OnLocationChanged(sender, e);
    }

    private void MiniBtn_Click(object sender, System.EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void TitleBar_TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void OkBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void MaxBtn_Click(object sender, System.EventArgs e)
    {
        MaxiMini(maxBtn);
    }
}
