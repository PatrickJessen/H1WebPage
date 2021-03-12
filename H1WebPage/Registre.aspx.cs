using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H1WebPage
{
    public partial class Registre : System.Web.UI.Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void registre_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("test");
            userManager.InsertUser(new User(fName.Value, lName.Value, password.Value, hobby.Value), username.Value, password.Value);
        }
    }
}