using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsignIn_Click(object sender, EventArgs e)
        {
            //read username and password
            //validate
            //hit database to check if user is valid or not
            string username = floatingInput.Value;
            string password = floatingPassword.Value;

            //Response.Write($"UserName:{username} \n  PassWord:{password}");
            Response.Redirect("Home.aspx");


        }
    }
}
