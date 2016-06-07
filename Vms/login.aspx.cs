using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using Bus_Layer;
using System.Web.Security;
using System.IO;

namespace Vms
{
    public partial class login : System.Web.UI.Page
    {
        login_entity le = new login_entity();
        bus_login bl = new bus_login();
        Activity_log al = new Activity_log();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void disablebrowserbackbutton()
        {
            try
            {
                HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                HttpContext.Current.Response.Cache.SetNoServerCaching();
                HttpContext.Current.Response.Cache.SetNoStore();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                le.username = uname.Text;
                le.password = pasw.Text;
                string hash = FormsAuthentication.HashPasswordForStoringInConfigFile(le.password, "SHA1");
                le.password = hash;
                bool i;
                i = bl.get_validation(le);
                if (i == true)
                {

                    Session["uname"] = le.username;
                    al.inf(le.username,DateTime.Now);
                    Response.Redirect("Home.aspx");
                                        
                }
                else
                {
                    err_message.Visible = true;
                    new_user.Visible = true;

                }
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }

        }
    }
}