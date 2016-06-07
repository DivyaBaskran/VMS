using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLayer;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

//Business layer for brerakdown servicing

namespace Bus_Layer
{
    public class bus_breakdown
    {
        dal_breakdown db = new dal_breakdown();

        //Getting a new breakdown ID
        public string bal_new_br_id()
        {
            try
            {
                SqlParameter a = new SqlParameter();
                int code;
                a = new SqlParameter("@new_id", SqlDbType.Int, 20);
                a.Direction = ParameterDirection.Output;
                code = db.dal_new_br_id(a);
                return "BR-" + code;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting a Model number of a vehicle
        public string bal_get_model(BreakDown_Entity be)
        {
            try
            {
                string t;
                SqlParameter g = new SqlParameter();
                g = new SqlParameter("@c_id", be.cid);
                t = db.dal_get_dod(g);
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting a Age of a vehicle
        public int bal_get_age(BreakDown_Entity be)
        {
            try
            {
                int t;
                SqlParameter g = new SqlParameter();
                g = new SqlParameter("@c_id", be.cid);
                t = db.dal_get_age(g);
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting price of a vehicle
        public long bal_get_price(string model)
        {
            try
            {
                long t;
                SqlParameter g = new SqlParameter();
                g = new SqlParameter("@mod", model);
                t = db.dal_get_price(g);
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Getting a Age of a vehicle
        public string bal_get_wed(BreakDown_Entity be)
        {
            try
            {
                string t;
                SqlParameter g = new SqlParameter();
                g = new SqlParameter("@c_id", be.cid);
                t = db.dal_get_wed(g);
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        //Inserting in BreakDown Table
        public void bal_insert_bdi(BreakDown_Entity be)
        {
            try
            {
                SqlParameter[] a = new SqlParameter[10];
                a[0] = new SqlParameter("@Br_Id", be.br_id);
                a[1] = new SqlParameter("@C_ID", be.cid);
                a[2] = new SqlParameter("@bdd", be.br_date);
                a[3] = new SqlParameter("@s_date", be.service_start_date);
                a[4] = new SqlParameter("@e_date", be.service_end_Date);
                a[5] = new SqlParameter("@bt", be.br_type);
                a[6] = new SqlParameter("@brd", be.br_details);
                a[7] = new SqlParameter("@dis", be.discount);
                a[8] = new SqlParameter("@ld", be.logged_date);
                a[9] = new SqlParameter("@charge", be.charges);
                db.dal_insert_bdi(a);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public bool bal_validate_cid(BreakDown_Entity be)
        {
            try
            {
                bool t;
                SqlParameter g = new SqlParameter();
                g = new SqlParameter("@c_id", be.cid);
                t = db.dal_validate_cid(g);
                return t;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
}
