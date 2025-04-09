namespace aol.Forms;
public partial class WeatherForm : _Win95Theme
{
    private void MiniBtn_Click_1(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void CloseBtn_Click_1(object sender, EventArgs e)
    {
        Close();
    }

    private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }

    private void Weather_Shown(object sender, EventArgs e)
    {
        List<string> tmpCityState = new List<string>();
        tmpCityState = LocationService.getCityState();
        cityStateLabel.Text = tmpCityState[0] + ", " + tmpCityState[1];
        //location.getForecastWeather(); // test
    }

    private void Panel1_MouseMove_1(object sender, MouseEventArgs e)
    {
        MoveWindow(sender, e, maxBtn);
    }


    public WeatherForm()
    {
        InitializeComponent();
    }

    private void Weather_Load(object sender, EventArgs e)
    {

    }

    private void WeatherForm_LocationChanged(object sender, EventArgs e)
    {
        OnLocationChanged(sender, e);
    }
}
