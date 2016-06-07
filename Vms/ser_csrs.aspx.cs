using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vms
{
    public partial class ser_csrs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                si.Text = Request.Cookies["ser_id"].Value;
                cname.Text = Request.Cookies["cname"].Value;
                sch.Text = Request.Cookies["sch_id"].Value;
                sd.Text = Request.Cookies["sd"].Value;
                ssd1.Text = Request.Cookies["ssd"].Value;
                sed.Text = Request.Cookies["sed"].Value;
                sc.Text = Request.Cookies["charges"].Value;
                dis.Text = Request.Cookies["dis"].Value;
                pa.Text = Request.Cookies["pa"].Value;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("servicing_regi_success.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("servicing.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}