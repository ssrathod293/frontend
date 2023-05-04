using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string password = txtpassword.Text;
            string address = txtaddress.Text;
            string gender = string.Empty;
            if (rdmale.Checked)
            {
                gender = rdmale.Text;
            }else if (rdfemale.Checked)
            {
                gender = rdfemale.Text;
            }
            else
            {
                gender = "Unknown";
            }
            string skills = string.Empty;
            if (cbsql.Checked)
            {
                skills += cbsql.Text + ",";
            }
             if (cbCsharp.Checked)
            {
                skills += cbCsharp.Text + ",";
            }
             if (cbjavascript.Checked)
            {
                skills += cbjavascript.Text + ",";
            }
             if (cbbootstrap.Checked)
            {
                skills += cbbootstrap.Text + ",";
            }
             if (cbAdonet.Checked)
            {
                skills += cbAdonet.Text + ",";
            }
            string dob = txtDob.Text;

            Response.Write($"Name:{name} <br/>");
            Response.Write($"Password:{password} <br/>");
            Response.Write($"Address:{address} <br/>");
            Response.Write($"Gender:{gender} <br/>");
            Response.Write($"skills:{skills.Trim(',')} <br/>");
            Response.Write($"DOB:{dob} <br/>");
        }
    }
}