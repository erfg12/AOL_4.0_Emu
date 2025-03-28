using System;
using System.Windows.Forms;
using aol.Classes;

namespace aol.Forms;
public partial class KeywordForm : Win95Theme
{
    private void Panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e);
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
}
