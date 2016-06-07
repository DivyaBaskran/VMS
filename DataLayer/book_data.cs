using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using EntityLayer;
//Data Layer for Booking,Delivery & Warranty,Insurance

namespace DataLayer
{
    public class book_dal
    {
        SqlCommand comm = null;
        SqlConnection con = null;
        SqlDataReader dr = null;
        Booking_entity book_enobj = new Booking_entity();
        

        //For getting a connection between database & VS
        public void GetConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

//Booking
        //Inserting data in Booking Table  
        public void dal_booking1(SqlParameter[] a)
        {

            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_booking", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(a);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            
            
        }

        //For creating a new customer ID
        public int dal_newid(SqlParameter a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("newbook_id1", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(a);
                comm.ExecuteReader();
                int i = (int)a.Value;
                return i;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

//Delivery and Warranty details
        //For validating a Booking ID
        public bool dal_validate(SqlParameter q)
        {
            try
            {
                int flag;
                GetConnection();
                con.Open();
                comm = new SqlCommand("validate_bID", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(q);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
                bool l;
                l = Convert.ToBoolean(flag);
                return l;
                //comm.Parameters.Add(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For displaying data through pre-population in Delivery & warranty details
        public List<string> display(SqlParameter q)
        {
            try
            {
                List<string> li = new List<string>();
                GetConnection();
                con.Open();
                comm = new SqlCommand("validate_bID", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(q);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    li.Add(dr[0].ToString());
                    li.Add(dr[1].ToString());
                    li.Add(dr[2].ToString());
                    li.Add(dr[3].ToString());
                    li.Add(dr[4].ToString());
                    li.Add(dr[5].ToString());
                    li.Add(dr[6].ToString());

                }

                return li;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


       
      //For getting Date of Delivery of a vehicle
        public string dal_get_dod(SqlParameter q)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_dod", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(q);
                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@dod";
                outPutParameter.SqlDbType = System.Data.SqlDbType.Date;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                comm.Parameters.Add(outPutParameter);
                comm.ExecuteReader();
                DateTime Dt = Convert.ToDateTime(outPutParameter.Value.ToString());
                string d = Dt.ToShortDateString();
                return d;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For getting a new customer id
        public int dal_new_custid(SqlParameter a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("cust_id", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(a);
                comm.ExecuteReader();

                int i = (int)a.Value;
                return i;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For inserting a data customer_purchase_details
        public void dal_insert_cpd(SqlParameter[] a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_cpd", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(a);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

//iNSURANCE
        // For validating a customer id
        public bool dal_validate_custid(SqlParameter g)
        {
            try
            {
                int flag;
                GetConnection();
                con.Open();
                comm = new SqlCommand("validate_custid", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
                bool l;
                l = Convert.ToBoolean(flag);
                return l;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For displaying data through pre-population in Insurance
        public List<string> display1(SqlParameter g)
        {
            try
            {
                List<string> li = new List<string>();
                GetConnection();
                con.Open();
                comm = new SqlCommand("validate_custid", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    li.Add(dr[0].ToString());
                    li.Add(dr[1].ToString());
                    li.Add(dr[2].ToString());
                    li.Add(dr[3].ToString());
                }

                return li;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For gettin a new Policy ID
        public int dal_new_plcy(SqlParameter a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("policy_id", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(a);
                comm.ExecuteReader();
                int i = (int)a.Value;
                return i;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For inserting in service tracker
        public void dal_insert_st(SqlParameter[] a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_st", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(a);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For getting vehicle ID
        public int dal_get_vid(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_vid1", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                SqlParameter outPutParameter = new SqlParameter();
                outPutParameter.ParameterName = "@cn";
                outPutParameter.SqlDbType = System.Data.SqlDbType.Int;
                outPutParameter.Direction = System.Data.ParameterDirection.Output;
                comm.Parameters.Add(outPutParameter);
                comm.ExecuteReader();
                string t = outPutParameter.Value.ToString();
                int s = Convert.ToInt32(t);
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        //For inserting in vehicle details
        public void dal_inser_vd(SqlParameter[] a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_vd", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(a);
                comm.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
