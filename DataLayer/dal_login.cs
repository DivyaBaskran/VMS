using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Web;

namespace DataLayer
{
    public class dal_login
    {
        SqlCommand comm = null;
        SqlConnection con = null;
        SqlDataReader dr = null;
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

        //validating 
        public bool get_validation(System.Data.SqlClient.SqlParameter[] g)
        {
            bool l;
            int flag=0;
            try
            {
                
                GetConnection();
                con.Open();
                comm = new SqlCommand("login_validation", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(g);
                dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
               }
                l = Convert.ToBoolean(flag);
                return l;
                                      
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
           
        }
        
        //Insertion in login table
        public void dal_insert_login(SqlParameter[] g)
        {
            try
            {
                GetConnection();
                con.Open();
                comm = new SqlCommand("insert_login", con);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddRange(g);
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
