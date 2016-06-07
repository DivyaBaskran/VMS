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

//Data layer of servicing

namespace DataLayer
{
    public class dal_servicing
    {
        SqlCommand comm = null;
        SqlConnection con = null;
        SqlDataReader dr = null;

        //Getting a connection
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

        //Validating a customer ID
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


        //Getting a scheme ID
        public int dal_get_schemeid(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_scheme_id", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);


                object d = comm.ExecuteScalar();
                int s = Convert.ToInt32(d);
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Getting charges of a vehicle
        public int dal_get_charges(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_charges", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);


                object d = comm.ExecuteScalar();
                int s = Convert.ToInt32(d);
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting booking year of a vehicle
        public string dal_get_bookyear(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_bookyear", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                object d = comm.ExecuteScalar();
                String s = d.ToString();
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting a sequential
        public string dal_get_sequential(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_sequential", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                object d = comm.ExecuteScalar();
                String s = d.ToString();
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }


        //Getting a customer name
        public string dal_cname(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_cname", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                object d = comm.ExecuteScalar();
                String s = d.ToString();
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //For inserting in Table Service Registration
        public void dal_insert_SR(SqlParameter[] a)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_sr", con);
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

        //For getting the date of delivery
        public string dal_get_dod(SqlParameter g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("get_dod_cpd", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(g);
                object d = comm.ExecuteScalar();
                String s = d.ToString();
                return s;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
