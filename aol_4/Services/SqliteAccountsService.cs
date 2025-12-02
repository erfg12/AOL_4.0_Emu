using Microsoft.Data.Sqlite;
using System.Security.Cryptography;

namespace aol.Services;
class SqliteAccountsService
{
    public static SqliteConnection OpenDB()
    {
        var pathDB = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "accounts.db");
        //try {
        //    if (!System.IO.File.Exists(pathDB)) throw new Exception();
        //    Debug.WriteLine("accounts.db file exists");
        //}
        //catch
        //{
        //    MessageBox.Show("ERROR: Sqlite DB file error.");
        //    Application.Exit();
        //}
        //Debug.WriteLine("pageDB=" + pathDB);
        return new SqliteConnection("Data Source=" + pathDB + ";"); // seems that this now auto creates the file if it doesn't exist.
    }

    public static byte[] passSalt = Encoding.ASCII.GetBytes("My$@lT!2");
    public static byte[] Hash(string value, byte[] salt)
    {
        byte[] saltedValue = Encoding.UTF8.GetBytes(value).Concat(salt).ToArray();
        return new SHA256Managed().ComputeHash(saltedValue);
    }

    /// <summary>
    /// Add history URL to address bar
    /// </summary>
    /// <param name="url">Address bar URL</param>
    /// <returns></returns>
    public static int AddHistory(string url)
    {
        int code = 0;

        url = url.ToLower();
        url = url.Replace("http://", "");
        url = url.Replace("https://", "");

        if (url.EndsWith("/"))
            url = url.Remove(url.Length - 1);

        if (FindHisory(url) > 0)
            return 999;

        //int userID = Convert.ToInt32((await RestAPI.getAccInfo()).account.id);
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();
        long timeStamp = DateTime.Now.ToFileTime();
        string sql = "INSERT INTO history (userid, url, date) VALUES ('" + Account.Info.userid + "', '" + url + "', '" + timeStamp + "')";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    public static int AddFavorite(string url, string URLname)
    {
        int code = 0;

        //int userID = Convert.ToInt32((await RestAPI.getAccInfo()).account.id);
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "INSERT INTO favorites (userid, url, name) VALUES ('" + Account.Info.userid + "', '" + url + "', @URLname)";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteParameter[] parameters = { new SqliteParameter("URLname", URLname) };
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
        }
        catch (SqliteException ex)
        {
            if (ex.ErrorCode != 1) return code;
            using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(id int, userid int, url text, name text)", "favorites"), m_dbConnection))
            {
                Debug.WriteLine("Creating favorites table.");
                createTable.ExecuteNonQuery();
            }
        }

        m_dbConnection.Close();
        return code;
    }

    /// <summary>
    /// Deletes favorite from URL in SqliteDB
    /// </summary>
    /// <param name="url">URL to delete from favorite</param>
    /// <returns></returns>
    public static int DeleteFavorite(string url)
    {
        int code = 0;
        //int userID = Convert.ToInt32((await RestAPI.getAccInfo()).account.id);
        ConcurrentBag<string> history = new ConcurrentBag<string>();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM favorites WHERE userid = '" + Account.Info.userid + "' AND url = '" + url + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "DELETE FROM favorites WHERE userid = '" + Account.Info.userid + "' AND url = '" + url + "'";
                SqliteDataReader reader = command.ExecuteReader();
            }
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    public static int UpdateFavorite(string url, string name)
    {
        int code = 0;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM favorites WHERE name = '" + name + "' AND url = '" + url + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "UPDATE favorites SET name = '" + name + "' WHERE url = '" + url + "'";
                SqliteDataReader reader = command.ExecuteReader();
            }
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    /// <summary>
    /// Key = URL, Value = Name
    /// </summary>
    /// <returns></returns>
    public static async Task<ConcurrentDictionary<string, string>> GetFavoritesList()
    {
        //int userID = Convert.ToInt32((await RestAPI.getAccInfo()).account.id);
        ConcurrentDictionary<string, string> favorites = new ConcurrentDictionary<string, string>();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            command.CommandText = "SELECT count(*) FROM favorites WHERE userid = '" + Account.Info.userid + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "SELECT * FROM favorites WHERE userid = '" + Account.Info.userid + "'";

                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    favorites.TryAdd(reader["url"].ToString(), reader["name"].ToString());
                }
            }
        }
        catch (SqliteException ex)
        {
            if (ex.ErrorCode != 1) return favorites;
            using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(id int, userid int, url text, name text)", "favorites"), m_dbConnection))
            {
                Debug.WriteLine("Creating favorites table.");
                createTable.ExecuteNonQuery();
            }
        }

        m_dbConnection.Close();
        return favorites;
    }

    /// <summary>
    /// Get history to add to address bar drop down list
    /// </summary>
    /// <returns></returns>
    public static List<string> GetHistory()
    {
        //var accInfo = await RestAPI.getAccInfo();
        if (Account.Info == null)
            return new List<string> { null }; // error, account not found. Prevent crash.

        List<string> history = new List<string>();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            int userID = Account.Info.userid;

            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM history WHERE userid = '" + userID + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "SELECT * FROM history WHERE userid = '" + userID + "'";

                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    history.Add(reader["url"].ToString());
                }
            }
        }
        catch (SqliteException ex)
        {
            if (ex.ErrorCode != 1) return history;
            using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(id int, userid int, url text, date int)", "history"), m_dbConnection))
            {
                Debug.WriteLine("Creating history table.");
                createTable.ExecuteNonQuery();
            }
        }
        catch
        {
            Debug.WriteLine("unknown error in getHistory()");
        }

        m_dbConnection.Close();
        return history;
    }

    public static int DeleteHistory(string url)
    {
        int code = 0;
        int userID = Account.Info.userid;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "DELETE FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
                SqliteDataReader reader = command.ExecuteReader();
            }
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    /// <summary>
    /// Returns 0 on success, otherwise an error number will be given.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="pass">encrypted</param>
    /// <param name="fullname"></param>
    /// <returns>0 on success, otherwise an error number</returns>
    public static int CreateAccount(string user, string pass, string fullname)
    {
        int code = 0;

        if (FindAccount(user) > 0)
            return 999;

        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();
        string sql = "INSERT INTO aol_accounts (username, password, fullname) VALUES ('" + user + "', '" + pass + "', @fullname)";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteParameter[] parameters = { new SqliteParameter("fullname", fullname) };
            command.Parameters.AddRange(parameters);
            command.ExecuteNonQuery();
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    /// <summary>
    /// Check if history URL is already present, 0 = failed
    /// </summary>
    /// <param name="url">URL</param>
    /// <returns></returns>
    public static int FindHisory(string url)
    {
        int foundHistory = 0;
        int userID = Account.Info.userid;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "SELECT * FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
        SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            foundHistory++;
        }

        m_dbConnection.Close();
        return foundHistory;
    }

    /// <summary>
    /// Find account, return user ID.
    /// </summary>
    /// <param name="user">username</param>
    /// <returns></returns>
    public static int FindAccount(string user)
    {
        int foundAcc = 0;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "SELECT userid FROM aol_accounts WHERE username = '" + user + "'";
        SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            if (reader.GetInt32(0) > 0)
                foundAcc = reader.GetInt32(0);
        }

        m_dbConnection.Close();
        return foundAcc;
    }

    /// <summary>
    /// Check if account exists, return user ID. -1 if user account doesnt exist
    /// </summary>
    /// <param name="user">username</param>
    /// <param name="pass">password</param>
    /// <returns>-1 if account not found, otherwise user id</returns>
    public static int LoginAccount(string user, string pass)
    {
        int foundAcc = -1;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "SELECT userid FROM aol_accounts WHERE username = '" + user + "' AND password = '" + pass + "'";
        SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            if (reader.GetInt32(0) > 0)
                foundAcc = reader.GetInt32(0);
        }

        m_dbConnection.Close();
        return foundAcc;
    }

    public static Models.Email GetEmail(int userId)
    {
        Models.Email foundAcc = new ();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = $"SELECT * FROM email_accounts WHERE user_id = {userId}";
        SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            if (reader.GetInt32(0) > 0)
            {
                foundAcc = new Models.Email
                {
                    id = reader.GetInt32(reader.GetOrdinal("id")),
                    host = reader.GetString(reader.GetOrdinal("host")),
                    address = reader.GetString(reader.GetOrdinal("address")),
                    username = reader.GetString(reader.GetOrdinal("username")),
                    password = reader.GetString(reader.GetOrdinal("password")),
                    imapPort = reader.GetInt32(reader.GetOrdinal("imap_port")),
                    smtpPort = reader.GetInt32(reader.GetOrdinal("smtp_port")),
                    useSSL = reader.GetInt32(reader.GetOrdinal("ssl"))
                    // Map other columns as needed
                };
            }
        }

        m_dbConnection.Close();
        return foundAcc;
    }

    public static bool AddBuddy(string user)
    {
        if (user == null)
            return false;

        bool good = false;
        int userID = Account.Info.userid;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand cmd = new SqliteCommand { Connection = m_dbConnection };
            cmd.CommandText = "SELECT count(*) FROM buddy_list WHERE userid = '" + userID + "' AND buddy_name = '" + user + "'";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
                return false; // user already exists
        }
        catch (SqliteException ex)
        {
            if (ex.ErrorCode != 1) return false;
            using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(userid int, buddy_name text)", "buddy_list"), m_dbConnection))
            {
                Debug.WriteLine("Creating buddy_list table.");
                createTable.ExecuteNonQuery();
            }
        }

        string sql = "INSERT INTO buddy_list (id, userid, buddy_name) VALUES ('" + userID + "', '" + user + "')";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            ChatService.buddyStatus.TryAdd(user, false); // put them immediately into our buddy list
            good = true;
        }
        catch (SqliteException ex)
        {
            Debug.WriteLine("Sqlite ERR: " + ex.ErrorCode);
        }

        m_dbConnection.Close();
        return good;
    }

    public static bool RemoveBuddy(int buddyId, string user)
    {
        bool good = false;
        int userID = Account.Info.userid;
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = $"DELETE FROM buddy_list WHERE id = '{buddyId}' AND userid = '{userID}'";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            ChatService.buddyStatus.TryRemove(user, out _); // remove them from our buddy list
            good = true;
        }
        catch (SqliteException ex)
        {
            Debug.WriteLine("Sqlite ERR: " + ex.ErrorCode);
        }

        m_dbConnection.Close();
        return good;
    }

    public static List<Models.Buddies> GetBuddyList(string user = "", string pass = "")
    {
        //var accInfo = await RestAPI.getAccInfo();
        int userID = Account.Info.userid;
        List<Models.Buddies> buddies = new();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM buddy_list WHERE userid = '" + userID + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "SELECT * FROM buddy_list WHERE userid = '" + userID + "'";

                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var buddy = new Models.Buddies() { id = Convert.ToInt32(reader["id"]), userid = Convert.ToInt32(reader["userid"]), buddy_name = (string)reader["buddy_name"] };
                    buddies.Add(buddy);
                }
            }
        }
        catch (SqliteException ex)
        {
            if (ex.ErrorCode != 1) return buddies;
            using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(userid int, buddy_name text)", "buddy_list"), m_dbConnection))
            {
                Debug.WriteLine("Creating buddy_list table.");
                createTable.ExecuteNonQuery();
            }
        }

        m_dbConnection.Close();
        return buddies;
    }

    /*public static string[] getEmailInfo()
    {
        int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
        //Debug.WriteLine("tmpUsername:" + tmpUsername + " tmpPassword:" + tmpPassword + " userID:" + userID);
        string[] info = new string[7];
        SqliteConnection m_dbConnection = openDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };
            //Debug.WriteLine("getting email info with id:" + userID);
            command.CommandText = "SELECT count(*) FROM email_accounts WHERE user_id = '" + userID + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count > 0)
            {
                command.CommandText = "SELECT * FROM email_accounts WHERE user_id = '" + userID + "'";

                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    info[0] = reader["address"].ToString();
                    info[1] = reader["password"].ToString();
                    info[2] = reader["imap"].ToString();
                    info[3] = reader["imap_port"].ToString();
                    info[4] = reader["smtp"].ToString();
                    info[5] = reader["smtp_port"].ToString();
                    info[6] = reader["ssl"].ToString();
                }
            }
            else
            {
                Debug.WriteLine("No email acc created yet.");
                info = new string[] { "", "", "", "993", "", "465", "1" };
            }
        }
        catch (SqliteException ex)
        {
            Debug.WriteLine("Sqlite err " + ex.ErrorCode);
        }

        m_dbConnection.Close();
        return info;
    }*/

    public static int GetSetEmailAccount(string address, string username, string password, string imapHost, int imapPort, string smtpHost, int smtpPort, int ssl = 1)
    {
        int code = 0;
        int userID = Account.Info.userid;
        Debug.WriteLine("userID:" + userID);
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        try
        {
            SqliteCommand command = new SqliteCommand { Connection = m_dbConnection };

            command.CommandText = "SELECT count(*) FROM email_accounts WHERE user_id = '" + userID + "'";
            int count = Convert.ToInt32(command.ExecuteScalar());
            if (count == 0)
            {
                Debug.WriteLine("Email acc doesnt exists, inserting...");
                command.CommandText = "INSERT INTO email_accounts (user_id, address, password, imap_host, imap_port, smtp_host, smtp_port, ssl) VALUES ('" + userID + "', '" + address + "', '" + username + "', @encPass, '" + imapHost + "', '" + imapPort + "', '" + smtpHost + "', '" + smtpPort + "', '" + ssl + "')";
            }
            else
            {
                Debug.WriteLine("Email acc exists, updating...");
                command.CommandText = "UPDATE email_accounts SET address = '" + address + "', password = @encPass, imap_host = '" + imapHost + "', imap_port = '" + imapPort + "', smtp_host = '" + smtpHost + "', smtp_port = '" + smtpPort + "', ssl = '" + ssl + "' WHERE user_id = '" + userID + "'";
            }
            //command.Parameters.AddWithValue("encPass", encryptedPass); // encrypt this or something in the future
            command.Parameters.AddWithValue("encPass", password);
            command.ExecuteNonQuery();
        }
        catch (SqliteException ex)
        {
            code = ex.ErrorCode;
        }

        m_dbConnection.Close();
        return code;
    }

    public static string GetFullName()
    {
        string foundFN = "";
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "SELECT fullname FROM aol_accounts WHERE username = '" + Account.Info.password + "'";
        SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
        SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            foundFN = reader.GetString(0);
        }

        m_dbConnection.Close();
        return foundFN;
    }

    public static void UpdateFullName(string fullname)
    {
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();
        string sql = "UPDATE aol_accounts SET fullname = '" + fullname + "' WHERE username = '" + Account.Info.password + "'";

        try
        {
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
        catch (SqliteException ex)
        {
            Console.WriteLine("updateFullName error " + ex.ErrorCode);
        }

        m_dbConnection.Close();
    }

    public static ConcurrentBag<string> ListAccounts()
    {
        ConcurrentBag<string> accs = new ConcurrentBag<string>();
        SqliteConnection m_dbConnection = OpenDB();
        m_dbConnection.Open();

        string sql = "SELECT username FROM aol_accounts";
        using (SqliteCommand command = new SqliteCommand(sql, m_dbConnection))
        {
            try
            {
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        accs.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            } 
            catch (SqliteException ex)
            {
                if (ex.ErrorCode != 1) return accs;
                using (SqliteCommand createTable = new SqliteCommand(string.Format("CREATE TABLE IF NOT EXISTS {0}(userid int, username text, fullname text)", "aol_accounts"), m_dbConnection))
                {
                    Debug.WriteLine("Creating aol_accounts table.");
                    createTable.ExecuteNonQuery();
                }
            }
        }

        m_dbConnection.Close();

        return accs;
    }
}
