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
    public partial class validate_cid : System.Web.UI.Page
    {
        Booking_entity book = new Booking_entity();
        bus_booking bookBal = new bus_booking();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool i;
                String s;
                s = TextBox1.Text;
                book.B_Id = TextBox1.Text;
                i = bookBal.bus_validate(book);
                if (i == true)
                {
                    List<string> li = new List<string>();
                    li = bookBal.display(book);
                    Session["cname"] = li[0];
                    Session["email"] = li[1];
                    Session["cont"] = li[2];
                    Session["Addr"] = li[3];
                    Session["pin"] = li[4];
                    Session["Mod_no"] = li[5];
                    Session["edod"] = li[6];
                    Session["B_ID"] = TextBox1.Text;
                    Response.Redirect("deli_warr.aspx");
                }
                if (i == false)
                {

                    Response.Redirect("false_booking.aspx");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}