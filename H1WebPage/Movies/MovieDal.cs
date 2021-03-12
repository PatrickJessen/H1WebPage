using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace H1WebPage
{
    public class MovieDal
    {
        public string ConString { get; } = "Server=localhost;Database=movienight;Trusted_Connection=True;";

        public Movie InsertMovie(Movie movie)
        {
            string query = "INSERT INTO movie (title, description, year, genre) VALUES (@title, @desc, @year, @genre)";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@title", movie.Title);
                cmd.Parameters.AddWithValue("@desc", movie.Description);
                cmd.Parameters.AddWithValue("@year", movie.Year);
                cmd.Parameters.AddWithValue("@genre", movie.Genre);
                cmd.ExecuteNonQuery();
            }
            return movie;
        }

        public void DeleteMovie(int id)
        {
            string query = $"DELETE FROM movie WHERE id = {id}";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.ExecuteNonQuery();
            };

        }

        public void SelectMovie(GridView gv)
        {
            string query = "SELECT * FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                gv.DataSource = dt;
                gv.DataBind();
                
            }
        }

        public void SelectDescription(DataTable dt)
        {
            string temp = "";
            string query = "SELECT * FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds, "");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    temp += dt.Rows[0]["description"];
                }
            }
        }

        public void SelectYear(DataTable dt)
        {
            string temp = "";
            string query = "SELECT * FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds, "");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    temp += dt.Rows[0]["year"];
                }
            }
        }

        public void SelectGenre(DataTable dt)
        {
            string temp = "";
            string query = "SELECT * FROM movie";
            using (SqlConnection connection = new SqlConnection(ConString))
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds, "");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    temp += dt.Rows[0]["genre"];
                }
            }
        }
    }
}