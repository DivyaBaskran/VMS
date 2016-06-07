using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Vms
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            if (Session["uname"] != null)
            {
                //Redirect to Welcome Page if Session is not null  
                Response.Redirect("Home.aspx");

            }
            else
            {
                //Redirect to Login Page if Session is null & Expires   
                Response.Redirect("login.aspx");

            }  
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            error_log.LogError(Server.GetLastError(),"Global Unhandled Errors");
            if (!Response.IsRequestBeingRedirected)
                Response.Redirect("erroer.aspx");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            

            //Server.Transfer("Session_end.aspx");
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}