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
    public partial class plc_confirmed : System.Web.UI.Page
    {
        Booking_entity book = new Booking_entity();
        bus_booking bookBal = new bus_booking();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                p_id.Text = Session["new_pid"].ToString();
                DateTime dt;
                dt = DateTime.Now;
                issue_date.Text = dt.ToShortDateString();
                issue_date2.Text = dt.ToShortDateString();
                issue_date3.Text = dt.AddYears(1).ToShortDateString();
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}