using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace aol.Classes;
class RestAPIClass
{
    private static async Task<JObject> getData(string request, HttpMethod method, string queryParams)
    {
        var client = new HttpClient();
        HttpResponseMessage response;
        try
        {
            var requestMsg = new HttpRequestMessage(method, $"https://api.aolemu.com/{request}?{queryParams}") { };
            var httpResponse = await client.SendAsync(requestMsg);
            response = httpResponse;
        }
        catch
        {
            MessageBox.Show("Error connecting to aolemu.com");
            return JObject.Parse("{\"message\": \"Error connecting to aolemu.com\" }");
        }
        return JObject.Parse(await response.Content.ReadAsStringAsync());
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
    public static async Task<bool> createAccount(string user, string pass, string fn)
    {
        if (user == "" || pass == "")
            return false;
        string encPass = CreateMD5(pass);
        var data = await getData("Account", HttpMethod.Post, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass) + "&fullname=" + WebUtility.UrlEncode(fn));
        var userApi = data.ToObject<userAPI>();
        if (userApi.account != null)
        {
            int code = SqliteAccountsClass.createAcc(user, userApi.account.id, fn);
            if (code == 0)
                return true;
            else
                MessageBox.Show("SQLite error code " + code.ToString());
        } else
        {
            MessageBox.Show("MSG: " + userApi.message);
        }
        return false;
    }

    /// <summary>
    /// Check account credentials using the rest api. Will return true upon correct credentials and set accForm's tmpUsername tmpPassword variables.
    /// </summary>
    /// <param name="user">Account username. Do not provide the email address.</param>
    /// <param name="pass">Unencrypted password must be provided.</param>
    /// <returns></returns>
    public static async Task<bool> loginAccount(string user, string pass)
    {
        if (user == "" || pass == "")
            return false;
        string encPass = CreateMD5(pass);
        var data = await getData("Account", HttpMethod.Get, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass));
        string msg = (string)data.SelectToken("message");
        if (!string.IsNullOrEmpty(msg)) // message = error msg
        {
            MessageBox.Show("Account either doesn't exist, or incorrect password.");
        } else
        {
            Account.tmpUsername = user;
            Account.tmpPassword = encPass;
            Account.accountInfo = data.ToObject<userAPI>(); // store account info in accForm for later use
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
    public static async Task<userAPI> getAccInfo(string user = "", string pass = "")
    {
        if (user == "")
            user = Account.tmpUsername;
        if (pass == "")
            pass = Account.tmpPassword;
        else
            pass = CreateMD5(pass);

        var data = await getData("Account", HttpMethod.Get, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(pass));
        var t = data.ToObject<userAPI>();
        return t;
    }

    public static async Task<IList<userAPI.Buddies>> getBuddyList(string user, string pass)
    {
        if (user == "" || pass == "")
            return null;

        pass = CreateMD5(pass);

        var data = await getData("Account", HttpMethod.Get, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(pass));
        return data.ToObject<userAPI>().buddies;
    }

    /// <summary>
    /// Updates the full name of the account holder in the rest api db and the sqlite db. This can only be done after login.
    /// </summary>
    /// <param name="newfn">New full name for the account holder.</param>
    /// <returns></returns>
    public static async Task<bool> updateFullName(string newfn)
    {
        if (!Account.SignedIn())
            return false;

        var data = await getData("Account", HttpMethod.Patch, "user=" + WebUtility.UrlEncode(Account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(Account.tmpPassword) + "&newfn=" + WebUtility.UrlEncode(newfn));
        if ((string)data.SelectToken("content[0].msg") == "success")
        {
            SqliteAccountsClass.updateFullName(newfn);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Updates the password for the account in the rest api db. This can only be done after login.
    /// </summary>
    /// <param name="newpw">New account password. Provide this unencrypted.</param>
    /// <returns></returns>
    public static async Task<bool> updatePassword(string newpw)
    {
        if (!Account.SignedIn())
            return false;
        newpw = Encoding.Default.GetString(SqliteAccountsClass.Hash(newpw, SqliteAccountsClass.passSalt));
        var data = await getData("Account", HttpMethod.Patch, "user=" + WebUtility.UrlEncode(Account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(Account.tmpPassword) + "&newpw=" + WebUtility.UrlEncode(newpw));
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
    public static async Task<bool> addBuddy(string username)
    {
        if (!Account.SignedIn())
            return false;

        var data = await getData("Buddy", HttpMethod.Post, "user=" + WebUtility.UrlEncode(Account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(Account.tmpPassword) + "&buddyName=" + WebUtility.UrlEncode(username));
        var buddyData = data.ToObject<userAPI.Buddies>();
        if (buddyData.id != null) // message = error msg
        {
            await SqliteAccountsClass.addBuddy(buddyData.id, buddyData.username);
            return true;
        }

        return false;
    }

    /// <summary>
    /// Remove buddy from associated account in the rest api db. This can only be done after login.
    /// </summary>
    /// <param name="buddyid"></param>
    /// <returns></returns>
    public static async Task<bool> removeBuddy(string buddyid)
    {
        if (!Account.SignedIn())
            return false;

        var data = await getData("Buddy", HttpMethod.Delete, "user=" + WebUtility.UrlEncode(Account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(Account.tmpPassword) + "&buddyId=" + WebUtility.UrlEncode(buddyid));
        string msg = (string)data.SelectToken("message");
        if (!string.IsNullOrEmpty(msg) && msg.Contains("buddy removed successfully"))
        {
            // needs SQLite cmd
            return true;
        }
        return false;
    }
}
