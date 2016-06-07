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
    public partial class bsrs : System.Web.UI.Page
    {
        BreakDown_Entity be = new BreakDown_Entity();
        bus_breakdown bb = new bus_breakdown();
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string break_id;
                be.cid = cid.Text;
                bool i;
                i = bb.bal_validate_cid(be);
                if (i == true)
                {
                    break_id = bb.bal_new_br_id();
                    //brd.Text = be.br_date.ToString();
                    be.br_date = DateTime.ParseExact(brd.Text, "dd-MM-yyyy", null, DateTimeStyles.None).Date;
                    //ssd.Text = be.service_start_date.ToString();
                    be.service_start_date = DateTime.ParseExact(ssd.Text, "dd-MM-yyyy", null, DateTimeStyles.None).Date;
                    be.br_type = bds.Text;
                    be.br_details = bdd.Text;
                    Response.Cookies["Cid"].Value = be.cid;
                    Response.Cookies["ser_id"].Value = break_id;
                    Response.Cookies["Service_start"].Value = be.service_start_date.ToString();

                    string sed = null, dow = null, model, wed;
                    Int64 price;
                    DateTime dt, dt1;
                    int ag, bsc = 0;
                    float discount = 0, sc = 0;
                    sed = Request.Cookies["Service_start"].Value;
                    dt1 = Convert.ToDateTime(sed);
                    dt = Convert.ToDateTime(sed).AddDays(3);
                    be.service_end_Date = Convert.ToDateTime(dt.ToShortDateString());
                    be.service_end_Date = be.service_end_Date.Date;
                    dow = be.service_end_Date.DayOfWeek.ToString();
                    {
                        if (dow == "Sunday")
                        {
                            dt = dt.AddDays(1);
                            be.service_end_Date = Convert.ToDateTime(dt.ToShortDateString());
                            be.service_end_Date = be.service_end_Date.Date;
                        }
                    }
                    Response.Cookies["sed1"].Value = be.service_end_Date.ToShortDateString();
                    be.cid = Request.Cookies["Cid"].Value;
                    model = bb.bal_get_model(be);
                    wed = bb.bal_get_wed(be);
                    price = bb.bal_get_price(model);
                    ag = bb.bal_get_age(be);
                    if (ag > 0 && ag < 3)
                    {
                        sc = 0;
                    }
                    if (ag > 12)
                    {
                        sc = 0.10F * price;
                    }
                    if (ag >= 3 && ag < 6)
                    {
                        if (price < 300000 && price > 100000)
                        {
                            sc = 0.03F * price;
                        }
                        if (price < 500000 && price >= 300000)
                        {
                            sc = 0.04F * price;
                        }
                        if (price > 500000)
                        {
                            sc = 0.05F * price;
                        }

                    }
                    if (ag >= 6 && ag < 9)
                    {
                        if (price < 300000 && price > 100000)
                        {
                            sc = 0.04F * price;
                        }
                        if (price < 500000 && price >= 300000)
                        {
                            sc = 0.05F * price;
                        }
                        if (price > 500000)
                        {
                            sc = 0.06F * price;
                        }
                    }
                    if (ag >= 9 && ag <= 12)
                    {
                        if (price < 300000 && price > 100000)
                        {
                            sc = 0.05F * price;
                        }
                        if (price < 500000 && price >= 300000)
                        {
                            sc = 0.06F * price;
                        }
                        if (price > 500000)
                        {
                            sc = 0.07F * price;
                        }
                    }
                    if (Convert.ToDateTime(wed) > Convert.ToDateTime(sed))
                    {
                        if (price < 300000 && price > 100000)
                        {
                            discount = 0.07F * price;
                        }
                        if (price < 500000 && price >= 300000)
                        {
                            discount = 0.10F * price;
                        }
                        if (price > 500000)
                        {
                            discount = 0.15F * price;
                        }
                    }

                    if (bds.Text == "Engine Failure")
                    {
                        bsc = 2000;
                    }
                    if (bds.Text == "Tyre/Tube leakage")
                    {
                        bsc = 150;
                    }
                    if (bds.Text == "Battery dead/Not charging")
                    {
                        bsc = 200;
                    }
                    if (bds.Text == "Peripheral Damages")
                    {
                        bsc = 2000;
                    }
                    if (bds.Text == "Wind screen broken/Cracked")
                    {
                        bsc = 8000;
                    }

                    if (bds.Text == "Radiator damage")
                    {
                        bsc = 1000;
                    }
                    double charges = bsc + sc;
                    Response.Cookies["cid"].Value = be.cid;
                    Response.Cookies["bdd"].Value = be.br_date.ToShortDateString();
                    Response.Cookies["ssd"].Value = be.service_start_date.ToShortDateString();
                    Response.Cookies["bt"].Value = be.br_type;
                    Response.Cookies["bd"].Value = be.br_details;
                    Response.Cookies["ld"].Value = DateTime.Now.Date.ToString();
                    Response.Cookies["charges"].Value = charges.ToString("F");
                    Response.Cookies["bsc"].Value = bsc.ToString();
                    Response.Cookies["sc"].Value = sc.ToString();
                    Response.Cookies["discount"].Value = discount.ToString();
                    Response.Redirect("csrs.aspx");
                }
                else
                {
                    rr.Visible = true;
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
                brd.Text = String.Empty;
                ssd.Text = String.Empty;
                bdd.Text = String.Empty;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}