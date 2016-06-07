using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class false_insurance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("insur_custid_confirmation.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}