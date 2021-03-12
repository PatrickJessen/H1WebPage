using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace H1WebPage
{
    public partial class Default : Page
    {
        UserManager userManager = new UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_ServerClick1(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (username.Value == userManager.GetValidUsername(username.Value) && password.Value == userManager.GetValidPassword(username.Value))
            {
                Server.Transfer("Index.aspx");
            }
            else
            {
                failText.InnerText = "Username and password does not match!";
            }
        }
    }
}