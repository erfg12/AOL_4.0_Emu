namespace aol.Services;
public class wData
{
    public string ip;
    public string type;
    public string continent_code;
    public string continent_name;
    public string country_code;
    public string country_name;
    public string region_code;
    public string region_name;
    public string city;
    public string zip;
    public string latitude;
    public string longitude;
    public ConcurrentBag<loc> location;
    public string country_flag;
    public string country_flag_emoji;
    public string country_flag_emoji_unicode;
    public string calling_code;
    public string is_eu;
}

public class loc
{
    public string geoname_id;
    public string capital;
    public ConcurrentBag<langs> languages;
}

public class langs
{
    public string code;
    public string name;
    public string native;
}

class LocationService
{
    public static WeatherNet.Util.Api.ApiClient wn = new WeatherNet.Util.Api.ApiClient();
    public static string GetIP()
    {
        string ip = "";
        using (WebClient wc = new WebClient())
        {
            try
            {
                ip = wc.DownloadString("https://ipv4.icanhazip.com/");
            }
            catch
            {
                Console.WriteLine("Error retrieving ip from ipv4.icanhazip.com");
            }
        }
        if (ip.Equals(""))
            Console.WriteLine("WARNING: There was a problem getting the client's IP! Setting some defaults.");
        return ip;
    }

    public static List<string> GetCityState()
    {
        List<string> tmpList = new List<string>();
        string MyIP = GetIP();

        // defaults
        tmpList.Add("New York City");
        tmpList.Add("New York");
        tmpList.Add("10001");

        if (MyIP.Equals(""))
            return tmpList;

        /*Task<string> json;
        string AccessKey = "7d7a9198de3b50a37caf5115c63fb4ec";
        string apiURL = "http://api.ipstack.com/" + MyIP + "?access_key=" + AccessKey + "&format=1";

        using (HttpClient wc = new HttpClient())
        {
            try
            {
                json = wc.GetStringAsync(apiURL);
            } 
            catch
            {
                Console.WriteLine("Error retrieving city, region_name and zip from api.ipstack.com");
                return tmpList;
            }
        }

        JToken token = JObject.Parse(json.Content.ReadAsStringAsync());

        tmpList.Clear(); // clear defaults
        tmpList.Add((string)token.SelectToken("city"));
        tmpList.Add((string)token.SelectToken("region_name"));
        tmpList.Add((string)token.SelectToken("zip"));*/

        return tmpList;
    }

    public static string GetCurrentWeather()
    {
        //List<string> cityDat = getCityState();

        var result = WeatherNet.Current.GetByCityName(Properties.Settings.Default.city, Properties.Settings.Default.country, "en", "imperial");

        string t = "";
        double t2 = 0.0;

        if (result.Item != null)
        {
            t = result.Item.Title;
            t2 = Math.Round(result.Item.Temp);
        }
        
        return t + " " + t2.ToString();
    }

    /// <summary>
    /// Must be called after form is shown
    /// </summary>
    /// <param name="f">the form to center</param>
    /// <param name="position">0 = center, 1 = right, 2 = bottom</param>
    public static void PositionWindow(Form f, int position = 0, int topPadding = 0)
    {
        int topBarHeight = 115;
        Form ParentForm = f.MdiParent;
        if (ParentForm != null)
        {
            switch (position)
            {
                case 0:
                    f.Location = new Point((ParentForm.Width / 2) - (f.Width / 2), (ParentForm.Height / 2) - (f.Height / 2) + topPadding - topBarHeight);
                    break;
                case 1:
                    f.Location = new Point((ParentForm.Width) - (f.Width + 10), (ParentForm.Height / 2) - (f.Height / 2) + topPadding - topBarHeight);
                    break;
                case 2:
                    f.Location = new Point((ParentForm.Width / 2) - (f.Width / 2), (ParentForm.Height) - (f.Height + 10) - topBarHeight);
                    break;
                default:
                    break;
            }
            
        }
    }

    /*public static List<string> getForecastWeather()
    {
        ClientSettings.ApiUrl = "http://api.openweathermap.org/data/2.5";
        ClientSettings.ApiKey = "d8f6deea88bb177513cc8a14cf629020";

        List<string> cityDat = getCityState();

        var result = SixteenDaysForecast.GetByCityName(cityDat[0], cityDat[1], 7);

        var t = result.Items;
        return null;
    }*/
}
