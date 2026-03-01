namespace aol.Services;
public class RestAPIService
{
    private readonly AccountService account;
    private readonly SqliteService sqLite;
    public RestAPIService(AccountService acc, SqliteService sql)
    {
        account = acc;
        sqLite = sql;
    }
    /// <summary>
    /// Fetch data from Rest API server. This is a general function that can be used for any endpoint in the API. 
    /// Returns null if there is an error, otherwise returns the data as a JObject.
    /// </summary>
    /// <param name="requestPath">request path</param>
    /// <param name="method">POST, GET, PUT, DELETE</param>
    /// <param name="queryParams">query parameters</param>
    /// <returns>JObject content</returns>
    private static async Task<JObject> GetData(string requestPath, HttpMethod method, string queryParams)
    {
        var client = new HttpClient();
        string content = null;
        HttpResponseMessage httpResponse = null;
        HttpRequestMessage requestMsg = null;

        var domain = "https://api.aolemu.com";
        if (Environment.GetEnvironmentVariable("local_api") != null && Environment.GetEnvironmentVariable("local_api") == "1")
            domain = "https://localhost:7207";
        var url = $"{domain}/{requestPath}?{queryParams}"; // api.aolemu.com

        try
        {
            Debug.WriteLine($"Calling METHOD:{method} URL:{url}");
            requestMsg = new HttpRequestMessage(method, url) { };
            requestMsg.Headers.TryAddWithoutValidation("User-Agent", "AOL-Emu");
            httpResponse = await client.SendAsync(requestMsg);
            httpResponse.EnsureSuccessStatusCode();
            content = await httpResponse.Content.ReadAsStringAsync();
            
            if (string.IsNullOrEmpty(content) || !content.Trim().StartsWith("{") || !content.Trim().EndsWith("}"))
                throw new Exception($"Bad Json Data");
        }
        catch (Exception ex)
        {
            ex.Data.Add("content", content ?? "No Content");
            ex.Data.Add("url", url);
            ex.Data.Add("method", method.ToString());

            SentrySdk.CaptureException(ex);
            Debug.WriteLine($"Error calling API: {ex.Message}");
            Debug.WriteLine($"requestMsg: {requestMsg}");
            Debug.WriteLine($"httpresponse: {httpResponse}");
            Debug.WriteLine($"Content: {content}");
            return null;
        }

        if (content == null)
            return null;

        return JObject.Parse(content);
    }

    /// <summary>
    /// Creates an account in the rest api DB. Will also create an account in the SQLite db.
    /// </summary>
    /// <param name="user">Username, not the email address.</param>
    /// <param name="pass">Unencrypted password.</param>
    /// <param name="fn">Full name of the account holder.</param>
    /// <returns></returns>
    public async Task<(bool success, string msg)> CreateAccount(string user, string pass, string fn)
    {
        if (user == "" || pass == "")
            return (false, "ERROR: missing username/password");
        string encPass = AccountHelper.CreateMD5(pass);
        var data = await GetData("Account", HttpMethod.Post, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass) + "&fullname=" + WebUtility.UrlEncode(fn));
        if (data == null) return (false, "ERROR: API data was null");
        var userApi = data.ToObject<UserAPI>();
        if (userApi.account != null)
        {
            int code = sqLite.CreateAcc(user, userApi.account.id, fn);
            if (code == 0)
            {
                return (true, "Account created successfully.");
            }
            else if (code == 19 || code == 1001)
            {
                return (false, "ERROR: Account already exists.");
            }
            else
            {
                return (false, "ERROR: SQLite error code " + code.ToString());
            }
        }
        else
        {
            return (false, userApi.message);
        }
    }

    /// <summary>
    /// Check account credentials using the rest api. Will return true upon correct credentials and set accForm's tmpUsername tmpPassword variables.
    /// </summary>
    /// <param name="user">Account username. Do not provide the email address.</param>
    /// <param name="pass">Unencrypted password must be provided.</param>
    /// <returns></returns>
    public async Task<bool> LoginAccount(string user, string pass)
    {
        if (user == "" || pass == "")
            return false;
        string encPass = AccountHelper.CreateMD5(pass);
        var data = await GetData("Account", HttpMethod.Get, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(encPass));
        if (data == null) return false;
        string msg = (string)data.SelectToken("message");
        if (string.IsNullOrEmpty(msg))
        {
            account.tmpUsername = user;
            account.tmpPassword = encPass;
            account.accountInfo = data.ToObject<UserAPI>(); // store account info in accForm for later use
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
    public async Task<UserAPI> GetAccInfo(string user = "", string pass = "")
    {
        if (user == "")
            user = account.tmpUsername;
        if (pass == "")
            pass = account.tmpPassword;
        else
            pass = AccountHelper.CreateMD5(pass);

        var data = await GetData("Account", HttpMethod.Get, "user=" + WebUtility.UrlEncode(user) + "&pass=" + WebUtility.UrlEncode(pass));
        if (data == null) return null;
        var t = data.ToObject<UserAPI>();
        return t;
    }

    /// <summary>
    /// Send heartbeat so users know im online
    /// </summary>
    /// <returns>successful</returns>
    public async Task<bool> SendHeartbeat()
    {
        if (!account.SignedIn())
            return false;

        var data = await GetData("Account/heartbeat", HttpMethod.Get, "user=" + WebUtility.UrlEncode(account.tmpUsername));
        if (data == null) return false;

        return (string)data.SelectToken("content[0].msg") == "success";
    }

    /// <summary>
    /// Updates the full name of the account holder in the rest api db and the sqlite db. This can only be done after login.
    /// </summary>
    /// <param name="newfn">New full name for the account holder.</param>
    /// <returns>successful</returns>
    public async Task<bool> UpdateFullName(string newfn)
    {
        if (!account.SignedIn())
            return false;

        var data = await GetData("Account", HttpMethod.Patch, "user=" + WebUtility.UrlEncode(account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(account.tmpPassword) + "&newfn=" + WebUtility.UrlEncode(newfn));
        if (data == null) return false;
        if ((string)data.SelectToken("content[0].msg") == "success")
        {
            sqLite.UpdateFullName(newfn);
            return true;
        }
        return false;
    }

    /// <summary>
    /// Updates the password for the account in the rest api db. This can only be done after login.
    /// </summary>
    /// <param name="newpw">New account password. Provide this unencrypted.</param>
    /// <returns>successful</returns>
    public async Task<bool> UpdatePassword(string newpw)
    {
        if (!account.SignedIn())
            return false;
        newpw = Encoding.Default.GetString(SqliteService.Hash(newpw, SqliteService.passSalt));
        var data = await GetData("Account", HttpMethod.Patch, "user=" + WebUtility.UrlEncode(account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(account.tmpPassword) + "&newpw=" + WebUtility.UrlEncode(newpw));
        if (data == null) return false;
        if ((string)data.SelectToken("content[0].msg") == "success")
        {
            // needs SQLite cmd
            return true;
        }
        return false;
    }

    /// <summary>
    /// Get buddy list.
    /// </summary>
    /// <returns>list of buddies</returns>
    public async Task<List<UserAPI.Buddies>> GetBuddyList()
    {
        if (!account.SignedIn())
            return null;

        var data = await GetData("Buddy", HttpMethod.Get, "user=" + WebUtility.UrlEncode(account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(account.tmpPassword));
        if (data == null) return null;
        // Assuming the JSON contains an array of buddies
        if (data == null) return null;
        var buddyList = data.ToObject<UserAPI>();

        return buddyList.buddies;
    }

    /// <summary>
    /// Add buddy in the rest api db. This can only be done after login.
    /// </summary>
    /// <param name="username">Buddy's username</param>
    /// <returns>tuple - successful, server message</returns>
    public async Task<(bool, string)> AddBuddy(string username)
    {
        if (!account.SignedIn())
            return (false, "sign in first");

        var data = await GetData("Buddy", HttpMethod.Post, "user=" + WebUtility.UrlEncode(account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(account.tmpPassword) + "&buddyName=" + WebUtility.UrlEncode(username));
        if (data == null) return (false, "no response from server");
        var buddyData = data.ToObject<UserAPI.Buddies>();
        if (buddyData?.id != null && buddyData.id > 0) // message = error msg
        {
            sqLite.AddBuddy(buddyData.id, buddyData.username);
            return (true, null);
        }
        else
        {
            if (data.ContainsKey("message"))
                return (false, data["message"].ToString());
        }

        return (false, "unknown error");
    }

    /// <summary>
    /// Remove buddy from associated account in the rest api db. This can only be done after login.
    /// </summary>
    /// <param name="buddyid">buddy id</param>
    /// <returns>tuple - successful, server message</returns>
    public async Task<(bool, string)> RemoveBuddy(int buddyid, string buddyName)
    {
        if (!account.SignedIn())
            return (false, "sign in first");

        var data = await GetData("Buddy", HttpMethod.Delete, "user=" + WebUtility.UrlEncode(account.tmpUsername) + "&pass=" + WebUtility.UrlEncode(account.tmpPassword) + "&buddyId=" + WebUtility.UrlEncode(buddyid.ToString()));
        if (data == null) return (false, "no response from server");
        string msg = (string)data.SelectToken("message");
        if (!string.IsNullOrEmpty(msg) && msg.Contains("buddy removed successfully"))
        {
            sqLite.RemoveBuddy(buddyid, buddyName);
            return (true, null);
        }
        else
        {
            if (data.ContainsKey("message"))
                return (false, data["message"].ToString());
        }

        return (false, "unknown error");
    }
}
