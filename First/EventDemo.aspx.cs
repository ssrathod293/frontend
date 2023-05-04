using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class EventDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cb1_CheckedChanged(object sender, EventArgs e)
        {
            Response.Write($"cb1_CheckedChanged:{cb1.Checked}<br/>");
        }

        protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write($"ddl1_SelectedIndexChanged :{ddl1.SelectedValue}<br/>");
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Write(" btn1_Click <br/>");
        }
    }
}