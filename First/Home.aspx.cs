﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class Home : System.Web.UI.Page
    {
        //event
        protected void Page_Load(object sender, EventArgs e)
        {
            txtname.Value = "VHAASH";
            txtemail.Text = "vaash@gmail.com";
        }
    }
}