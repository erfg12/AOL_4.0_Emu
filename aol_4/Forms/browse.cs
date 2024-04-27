using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using aol.Classes;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace aol.Forms
{
    public partial class Browse : Win95Theme
    {

        #region public_variables
        public bool loading = false;
        //public ChromiumWebBrowser browser;
        public WebView2 wv2 = null;
        public string url = "";
        public string title = "";
        #endregion

        #region my_functions
        public void InitBrowser(string urlArg)
        {
            //var settings = new CefSettings();
            //settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
            //if (!Cef.IsInitialized) Cef.Initialize(settings);
            
            /*browser = new ChromiumWebBrowser(url);
            browser.Dock = DockStyle.Fill;
            browser.AddressChanged += Browser_AddressChanged;
            toolStripContainer1.ContentPanel.Controls.Add(browser);
            browser.DownloadHandler = new DownloadHandler();
            browser.TitleChanged += Browser_TitleChanged;
            //browser.RenderProcessMessageHandler = new RenderProcessMessageHandler();

            //Wait for the page to finish loading (all resources will have been loaded, rendering is likely still happening)
            browser.LoadingStateChanged += (sender, args) =>
            {
                //Wait for the Page to finish loading
                loading = args.IsLoading;
            };*/
        }

        public string searchProvider(string query)
        {
            if (Properties.Settings.Default.searchProvider == "Dogpile")
            {
                return "https://www.dogpile.com/serp?q=" + query;
            }
            else if (Properties.Settings.Default.searchProvider == "Bing")
            {
                return "https://www.bing.com/search?q=" + query;
            }
            else if (Properties.Settings.Default.searchProvider == "Google")
            {
                return "https://www.google.com/search?q=" + query;
            }
            else if (Properties.Settings.Default.searchProvider == "Yahoo")
            {
                return "https://search.yahoo.com/search?p=" + query;
            }
            return "";
        }

        public string GenerateURLFromString(string urlArg)
        {
            if (urlArg == "") url = "https://www.google.com";
            if (!urlArg.Contains("."))
                url = searchProvider(urlArg);
            else
                url = urlArg.StartsWith("https://") ? urlArg : urlArg = "https://" + urlArg;

            Uri outUri;
            if (Uri.TryCreate(url, UriKind.Absolute, out outUri) && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
            {
                WebView.Source = new Uri(url);
            }
            else
            {
                MessageBox.Show($"Invalid URL: {url}");
                url = "https://www.google.com";
            }

            return url;
        }

        public void goToUrl(string url)
        {
            WebView.Source = new Uri(GenerateURLFromString(url));
        }

        public Browse(string urlArg = "")
        {
            InitializeComponent();
            InitializeAsync();

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            wv2 = WebView;
            WebView.Source = new Uri(GenerateURLFromString(urlArg));
        }
        #endregion

        #region winform_functions
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        async void InitializeAsync()
        {
            await WebView.EnsureCoreWebView2Async(null);
            WebView.CoreWebView2.WebMessageReceived += UpdateAddressBar;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /*private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            title = e.Title;
            titleLabel.Invoke(new MethodInvoker(delegate
            {
                titleLabel.Text = title;
                Text = title;
            }));
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            url = e.Address;
        }*/

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            url = e.TryGetWebMessageAsString();
        }

        private void FavoriteBtn_Click(object sender, EventArgs e)
        {
            add_favorite af = new add_favorite(url, title);
            af.Owner = this;
            af.MdiParent = MdiParent;
            af.Show();
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

        private void Form1_Shown(object sender, EventArgs e)
        {
            location.PositionWindow(this, 2);
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
        #endregion
    }
}
