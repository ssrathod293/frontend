using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class SignIn : System.Web.UI.Page
    {
        public string WebFormName
        {
            get { return txtWebFormName.Text; }
            set { txtWebFormName.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWebForm_Click(object sender, EventArgs e)
        {

        }
    }
}