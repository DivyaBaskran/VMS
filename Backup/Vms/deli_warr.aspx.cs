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
    public partial class deli_warr : System.Web.UI.Page
    {
        Booking_entity book = new Booking_entity();
        bus_booking bookBal = new bus_booking();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                c_name.Text = Session["cname"].ToString();
                e_mail.Text = Session["email"].ToString();
                cont.Text = Session["cont"].ToString();
                addr.Text = Session["Addr"].ToString();
                pin.Text = Session["pin"].ToString();
                model.Text = Session["Mod_no"].ToString();
                dod.Text = Session["edod"].ToString();
                long chasis;
                Random rand = new Random();
                chasis = rand.Next(1000000, 9999999);
                cha.Text = chasis.ToString();
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
                string dod = null, wed;
                DateTime dt1, dt2, dt3, dt4, dt;
                string id = bookBal.bus_new_custid();
                book.C_Id = id;
                Response.Cookies["new_ID"].Value = id;
                book.B_Id = Session["B_ID"].ToString();
                dod = bookBal.bus_get_dod(book);
                Response.Cookies["dod"].Value = dod;
                wed = bookBal.bus_warraty_date(dod);
                Response.Cookies["wed"].Value = wed;
                dt = Convert.ToDateTime(dod);
                dt1 = dt.AddMonths(3);
                dt2 = dt1.AddMonths(3);
                dt3 = dt2.AddMonths(3);
                dt4 = dt3.AddMonths(3);
                book.cust_name = c_name.Text;
                book.email_id = e_mail.Text;
                book.contact = cont.Text;
                book.address = addr.Text;
                book.pincode = pin.Text;
                book.model_number = model.SelectedItem.Text;
                book.edod = Convert.ToDateTime(dod).Date;
                book.wed = Convert.ToDateTime(wed).Date;


                bookBal.bus_insert_cpd(book);
                book.dt1 = dt1;
                book.dt2 = dt2;
                book.dt3 = dt3;
                book.dt4 = dt4;
                bookBal.bus_insert_st(book.C_Id, book.dt1);
                bookBal.bus_insert_st(book.C_Id, book.dt2);
                bookBal.bus_insert_st(book.C_Id, book.dt3);
                bookBal.bus_insert_st(book.C_Id, book.dt4);
                int v_id;
                v_id = bookBal.bus_get_vid(book);
                book.vid = v_id;
                book.chasis = Convert.ToInt32(cha.Text);
                bookBal.bus_insert_vd(book);
                Response.Cookies["1_service"].Value = dt1.ToShortDateString();
                Response.Cookies["2_service"].Value = dt2.ToShortDateString();
                Response.Cookies["3_service"].Value = dt3.ToShortDateString();
                Response.Cookies["4_service"].Value = dt4.ToShortDateString();
                Response.Redirect("purchase_msg.aspx");
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
                c_name.Text = String.Empty;
                e_mail.Text = String.Empty;
                cont.Text = String.Empty;
                addr.Text = String.Empty;
                pin.Text = String.Empty;
                //model.Text = String.Empty;
                dod.Text = String.Empty;
                cha.Text = String.Empty;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }
    }
}