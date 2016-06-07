using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class confirmed_csrs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            charges.Text = Request.Cookies["net_sc"].Value;
            sed.Text = Request.Cookies["sed2"].Value;
        }
    }
}