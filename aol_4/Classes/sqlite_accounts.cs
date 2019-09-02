using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Diagnostics;
using aol.Classes;
using System.Windows.Forms;

namespace aol.Forms
{
    class sqlite_accounts
    {
        public static SQLiteConnection openDB()
        {
            var pathDB = System.IO.Path.Combine(Environment.CurrentDirectory, "accounts.db");
            try {
                if (!System.IO.File.Exists(pathDB)) throw new Exception();
            }
            catch
            {
                MessageBox.Show("ERROR: SQLite DB file error.");
                Application.Exit();
            }
            //Debug.WriteLine("pageDB=" + pathDB);
            return new SQLiteConnection("Data Source=" + pathDB + ";Version=3;");
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
        public static int addHistory(string url)
        {
            int code = 0;

            url = url.ToLower();
            url = url.Replace("http://", "");
            url = url.Replace("https://", "");

            if (url.EndsWith("/"))
                url = url.Remove(url.Length - 1);

            if (findHisory(url) > 0)
                return 999;

            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();
            long timeStamp = DateTime.Now.ToFileTime();
            string sql = "INSERT INTO history (userid, url, date) VALUES ('" + userID + "', '" + url + "', '" + timeStamp + "')";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();
            return code;
        }

        public static int addFavorite(string url, string URLname)
        {
            int code = 0;

            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "INSERT INTO favorites (userid, url, name) VALUES ('" + userID + "', '" + url + "', @URLname)";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteParameter[] parameters = { new SQLiteParameter("URLname", URLname) };
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();
            return code;
        }

        /// <summary>
        /// Deletes favorite from URL in SqliteDB
        /// </summary>
        /// <param name="url">URL to delete from favorite</param>
        /// <returns></returns>
        public static int deleteFavorite(string url)
        {
            int code = 0;
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            List<string> history = new List<string>();
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM favorites WHERE userid = '" + userID + "' AND url = '" + url + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "DELETE FROM favorites WHERE userid = '" + userID + "' AND url = '" + url + "'";
                    SQLiteDataReader reader = command.ExecuteReader();
                }
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();
            return code;
        }

        public static int updateFavorite(string url, string name)
        {
            int code = 0;
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM favorites WHERE name = '" + name + "' AND url = '" + url + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "UPDATE favorites SET name = '" + name + "' WHERE url = '" + url + "'";
                    SQLiteDataReader reader = command.ExecuteReader();
                }
            }
            catch (SQLiteException ex)
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
        public static Dictionary<string, string> getFavoritesList()
        {
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            Dictionary<string, string> favorites = new Dictionary<string, string>();
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                command.CommandText = "SELECT count(*) FROM favorites WHERE userid = '" + userID + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "SELECT * FROM favorites WHERE userid = '" + userID + "'";

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        favorites.Add(reader["url"].ToString(), reader["name"].ToString());
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite err " + ex.ErrorCode);
            }

            m_dbConnection.Close();
            return favorites;
        }

        /// <summary>
        /// Get history to add to address bar drop down list
        /// </summary>
        /// <returns></returns>
        public static List<string> getHistory()
        {
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            List<string> history = new List<string>();
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM history WHERE userid = '" + userID + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "SELECT * FROM history WHERE userid = '" + userID + "'";

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        history.Add(reader["url"].ToString());
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite err " + ex.ErrorCode);
            }

            m_dbConnection.Close();
            return history;
        }

        public static int deleteHistory(string url)
        {
            int code = 0;
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "DELETE FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
                    SQLiteDataReader reader = command.ExecuteReader();
                }
            }
            catch (SQLiteException ex)
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
        /// <returns></returns>
        public static int createAcc(string user, string fullname)
        {
            int code = 0;

            if (findAcc(user) > 0)
                return 999;

            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();
            string sql = "INSERT INTO aol_accounts (username, fullname) VALUES ('" + user + "', @fullname)";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteParameter[] parameters = { new SQLiteParameter("fullname", fullname) };
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
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
        public static int findHisory(string url)
        {
            int foundHistory = 0;
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT * FROM history WHERE userid = '" + userID + "' AND url = '" + url + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
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
        public static int findAcc(string user)
        {
            int foundAcc = 0;
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT userid FROM aol_accounts WHERE username = '" + user + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) > 0)
                    foundAcc = reader.GetInt32(0);
            }

            m_dbConnection.Close();
            return foundAcc;
        }

        public static bool addBuddy(string user)
        {
            bool good = false;
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                cmd.CommandText = "SELECT count(*) FROM buddy_list WHERE userid = '" + userID + "' AND buddy_name = '" + user + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                    return false; // user already exists
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite ERR: " + ex.ErrorCode);
            }

            string sql = "INSERT INTO buddy_list (userid, buddy_name) VALUES ('" + userID + "', '" + user + "')";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                chat.buddyStatus.Add(user, false); // put them immediately into our buddy list
                good = true;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite ERR: " + ex.ErrorCode);
            }

            m_dbConnection.Close();
            return good;
        }

        public static List<string> getBuddyList(string user = "", string pass = "")
        {
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id", user, pass));
            List<string> buddies = new List<string>();
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM buddy_list WHERE userid = '" + userID + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "SELECT * FROM buddy_list WHERE userid = '" + userID + "'";

                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        buddies.Add(reader["buddy_name"].ToString());
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite err " + ex.ErrorCode);
            }

            m_dbConnection.Close();
            return buddies;
        }

        /*public static string[] getEmailInfo()
        {
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            //Debug.WriteLine("tmpUsername:" + tmpUsername + " tmpPassword:" + tmpPassword + " userID:" + userID);
            string[] info = new string[7];
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);
                //Debug.WriteLine("getting email info with id:" + userID);
                command.CommandText = "SELECT count(*) FROM email_accounts WHERE user_id = '" + userID + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    command.CommandText = "SELECT * FROM email_accounts WHERE user_id = '" + userID + "'";

                    SQLiteDataReader reader = command.ExecuteReader();
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
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite err " + ex.ErrorCode);
            }

            m_dbConnection.Close();
            return info;
        }*/

        public static int emailAcc(string address, string pass, string imap, int imapPort, string smtp, int smtpPort, int ssl)
        {
            int code = 0;
            int userID = Convert.ToInt32(RestAPI.getAccInfo("id"));
            Debug.WriteLine("userID:" + userID);
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            try
            {
                SQLiteCommand command = new SQLiteCommand(m_dbConnection);

                command.CommandText = "SELECT count(*) FROM email_accounts WHERE user_id = '" + userID + "'";
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    Debug.WriteLine("Email acc doesnt exists, inserting...");
                    command.CommandText = "INSERT INTO email_accounts (user_id, address, password, imap, imap_port, smtp, smtp_port, ssl) VALUES ('" + userID + "', '" + address + "', @encPass, '" + imap + "', '" + imapPort + "', '" + smtp + "', '" + smtpPort + "', '" + ssl + "')";
                }
                else
                {
                    Debug.WriteLine("Email acc exists, updating...");
                    command.CommandText = "UPDATE email_accounts SET address = '" + address + "', password = @encPass, imap = '" + imap + "', imap_port = '" + imapPort + "', smtp = '" + smtp + "', smtp_port = '" + smtpPort + "', ssl = '" + ssl + "' WHERE user_id = '" + userID + "'";
                }
                //command.Parameters.AddWithValue("encPass", encryptedPass); // encrypt this or something in the future
                command.Parameters.AddWithValue("encPass", pass);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();
            return code;
        }

        public static string getFullName()
        {
            string foundFN = "";
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT fullname FROM aol_accounts WHERE username = '" + accForm.tmpUsername + "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                foundFN = reader.GetString(0);
            }

            m_dbConnection.Close();
            return foundFN;
        }

        public static void updateFullName(string fullname)
        {
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();
            string sql = "UPDATE aol_accounts SET fullname = '" + fullname + "' WHERE username = '" + accForm.tmpUsername + "'";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("updateFullName error " + ex.ErrorCode);
            }

            m_dbConnection.Close();
        }

        public static List<string> listAccounts()
        {
            List<string> accs = new List<string>();
            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT username FROM aol_accounts";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            try
            {
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    accs.Add(reader.GetString(0));
                }
            } catch { }

            m_dbConnection.Close();
            return accs;
        }
    }
}
