using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H1WebPage
{
    public partial class Index : Page
    {
        MovieManager manager = new MovieManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            manager.SelectMovie(grid);
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie(titleInput.Value, descInput.Value, int.Parse(yearInput.Value), genreInput.Value);
            manager.InsertMovie(movie);
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int Eid = int.Parse(grid.DataKeys[e.RowIndex].Value.ToString());
            manager.DeleteMovie(Eid);
        }
    }
}