using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
using System.Web;





namespace Bus_Layer
{
    public class bus_login
    {
       
        dal_login dl = new dal_login();
        public bool get_validation(EntityLayer.login_entity le)
        {
            bool t=false;
            try
            {
            
            SqlParameter[] g = new SqlParameter[2];
            g[0] = new SqlParameter("@un", le.username);
            g[1] = new SqlParameter("@pass", le.password);
            t = dl.get_validation(g);
           // return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
             
            }
            return t;

        }
       
   
        

        //For getting a connection between database & VS


        public void bus_insert_login(login_entity le)
        {
            SqlParameter[] g = new SqlParameter[2];
            g[0] = new SqlParameter("@un", le.username);
            g[1] = new SqlParameter("@pass", le.password);
            dl.dal_insert_login(g);
            
        }
    }
}
