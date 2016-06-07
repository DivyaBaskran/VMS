using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class Delivery_confirm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["uname"]!=null)
             {

            
             }
           else
        {
                Response.Redirect("login.aspx");
        }
         
        

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
            Response.Redirect("deli_warr.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
            
    }
}