using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        public string Email
        {
            get
            {
                return txtEmail.Text;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Write("Message from User Control <br/>");
            ((UserControlUse)Page).Name = "User Control Name";
        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string name = ((UserControlUse)Page).Name;
            Response.Write($"Name:{name}<br/>");
            Response.Write($"Email:{email}<br/>");
        }
    }
}