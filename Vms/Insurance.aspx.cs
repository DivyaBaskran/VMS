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
    public partial class Insurance : System.Web.UI.Page
    {
        Booking_entity book = new Booking_entity();
        bus_booking bookBal = new bus_booking();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                cname.Text = Session["cname"].ToString();
                pid.Text = Session["pid"].ToString();
                psd.Text = Session["psd"].ToString();
                adds.Text = Session["addr"].ToString();
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
                String p_newid = bookBal.bus_new_plcy(book);
                Session["new_pid"] = p_newid;
                Response.Redirect("plc_confirmed.aspx");
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                cname.Text = String.Empty;
                pid.Text = String.Empty;
                psd.Text = String.Empty;
                adds.Text = String.Empty;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

       
    }
}