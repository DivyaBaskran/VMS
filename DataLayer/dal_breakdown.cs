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

//Data layer for break down servicing 
namespace DataLayer
{
    public class dal_breakdown
    {
        SqlCommand comm = null;
        SqlConnection con = null;
        SqlDataReader dr = null;

        //For getting a connection
        public void GetConnection()
        {
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Generating a new breakdown ID
        public int dal_new_br_id(SqlParameter a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("new_br_id", con);
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

        //Getting date of delivery of a vehicle
        public string dal_get_dod(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_model_number", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);

                object d = comm.ExecuteScalar();
                string s = (string)d;
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
          
        }

        //Getting age of a vehicle
        public int dal_get_age(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("calculate_age", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);

                object d = comm.ExecuteScalar();
                int s = (int)d;
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Getting price of a vehicle
        public long dal_get_price(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_price", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                
                object d = comm.ExecuteScalar();
                long s = (long)d;
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Getting warranty expiry date 
        public String dal_get_wed(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_wed", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                object d = comm.ExecuteScalar();
                DateTime dt = (DateTime)d;
                string s = dt.Date.ToString();
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Inserting Data in Break Down Table
        public void dal_insert_bdi(SqlParameter[] a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_bdi", con);
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

        //Validating a Customer Id
        public bool dal_validate_cid(SqlParameter g)
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
    }
}
