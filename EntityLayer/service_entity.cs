using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Entity layer for servicing

namespace EntityLayer
{
    public class service_entity
    {
        public string cid
        {
            get;
            set;
        }
        public string service_duration
        {
            get;
            set;
        }

        public string service_id
        {
            get;
            set;
        }
        public string cname
        {
            get;
            set;
        }
              
        public int scheme_id
        {
            get;
            set;
        }
        public string service_start_date
        {
            get;
            set;
        }

        public string service_end_date
        {
            get;
            set;
        }
        public string service_charge
        {
            get;
            set;
        }
        public double discount
        {
            get;
            set;
        }
        public double amount_payable
        {
            get;
            set;
        }
        public string regi_date
        {
            get;
            set;
        }
    }
}
