using System;
using System.Windows.Forms;
using aol.Services;

namespace aol.Forms;
public partial class PicturesForm : Win95Theme
{
    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }

    private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
    }


    public PicturesForm()
    {
        InitializeComponent();
    }

    private void Pictures_Load(object sender, EventArgs e)
    {

    }
}
