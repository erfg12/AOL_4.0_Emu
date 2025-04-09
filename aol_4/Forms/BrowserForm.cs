namespace aol.Forms;
public partial class BrowserForm : _Win95Theme
{
    public bool loading = false;
    public string url { get; set; }
    public string title { get; set; }

    public void goToUrl(string url)
    {
        url = BrowserHelper.GenerateURLFromString(url);
        Uri outUri;
        if (Uri.TryCreate(url, UriKind.Absolute, out outUri) && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
            WebView.Source = new Uri(url);
    }

    public BrowserForm(string urlArg = "")
    {
        InitializeComponent();
        InitializeAsync();

        this.FormBorderStyle = FormBorderStyle.None;
        this.DoubleBuffered = true;
        this.SetStyle(ControlStyles.ResizeRedraw, true);

        goToUrl(urlArg);
    }

    private void BrowserForm_Load(object sender, EventArgs e)
    {

    }

    async void InitializeAsync()
    {
        await WebView.EnsureCoreWebView2Async(null);
        WebView.CoreWebView2.WebMessageReceived += UpdateAddressBar;
        WebView.CoreWebView2.DocumentTitleChanged += DocumentTitleChanged;
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs e)
    {
        url = e.TryGetWebMessageAsString();
    }

    private void DocumentTitleChanged(object sender, object e)
    {
        this.Text = WebView.CoreWebView2.DocumentTitle;
        BrowserWindowTitleLabel.Text = WebView.CoreWebView2.DocumentTitle;
    }

    private void FavoriteBtn_Click(object sender, EventArgs e)
    {
        MDIHelper.OpenForm(() => new FavoritesAddForm(url, title), MdiParent);
    }

    private void WebView_VisibleChanged(object sender, EventArgs e)
    {

    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void maxBtn_Click(object sender, EventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void miniBtn_Click(object sender, EventArgs e)
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

    private void titleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        maxiMini(maxBtn);
    }

    private void BrowserForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
