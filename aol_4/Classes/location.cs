using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WeatherNet;
using WeatherNet.Util;
using System.Configuration;
using System.Collections.Concurrent;

namespace aol.Classes
{
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

    class location
    {
        public static WeatherNet.Util.Api.ApiClient wn = new WeatherNet.Util.Api.ApiClient();
        public static string getIP()
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

        public static List<string> getCityState()
        {
            string MyIP = getIP();
            List<string> tmpList = new List<string>();

            // defaults
            tmpList.Add("New York City");
            tmpList.Add("New York");
            tmpList.Add("10001");

            if (MyIP.Equals(""))
                return tmpList;

            string json = "";
            string AccessKey = "7d7a9198de3b50a37caf5115c63fb4ec";
            string apiURL = "http://api.ipstack.com/" + MyIP + "?access_key=" + AccessKey + "&format=1";

            using (WebClient wc = new WebClient())
            {
                try
                {
                    json = wc.DownloadString(apiURL);
                } 
                catch
                {
                    Console.WriteLine("Error retrieving city, region_name and zip from api.ipstack.com");
                    return tmpList;
                }
            }

            JToken token = JObject.Parse(json);

            tmpList.Clear(); // clear defaults
            tmpList.Add((string)token.SelectToken("city"));
            tmpList.Add((string)token.SelectToken("region_name"));
            tmpList.Add((string)token.SelectToken("zip"));

            return tmpList;
        }

        public static string getCurrentWeather()
        {
            List<string> cityDat = getCityState();

            var result = WeatherNet.Current.GetByCityName(cityDat[0], cityDat[1], "en", "imperial");

            string t = "";
            double t2 = 0.0;

            if (result.Item != null)
            {
                t = result.Item.Title;
                t2 = Math.Round(result.Item.Temp);
            }
            
            return t + " " + t2.ToString();
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
}
