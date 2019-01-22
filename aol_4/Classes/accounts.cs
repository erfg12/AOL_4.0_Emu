using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Diagnostics;
using aol.Classes;

namespace aol.Forms
{
    class accounts
    {
        public static string tmpUsername = "";
        public static string tmpPassword = "";

        public static SQLiteConnection openDB()
        {
            var pathDB = System.IO.Path.Combine(Environment.CurrentDirectory, "accounts.db");
            if (!System.IO.File.Exists(pathDB)) throw new Exception();
            //Debug.WriteLine("pageDB=" + pathDB);
            return new SQLiteConnection("Data Source=" + pathDB + ";Version=3;");
        }

        private static byte[] passSalt = Encoding.ASCII.GetBytes("My$@lT!2");
        private static byte[] Hash(string value, byte[] salt)
        {
            byte[] saltedValue = Encoding.UTF8.GetBytes(value).Concat(salt).ToArray();
            return new SHA256Managed().ComputeHash(saltedValue);
        }

        /// <summary>
        /// Returns 0 on success, otherwise an error number will be given.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass">encrypted</param>
        /// <returns></returns>
        public static int createAcc(string user, string fullname, string pass)
        {
            int code = 0;

            string encryptedPass = Encoding.Default.GetString(Hash(pass, passSalt));

            SQLiteConnection m_dbConnection = openDB();

            m_dbConnection.Open();

            string sql = "INSERT INTO aol_accounts (username, fullname, password) VALUES ('" + user + "', @fullname, @encPass)";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteParameter[] parameters = { new SQLiteParameter("fullname", fullname), new SQLiteParameter("encPass", encryptedPass) };
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                code = ex.ErrorCode;
            }

            m_dbConnection.Close();

            tmpUsername = user;
            tmpPassword = encryptedPass;

            return code;
        }

        /// <summary>
        /// Returns the users account ID. If 0, we failed to get the account.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass">encrypted</param>
        /// <returns></returns>
        public static int loginAcc(string user, string pass, bool encrypt = true)
        {
            int foundAcc = 0;

            //Debug.WriteLine("logging in with user:" + user + " pass:" + pass);

            string encryptedPass = "";
            if (encrypt)
                encryptedPass = Encoding.Default.GetString(Hash(pass, passSalt));
            else
                encryptedPass = pass;

            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT userid FROM aol_accounts WHERE username = '" + user + "' AND password = @encPass";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.Parameters.AddWithValue("encPass", encryptedPass);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetInt32(0) > 0)
                    foundAcc = reader.GetInt32(0);
            }

            m_dbConnection.Close();

            //Debug.WriteLine("storing user:" + user + " pass:" + pass);

            tmpUsername = user;
            tmpPassword = encryptedPass;

            return foundAcc;
        }

        public static bool AddBuddy(string user)
        {
            bool good = false;
            int userID = loginAcc(tmpUsername, tmpPassword, false);

            SQLiteConnection m_dbConnection = openDB();

            m_dbConnection.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand(m_dbConnection);
                cmd.CommandText = "SELECT count(*) FROM buddy_list WHERE userid = '" + userID + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {

                }
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
                good = true;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("SQLite ERR: " + ex.ErrorCode);
            }

            m_dbConnection.Close();

            return good;
        }

        public static List<string> getBuddyList()
        {
            int userID = loginAcc(tmpUsername, tmpPassword, false);
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

        public static string[] getEmailInfo()
        {
            int userID = loginAcc(tmpUsername, tmpPassword, false);

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
        }

        public static int emailAcc(string address, string pass, string imap, int imapPort, string smtp, int smtpPort, int ssl)
        {
            int code = 0;
            int userID = loginAcc(tmpUsername, tmpPassword, false);

            Debug.WriteLine("userID:" + userID);

            string encryptedPass = Encoding.Default.GetString(Hash(pass, passSalt));

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

            string sql = "SELECT fullname FROM aol_accounts WHERE username = '" + tmpUsername + "' AND password = @encPass";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.Parameters.AddWithValue("encPass", tmpPassword);
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

            string sql = "UPDATE aol_accounts SET fullname = '" + fullname + "' WHERE username = '" + tmpUsername + "' AND password = @encPass";

            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.Parameters.AddWithValue("encPass", tmpPassword);
                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("updateFullName error " + ex.ErrorCode);
            }

            m_dbConnection.Close();
        }

        public static Dictionary<string, string> listAccounts()
        {
            Dictionary<string, string> accs = new Dictionary<string, string>();

            SQLiteConnection m_dbConnection = openDB();
            m_dbConnection.Open();

            string sql = "SELECT username, password FROM aol_accounts";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accs.Add(reader.GetString(0), reader.GetString(1));
            }

            m_dbConnection.Close();

            return accs;
        }
    }
}
