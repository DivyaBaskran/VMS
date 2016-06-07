using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityLayer;
using System.IO;

namespace Vms
{
    public class Activity_log
    {
        Activity ac = new Activity();
        public void inf(Activity ac)
        {
            //string mesg = string.Format("Log in :{0}", elog.login.ToString("dd/MM/yyyy hh:mm:ss tt"));
            string message = "-----------------------------------------------------------";
            message += Environment.NewLine;
            if (ac.login != DateTime.MinValue)
            {
                message += string.Format("Log in Time: {0}", ac.login.ToString("dd/MM/yyyy hh:mm:ss tt"));//time stamp
            }
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("UserID: {0}", ac.username);//error message
            message += Environment.NewLine;
            if (ac.userreg != DateTime.MinValue)
            {
                message += string.Format("userreg time: {0}", ac.userreg);
                message += Environment.NewLine;
            }
            else
            {
                message += string.Format("userreg time:none");
                message += Environment.NewLine;
            }

            if (ac.booking != DateTime.MinValue)
            {
                message += string.Format("booking time: {0}", ac.booking);
                message += Environment.NewLine;
            }
            else
            {
                message += string.Format("booking time:none");
                message += Environment.NewLine;
            }

            if (ac.deli_warr != DateTime.MinValue)
            {
                message += string.Format("Purchase time: {0}", ac.deli_warr);
                message += Environment.NewLine;
            }
            else
            {
                message += string.Format("Purchase time:none");
                message += Environment.NewLine;
            }

            if (ac.insurance != DateTime.MinValue)
            {
                message += string.Format("Insurance time: {0}", ac.insurance);
                message += Environment.NewLine;
            }
            else
            {
                message += string.Format("Insurance time:none");
                message += Environment.NewLine;
            }

            if (ac.break_down != DateTime.MinValue)
            {
                message += string.Format("Break Down Service time: {0}", ac.break_down);

            }
            else
            {
                message += string.Format("Break Down Service time:: none");

            }

            message += Environment.NewLine;
            message += string.Format("Activity: {0}", ac.activity);
            message += Environment.NewLine;
            message += string.Format("Client IP: {0}", ac.ip);
            message += Environment.NewLine;
            message += string.Format("Server: {0}", ac.server);
            message += Environment.NewLine;
            message += string.Format("Logout Time: {0}", ac.logout.ToString("dd/MM/yyyy hh:mm:ss tt"));//error source
            message += Environment.NewLine;
            //message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
            //message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            string path = HttpContext.Current.Server.MapPath("~/Activity log/Activity.txt");
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                //File.SetAttributes("~/logfolder/activitylog.txt", FileAttributes.ReadOnly);
                writer.Close();
            }

        }

       


        public void inf(string p, DateTime dateTime)
        {
            string message = "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Login time: {0}", dateTime.ToString("dd/MM/yyyy hh:mm:ss tt"));//time stamp
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("User Name: {0}", p);//error message
            message += Environment.NewLine;
            string path = HttpContext.Current.Server.MapPath("~/Activity log/Activity.txt");
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                //File.SetAttributes("~/logfolder/activitylog.txt", FileAttributes.ReadOnly);
                writer.Close();
            }
        }
    }
}