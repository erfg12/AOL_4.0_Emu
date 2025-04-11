namespace aol.Forms;
public partial class BrowserForm : _Win95Theme
{
    public bool loading = true;
    public string url { get; set; }
    public string title { get; set; }

    public void GoToUrl(string url)
    {
        url = BrowserHelper.GenerateURLFromString(url);
        Uri outUri;
        if (Uri.TryCreate(url, UriKind.Absolute, out outUri) && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
            WebView.Source = new Uri(url);
        UpdateAddrBox();
    }

    public BrowserForm(string urlArg = "")
    {
        InitializeComponent();
        InitializeAsync();

        this.FormBorderStyle = FormBorderStyle.None;
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);

        GoToUrl(urlArg);
    }

    async void InitializeAsync()
    {
        try
        {
            await WebView.EnsureCoreWebView2Async();
            WebView.CoreWebView2.SourceChanged += UpdateAddressBar;
            WebView.CoreWebView2.DocumentTitleChanged += DocumentTitleChanged;
            WebView.CoreWebView2.NavigationCompleted += NavigationCompleted;
            WebView.CoreWebView2.NavigationStarting += NavigationStarting;
        }
        catch (Exception ex)
        {
            OpenMsgBox("ERROR", "Error initializing WebView2! Is the WebView2 runtime installed? Download and install it at http://tiny.cc/lk6g001");
            Debug.WriteLine(ex.ToString());
        }
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    void UpdateAddressBar(object sender, CoreWebView2SourceChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(WebView.Source.ToString()))
            return;

        url = WebView.Source.ToString();
        UpdateAddrBox();
    }

    public void UpdateAddrBox()
    {
        if (MdiParent == null || string.IsNullOrEmpty(url))
            return;

        var mainForm = (MainForm)MdiParent;
        mainForm.addrBox.Text = url;
    }

    private void DocumentTitleChanged(object sender, object e)
    {
        this.Text = WebView.CoreWebView2.DocumentTitle;
        BrowserWindowTitleLabel.Text = WebView.CoreWebView2.DocumentTitle;
    }

    private void NavigationCompleted(object sender, object e)
    {
        loading = false;
    }

    private void NavigationStarting(object sender, object e)
    {
        loading = true;
    }

    private void FavoriteBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm(() => new FavoritesAddForm(url, title), MdiParent);
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MaxBtn_Click(object sender, EventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void BrowserForm_Shown(object sender, EventArgs e)
    {
        LocationService.PositionWindow(this, 2);
        ToolTip toolTip1 = new ToolTip();
        toolTip1.SetToolTip(this.closeBtn, "Close Window");
        toolTip1.SetToolTip(this.maxBtn, "Maximize Window");
        toolTip1.SetToolTip(this.miniBtn, "Minimize Window");
    }

    private void TitleBar_TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void TitleBar_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        MaxiMini(maxBtn);
    }

    private void BrowserForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }

    private void BrowserForm_Enter(object sender, EventArgs e)
    {
        UpdateAddrBox();
    }
}
