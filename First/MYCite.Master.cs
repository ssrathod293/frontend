using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public string MasterName
        {
            get { return txtMasterName.Text; }
            set { txtMasterName.Text = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMaster_Click(object sender, EventArgs e)
        {
            string mastername = txtMasterName.Text;
            ((SignIn)Page).WebFormName = mastername;

            var sidebar=sidebarContent.FindControl("Sidebar1");
            //sidebar.SidebarName = mastername;
           


        }
    }
}