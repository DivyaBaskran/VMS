using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bus_Layer;
using EntityLayer;
using System.Globalization;
//UI layer of Servicing page
namespace Vms
{
    public partial class servicing : System.Web.UI.Page
    {
        service_entity se = new service_entity();
        bal_servicing bs = new bal_servicing();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uname"] != null)
            {


            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                bool i;
                se.cid = cid.Text;
                i = bs.bus_validate_custid(se);
                int sch_id, charges;
                string ccc = null, xx = null, yy = null, ser_id = null, cname = null, ssd = null, sed = null;
                string dod = null;

                Double discount = 0, pa = 0;
                DateTime dt;
                if (i == true)
                {
                    se.service_duration = sd.Text;
                    dt = DateTime.Now;
                    ssd = dt.ToShortDateString();

                    sch_id = bs.bus_get_schemeid(se);
                    charges = bs.bus_get_charges(se);
                    if (se.service_duration == "3 months")
                    {
                        ccc = "QTR";
                        sed = dt.AddMonths(3).ToShortDateString();
                        discount = 0.03F * charges;
                    }
                    if (se.service_duration == "6 months")
                    {
                        ccc = "HLF";
                        sed = dt.AddMonths(6).ToShortDateString();
                        discount = 0.06F * charges;
                    }
                    if (se.service_duration == "12 months")
                    {
                        ccc = "YRL";
                        sed = dt.AddMonths(6).ToShortDateString();
                        discount = 0.1F * charges;
                    }

                    if (dt.Month == 12 || dt.Month == 1)
                    {
                        if (dt.Day == 1 || (dt.Day >= 25 && dt.Day <= 31))
                        {
                            discount = discount + 0.05F * pa;
                        }
                    }
                    pa = charges - discount;
                    yy = bs.bus_get_bookyear(se);
                    //dod = bs.bus_get_dod(se);
                    dod = bs.bus_get_dod(se);
                    se.regi_date = dod;
                    xx = bs.bus_get_sequential(se);
                    ser_id = ccc + "-" + xx.ToString() + "-" + yy;
                    cname = bs.bus_get_cname(se);
                    se.service_id = ser_id;
                    //se.cname = cname;
                    se.scheme_id = sch_id;
                    se.service_start_date = ssd;
                    se.service_end_date = sed;
                    se.discount = discount;
                    se.amount_payable = pa;
                    bs.bus_insert_SR(se);
                    Response.Cookies["ser_id"].Value = ser_id;
                    Response.Cookies["cname"].Value = cname;
                    Response.Cookies["sch_id"].Value = sch_id.ToString();
                    Response.Cookies["sd"].Value = se.service_duration;
                    Response.Cookies["ssd"].Value = ssd;
                    Response.Cookies["sed"].Value = sed;
                    Response.Cookies["charges"].Value = charges.ToString("F");
                    Response.Cookies["dis"].Value = discount.ToString("F");
                    Response.Cookies["pa"].Value = pa.ToString("F");
                    Response.Redirect("ser_csrs.aspx");
                }
                else
                {
                    rr1.Visible = true;
                }
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
                cid.Text = String.Empty;
                sd.Text = String.Empty;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}