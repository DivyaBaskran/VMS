using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

//Business Layer for Booking,Delivery & warranrty,Insurance
namespace Bus_Layer
{
   public class bus_booking
    {
       book_dal bookdal = new book_dal();
     
       //For inserting data in Booking Table
       public void bus_booking1(Booking_entity book)
       {
           try
           {
               SqlParameter[] a = new SqlParameter[9];
               a[0] = new SqlParameter("@Booking_Id", book.B_Id);
               a[1] = new SqlParameter("@Customer_name", book.cust_name);
               a[2] = new SqlParameter("@Email_Id", book.email_id);
               a[3] = new SqlParameter("@Contact", book.contact);
               a[4] = new SqlParameter("@Address", book.address);
               a[5] = new SqlParameter("@Pincode", book.pincode);
               a[6] = new SqlParameter("@Model_No", book.model_number);
               a[7] = new SqlParameter("@Date_of_Booking", book.dob);
               a[8] = new SqlParameter("@Expected_Date_of_Delivery", book.edod);
               bookdal.dal_booking1(a);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
          
       }

       //booking module
       //For getting new Booking ID
       public string bus_newid()
       {
           try
           {
               SqlParameter a = new SqlParameter();
               int code;
               a = new SqlParameter("@new_id", SqlDbType.Int, 20);
               a.Direction = ParameterDirection.Output;
               code = bookdal.dal_newid(a);
               return "VEH-" + code;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }
      
       //For getting Expected date of delivery
       public String expected_dob(string p,string t)
       {
           try
           {
               string l1 = null;
               DateTime k = DateTime.Parse(p);
               if (t == "SUZK-0004")
               {
                   DateTime l = k.AddMonths(4);
                   l1 = l.ToString();
                   return l1;
               }
               else
               {
                   DateTime l = k.AddMonths(2);
                   l1 = l.ToString();
               }
               return l1;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
           
        }

       //DELI_WARR MODULE

       // For validating a booking ID
       public bool bus_validate(Booking_entity book)
       {
           try
           {
               bool t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@B_id", book.B_Id);
               t = bookdal.dal_validate(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For displaying data through pre-population in Delivery & warranty details
       public List<string> display(Booking_entity book)
       {
           try
           {
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@B_id", book.B_Id);
               List<string> li = new List<string>();
               li = bookdal.display(g);
               return li;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting a new customer ID
       public string bus_new_custid()
       {
           try
           {
               SqlParameter a = new SqlParameter();
               int code;
               a = new SqlParameter("@new_id", SqlDbType.Int, 20);
               a.Direction = ParameterDirection.Output;
               code = bookdal.dal_new_custid(a);
               return "CUS-" + code;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting a warranty DATE
       public string bus_warraty_date(string p)
       {
           try
           {
               DateTime dt, dt1;
               dt = Convert.ToDateTime(p);
               dt1 = dt.AddYears(1);

               return dt1.ToShortDateString();
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       // Getting date of delivery
       public string bus_get_dod(Booking_entity book)
       {
           try
           {
               string t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@b_id", book.B_Id);
               t = bookdal.dal_get_dod(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }

       }

       //Inserting data into customer purchase details
       public void bus_insert_cpd(Booking_entity book)
       {
           try
           {
               SqlParameter[] a = new SqlParameter[9];
               a[0] = new SqlParameter("@Customer_Id", book.C_Id);
               a[1] = new SqlParameter("@Customer_name", book.cust_name);
               a[2] = new SqlParameter("@Email_Id", book.email_id);
               a[3] = new SqlParameter("@Contact", book.contact);
               a[4] = new SqlParameter("@Address", book.address);
               a[5] = new SqlParameter("@Pincode", book.pincode);
               a[6] = new SqlParameter("@Model_No", book.model_number);
               a[7] = new SqlParameter("@Date_of_Delivery", book.edod);
               a[8] = new SqlParameter("@Warranty_expiry_date", book.wed);
               bookdal.dal_insert_cpd(a);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //Insurance Module
       //Validating new customer id
       public bool bus_validate_custid(Booking_entity book)
       {
           try
           {
               bool t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", book.C_Id);
               t = bookdal.dal_validate_custid(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For displaying data through pre-population in Insurance
       public List<string> display1(Booking_entity book)
       {
           try
           {
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", book.C_Id);
               List<string> li = new List<string>();
               li = bookdal.display1(g);
               return li;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For creating new policy iD
       public string bus_new_plcy(Booking_entity book)
       {
           try
           {
               SqlParameter a = new SqlParameter();
               int code;
               a = new SqlParameter("@new_pid", SqlDbType.Int, 20);
               a.Direction = ParameterDirection.Output;
               code = bookdal.dal_new_plcy(a);
               return "PLCY-" + code;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

      
       //Inserting data in Service tracker table
       public void bus_insert_st(string p, DateTime dateTime)
       {
           try
           {
               SqlParameter[] a = new SqlParameter[2];
               a[0] = new SqlParameter("@Customer_Id", p);
               a[1] = new SqlParameter("@dt1", dateTime);
               bookdal.dal_insert_st(a);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //Getting a new vehicle ID
       public int bus_get_vid(Booking_entity book)
       {
           try
           {
               int t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", book.C_Id);
               t = bookdal.dal_get_vid(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //Inserting data in Vehicle details table
       public void bus_insert_vd(Booking_entity book)
       {
           try
           {
               SqlParameter[] a = new SqlParameter[3];
               a[0] = new SqlParameter("@vid", book.vid);
               a[1] = new SqlParameter("@cid", book.C_Id);
               a[2] = new SqlParameter("@chasis", book.chasis);
               bookdal.dal_inser_vd(a);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }
    }
}
