using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        public string SidebarName
        {
            get { return txtsidename.Text; }
            set { txtsidename.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnside_Click(object sender, EventArgs e)
        {

        }
    }
}