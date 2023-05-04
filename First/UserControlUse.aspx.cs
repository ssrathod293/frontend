using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class UserControlUse : System.Web.UI.Page
    {
        public string Name
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //read name and email
            string name = txtName.Text;
            //string email = ((TextBox)MyControl.FindControl("txtEmail")).Text;
            string email = MyControl.Email;
            Response.Write($"Name:{name}<br/>");
            Response.Write($"Email:{email}<br/>");
        }
    }
}