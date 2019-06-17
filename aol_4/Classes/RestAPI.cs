using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace aol.Forms
{
    class RestAPI
    {
        public static JArray GetData(string request, string postVals)
        {
            var client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string response = client.UploadString("https://aolemu.com/api?" + request, "POST", postVals);
            return JArray.Parse(response); //JObject.Load(response);
        }

        public static bool createAccount (string user, string pass, string fn)
        {
            var data = GetData("create", "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(pass) + "&fullname=" + WebUtility.UrlEncode(fn));
            return false;
        }
    }
}
