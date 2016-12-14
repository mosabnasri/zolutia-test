using System;

namespace OH.Models.DataBase
{
    public class Helpers 
    {
        public static void BugReport(Exception ex)
        {
            try
            {
                //string errorText = Ernst.Security.Crypting.GenerateErrorLine(ex);
                //string errorText = ex.Source + Environment.NewLine + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine;
                //if (!System.IO.File.Exists("Reports.err"))
                //{
                //    using (System.IO.StreamWriter sw = System.IO.File.CreateText("Reports.err"))
                //    {
                //        sw.Write(errorText);
                //        sw.Close();
                //    }
                //}

                //using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Reports.err", true))
                //{
                //    sw.Write(errorText);
                //    sw.Close();
                //}
            }
            catch { }
        }
        public static void BugReport(string error_message)
        {
            try
            {
                ////string errorText = Ernst.Security.Crypting.GenerateErrorLine(ex);
                //string errorText = error_message + Environment.NewLine;
                //if (!System.IO.File.Exists("Reports.err"))
                //{
                //    using (System.IO.StreamWriter sw = System.IO.File.CreateText("Reports.err"))
                //    {
                //        sw.Write(errorText);
                //        sw.Close();
                //    }
                //}

                //using (System.IO.StreamWriter sw = new System.IO.StreamWriter("Reports.err", true))
                //{
                //    sw.Write(errorText);
                //    sw.Close();
                //}
            }
            catch { }
        }
    }
}
