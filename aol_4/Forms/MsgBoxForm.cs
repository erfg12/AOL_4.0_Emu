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

    private void miniBtn_Click(object sender, System.EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void closeBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void okBtn_Click(object sender, System.EventArgs e)
    {
        Close();
    }

    private void maxBtn_Click(object sender, System.EventArgs e)
    {
        maxiMini(maxBtn);
    }
}
