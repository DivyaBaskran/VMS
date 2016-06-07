using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

//Business layer of module Servicing
namespace Bus_Layer
{
   public class bal_servicing
    {
       dal_servicing ds = new dal_servicing();

       //This will validate the customer ID
       public bool bus_validate_custid(service_entity se)
       {
           try
           {
               bool t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", se.cid);
               t = ds.dal_validate_custid(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting the scheme id of the customer
       public int bus_get_schemeid(service_entity se)
       {
           try
           {
               int t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@sd", se.service_duration);
               t = ds.dal_get_schemeid(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting the service charges
       public int bus_get_charges(service_entity se)
       {
           try
           {
               int t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@sd", se.service_duration);
               t = ds.dal_get_charges(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting the booking year of the vehicle
       public string bus_get_bookyear(service_entity se)
       {
           try
           {
               string t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", se.cid);
               t = ds.dal_get_bookyear(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting the sequential number of service ID
       public string bus_get_sequential(service_entity se)
       {
           try
           {
               string t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", se.cid);
               t = ds.dal_get_sequential(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       ////For getting the customer name
       public string bus_get_cname(service_entity se)
       {
           try
           {
               string t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", se.cid);
               t = ds.dal_cname(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For inserting in Table Service Registration
       public void bus_insert_SR(service_entity se)
       {
           try
           {
               SqlParameter[] a = new SqlParameter[8];
               a[0] = new SqlParameter("@Br_Id", se.service_id);
               a[1] = new SqlParameter("@C_ID", se.cid);
               a[2] = new SqlParameter("@Sch_Id", se.scheme_id);
               a[3] = new SqlParameter("@s_date", se.service_start_date);
               a[4] = new SqlParameter("@e_date", se.service_end_date);
               a[5] = new SqlParameter("@dis", se.discount);
               a[6] = new SqlParameter("@ap", se.amount_payable);
               a[7] = new SqlParameter("@Date_of_Delivery", se.regi_date);
               ds.dal_insert_SR(a);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }

       //For getting the date of delivery
       public string bus_get_dod(service_entity se)
       {
           try
           {
               string t;
               SqlParameter g = new SqlParameter();
               g = new SqlParameter("@C_id", se.cid);
               t = ds.dal_get_dod(g);
               return t;
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);

           }
       }
    }
}
