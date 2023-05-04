using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace First
{
    public class Global : System.Web.HttpApplication
    {
        //it fire once when application launches for the first time
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        //it fires when application closes last
        //iis reset or application pool
        protected void Application_End(object sender, EventArgs e)
        {

        }

        //it fires for new session
        protected void Session_Start(object sender, EventArgs e)
        {

        }
        //it fires when session gets closed
        protected void Session_End(object sender, EventArgs e)
        {

        }
        //it fires when there is unhandled exception in application
        protected void Application_Error(object sender, EventArgs e)
        {

        }
    }
}