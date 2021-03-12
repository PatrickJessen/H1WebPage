using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace H1WebPage
{
    public class MovieManager
    {
        MovieDal dal = new MovieDal();
        public void DeleteMovie(int id)
        {
            dal.DeleteMovie(id);
        }

        public void SelectMovie(GridView gv)
        {
            dal.SelectMovie(gv);
        }

        public Movie InsertMovie(Movie movie)
        {
            return dal.InsertMovie(movie);
        }
    }
}