using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class booking_msg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                b_id.Text = Request.Cookies["new_ID"].Value;
                e_dodd.Text = Request.Cookies["dod"].Value;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }

        }

       
        protected void Button1_Click1(object sender, EventArgs e)
        {
           // Response.Redirect("Delivery_confirm.aspx");
        }
    }
}