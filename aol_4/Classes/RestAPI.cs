using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aol.Forms
{
    class RestAPI
    {
        public static JObject getData(string request, string postVals)
        {
            var client = new WebClient();
            client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            string response = client.UploadString("https://aolemu.com/api?" + request, "POST", postVals);
            return JObject.Parse(response);
        }

        public static bool createAccount(string user, string pass, string fn)
        {
            string encPass = Encoding.Default.GetString(sqlite_accounts.Hash(pass, sqlite_accounts.passSalt));
            var data = getData("create", "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass) + "&fullname=" + WebUtility.UrlEncode(fn));
            string msg = (string)data.SelectToken("content[0].msg");
            if (msg == "success")
            {
                int code = sqlite_accounts.createAcc(user, fn);
                if (code == 0)
                    return true;
                else
                    MessageBox.Show("SQLite error code " + code.ToString());
            }
            return false;
        }

        public static bool loginAccount(string user, string pass)
        {
            string encPass = Encoding.Default.GetString(sqlite_accounts.Hash(pass, sqlite_accounts.passSalt));
            var data = getData("fetch", "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                accForm.tmpUsername = user;
                accForm.tmpPassword = encPass;
                return true;
            }
            return false;
        }

        public static string getAccInfo(string token)
        {
            var data = getData("fetch", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword));
            if ((string)data.SelectToken("content[0].msg") == "success")
                return (string)data.SelectToken("content[0]." + token);
            return "";
        }

        public static bool updateFullName(string newfn)
        {
            var data = getData("updatefn", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword) + "&newfn=" + WebUtility.UrlEncode(newfn));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                sqlite_accounts.updateFullName(newfn);
                return true;
            }
            return false;
        }

        public static bool updatePassword(string newpw)
        {
            var data = getData("updatepw", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword) + "&newpw=" + WebUtility.UrlEncode(newpw));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                // needs SQLite cmd
                return true;
            }
            return false;
        }

        public static bool addBuddy(string username)
        {
            var data = getData("addbuddy", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword) + "&buddy=" + WebUtility.UrlEncode(username));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                sqlite_accounts.addBuddy(username);
                return true;
            }
            return false;
        }

        public static bool removeBuddy(string buddyid)
        {
            var data = getData("removebuddy", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword) + "&buddyid=" + WebUtility.UrlEncode(buddyid));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                // needs SQLite cmd
                return true;
            }
            return false;
        }
    }
}
