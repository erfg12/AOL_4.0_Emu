using System;
using System.Windows.Forms;
using aol.Services;

namespace aol.Forms;
public partial class KeywordForm : Win95Theme
{
    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

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
    }

    private void KeywordForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
