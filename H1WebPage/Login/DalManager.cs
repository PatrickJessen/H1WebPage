using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace H1WebPage
{
    public class DalManager
    {
        public string ConString { get; } = "Server=localhost;Database=loginForm;Trusted_Connection=True;";

        public string RegistreUser(string user, string passw)
        {
            string query = "INSERT INTO users (username, passw) VALUES (@username, @passw)";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", user);
                cmd.Parameters.AddWithValue("@passw", passw);
                cmd.ExecuteNonQuery();
            }
            return user;
        }

        public User InsertInfo(User user, string username, string passw)
        {
            string query = $"INSERT INTO userInfo (id, fName, lName, hobby) VALUES (@id, @fName, @lName, @hobby)";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", GetUserID(username, passw));
                cmd.Parameters.AddWithValue("@fName", user.FName);
                cmd.Parameters.AddWithValue("@lName", user.LName);
                cmd.Parameters.AddWithValue("@hobby", user.Hobby);
                cmd.ExecuteNonQuery();
            }
            return user;
        }

        private int GetUserID(string username, string passw)
        {
            string query = $"SELECT id FROM users WHERE username = '{RegistreUser(username, passw)}'";
            //string query = "SELECT id FROM users WHERE username = " + RegistreUser(test);
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return (int)dt.Rows[0]["id"];
            }
        }

        public string IsUsernameValid(string username)
        {
            try
            {
                string query = $"SELECT username FROM users WHERE username = '{username}'";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);

                    return dt.Rows[0]["username"].ToString();
                }
            }
            catch
            {
                return "";
            }
        }

        public string IsPasswordValid(string username)
        {
            try
            {
                string query = $"SELECT passw FROM users WHERE username = '{IsUsernameValid(username)}'";
                using (SqlConnection connection = new SqlConnection(ConString))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(dt);

                    return dt.Rows[0]["passw"].ToString();
                }
            }
            catch
            {
                return "";
            }
        }

        private int GetUserID2(string username)
        {
            string query = $"SELECT id FROM users WHERE username = '{IsUsernameValid(username)}'";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);

                return (int)dt.Rows[0]["id"];
            }
        }
    }
}