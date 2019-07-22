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
        private static JObject getData(string request, string postVals)
        {
            var client = new WebClient();
            string response = "{\"content\": [{ \"msg\": \"ERROR\" }]}";
            client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            try
            {
                response = client.UploadString("https://aolemu.com/api?" + request, "POST", postVals);
            }
            catch
            {
                MessageBox.Show("Error connecting to aolemu.com");
            }
            return JObject.Parse(response);
        }

        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Creates an account in the rest api DB. Will also create an account in the SQLite db.
        /// </summary>
        /// <param name="user">Username, not the email address.</param>
        /// <param name="pass">Unencrypted password.</param>
        /// <param name="fn">Full name of the account holder.</param>
        /// <returns></returns>
        public static bool createAccount(string user, string pass, string fn)
        {
            string encPass = CreateMD5(pass);
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

        /// <summary>
        /// Check account credentials using the rest api. Will return true upon correct credentials and set accForm's tmpUsername tmpPassword variables.
        /// </summary>
        /// <param name="user">Account username. Do not provide the email address.</param>
        /// <param name="pass">Unencrypted password must be provided.</param>
        /// <returns></returns>
        public static bool loginAccount(string user, string pass)
        {
            string encPass = CreateMD5(pass);
            var data = getData("fetch", "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                accForm.tmpUsername = user;
                accForm.tmpPassword = encPass;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Get specific account information from rest api. Currently can only get 1 piece of information.
        /// </summary>
        /// <param name="token">Specify which information you need. Ex: fullname</param>
        /// <param name="user">OPTIONAL: If using prior to login, you need to provide a username/password</param>
        /// <param name="pass">OPTIONAL: If using prior to login, you need to provide a username/password</param>
        /// <returns></returns>
        public static string getAccInfo(string token, string user = "", string pass = "")
        {
            if (user == "")
                user = accForm.tmpUsername;
            if (pass == "")
                pass = accForm.tmpPassword;
            else
                pass = CreateMD5(pass);

            var data = getData("fetch", "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(pass));
            if ((string)data.SelectToken("content[0].msg") == "success")
                return (string)data.SelectToken("content[0]." + token);
            return "";
        }

        /// <summary>
        /// Updates the full name of the account holder in the rest api db and the sqlite db. This can only be done after login.
        /// </summary>
        /// <param name="newfn">New full name for the account holder.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the password for the account in the rest api db. This can only be done after login.
        /// </summary>
        /// <param name="newpw">New account password. Provide this unencrypted.</param>
        /// <returns></returns>
        public static bool updatePassword(string newpw)
        {
            newpw = Encoding.Default.GetString(sqlite_accounts.Hash(newpw, sqlite_accounts.passSalt));
            var data = getData("updatepw", "user=" + WebUtility.UrlEncode(accForm.tmpUsername) + "&pass=" + WebUtility.UrlEncode(accForm.tmpPassword) + "&newpw=" + WebUtility.UrlEncode(newpw));
            if ((string)data.SelectToken("content[0].msg") == "success")
            {
                // needs SQLite cmd
                return true;
            }
            return false;
        }

        /// <summary>
        /// Add buddy in the rest api db. This can only be done after login.
        /// </summary>
        /// <param name="username">Buddy's username</param>
        /// <returns></returns>
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

        /// <summary>
        /// Remove buddy from associated account in the rest api db. This can only be done after login.
        /// </summary>
        /// <param name="buddyid"></param>
        /// <returns></returns>
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
