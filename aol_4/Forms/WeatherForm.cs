namespace aol.Forms;
public partial class WeatherForm : _Win95Theme
{
    private void MiniBtn_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void Weather_Shown(object sender, EventArgs e)
    {
        List<string> tmpCityState = new List<string>();
        tmpCityState = LocationService.GetCityState();
        cityStateLabel.Text = tmpCityState[0] + ", " + tmpCityState[1];
        //location.getForecastWeather(); // test
    }

    public WeatherForm()
    {
        InitializeComponent();

        this.LocationChanged += OnLocationChanged;
        TitleBar.MouseMove += MoveWindow;
        titleLabel.MouseMove += MoveWindow;
    }

    private void Weather_Load(object sender, EventArgs e)
    {

    }
}
