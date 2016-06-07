using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using Bus_Layer;
using System.Web.Security;

namespace Vms
{
    public partial class registration : System.Web.UI.Page
    {
        login_entity le = new login_entity();
        bus_login bl = new bus_login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (pa.Text == cp.Text)
                {
                    le.username = un.Text;
                    le.password = pa.Text;
                    String hashpwd = le.password;
                    hashpwd = FormsAuthentication.HashPasswordForStoringInConfigFile(hashpwd, "SHA1");
                    le.password = hashpwd;
                    bl.bus_insert_login(le);
                    Response.Redirect("login.aspx");
                }
                else
                {
                    err.Visible = true;
                }
            }
            catch(Exception ex)
            {
                error_log.LogError(ex);
                
            }

        }
    }
}