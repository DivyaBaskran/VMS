using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class purchase_msg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cid.Text = Request.Cookies["new_ID"].Value;
            edod.Text = Request.Cookies["dod"].Value;
            wed.Text = Request.Cookies["wed"].Value;
            d1.Text = Request.Cookies["1_service"].Value;
            d2.Text = Request.Cookies["2_service"].Value;
            d3.Text = Request.Cookies["3_service"].Value;
            d4.Text = Request.Cookies["4_service"].Value;
        }
    }
}