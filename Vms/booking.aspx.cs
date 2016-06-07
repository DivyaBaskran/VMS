using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bus_Layer;
using EntityLayer;
using System.Globalization;

//UI layer for Booking,Delivery & Warranty,Insurance
namespace Vms
{
    public partial class booking : System.Web.UI.Page
    {
        Booking_entity book = new Booking_entity();
        bus_booking bookBal = new bus_booking();
        Activity_log al = new Activity_log();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["uname"] != null)
                {


                }
                else
                {
                    Response.Redirect("login.aspx");
                }
               
                String s;
                s = DateTime.Now.ToShortDateString();
                DateTime dt;
                
                
                //dt = DateTime.ParseExact(s, "yyyy-MMM-dd", CultureInfo.InvariantCulture);
                dt = Convert.ToDateTime(s);
                dob.Text = s;
                book.dob = DateTime.Now;
                // bookBal.expected_dob(dob.Text);
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
                book.cust_name = c_name.Text;
                book.email_id = e_mail.Text;
                book.contact = contact.Text;
                book.address = address.Text;
                book.pincode = pin.Text;
                book.model_number = model_no.SelectedItem.Text;
                // book.dob = Convert.ToDateTime(date_box.Text);

                string id = bookBal.bus_newid();
                book.B_Id = id;



                string e_dod1;
                e_dod1 = bookBal.expected_dob(dob.Text, book.model_number);

                book.edod = Convert.ToDateTime(e_dod1);

                bookBal.bus_booking1(book);
                Response.Cookies["new_ID"].Value = id;
                Response.Cookies["dod"].Value = book.edod.ToShortDateString();
                Response.Redirect("booking_msg.aspx");
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
                c_name.Text = String.Empty;
                e_mail.Text = String.Empty;
                contact.Text = String.Empty;
                address.Text = String.Empty;
                pin.Text = String.Empty;
                model_no.Text = String.Empty;
            }
            catch (Exception ex)
            {
                error_log.LogError(ex);

            }
        }

        
    }
}