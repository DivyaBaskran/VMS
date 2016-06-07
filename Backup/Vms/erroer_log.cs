﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Bus_Layer;
using DataLayer;

namespace Vms
{
    public static class error_log
    {
       
        public static void LogError(Exception ex,string custommsg)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += string.Format("Custom Message: {0}",custommsg);
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);
            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            string path = System.Web.HttpContext.Current.Server.MapPath("~/Error_log/error_log.txt");

            //string path = Server.MapPath("~/ErrorLog/ErrorLog.txt");
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(message);
                writer.Close();
            }
        }

        internal static void LogError(Exception ex)
        {
            LogError(ex,"");
        }
    }
}