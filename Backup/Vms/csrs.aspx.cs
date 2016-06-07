using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bus_Layer;
using EntityLayer;
using System.Globalization;

namespace Vms
{
    public partial class csrs : System.Web.UI.Page
    {
        BreakDown_Entity be = new BreakDown_Entity();
        bus_breakdown bb = new bus_breakdown();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                sid.Text = Request.Cookies["ser_id"].Value;
                sed.Text = Request.Cookies["sed1"].Value;
                charge.Text = Request.Cookies["charges"].Value;
                dis.Text = Request.Cookies["discount"].Value;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                //String cid = null, bdd = null, ssd = null, bt = null,bd=null, ld = null;
                double net_sc = 0, a, b, c;
                a = Convert.ToInt32(Request.Cookies["bsc"].Value);
                b = Convert.ToDouble(Request.Cookies["sc"].Value);
                c = Convert.ToDouble(Request.Cookies["discount"].Value);
                net_sc = a + b - c;
                be.cid = Request.Cookies["cid"].Value;
                be.br_date = Convert.ToDateTime(Request.Cookies["bdd"].Value).Date;
                be.service_start_date = Convert.ToDateTime(Request.Cookies["ssd"].Value).Date;
                be.br_type = Request.Cookies["bt"].Value;
                be.br_details = Request.Cookies["bd"].Value;
                be.logged_date = Convert.ToDateTime(Request.Cookies["ld"].Value).Date;
                be.service_end_Date = Convert.ToDateTime(sed.Text).Date;
                be.br_id = sid.Text;
                be.charges = Convert.ToDouble(charge.Text.ToString());
                be.discount = Convert.ToDouble(dis.Text);
                bb.bal_insert_bdi(be);
                Response.Cookies["net_sc"].Value = net_sc.ToString();
                Response.Cookies["sed2"].Value = sed.Text;
                Response.Redirect("confirmed_csrs.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("break_down.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}