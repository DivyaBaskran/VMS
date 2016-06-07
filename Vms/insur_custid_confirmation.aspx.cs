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
    public partial class insur_custid_confirmation : System.Web.UI.Page
    { 
       Booking_entity pie=new Booking_entity();
        bus_booking bins=new bus_booking();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool i;
                String s;
                s = cust_id.Text;
                pie.C_Id = cust_id.Text;
                i = bins.bus_validate_custid(pie);
                if (i == true)
                {
                    List<string> li = new List<string>();
                    li = bins.display1(pie);
                    Session["cname"] = li[0];
                    Session["pid"] = li[1];
                    Session["psd"] = li[2];
                    Session["Addr"] = li[3];
                    Response.Redirect("Insurance.aspx");
                }
                if (i == false)
                {

                    Response.Redirect("false_insurance.aspx");
                }
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
        }
    }
