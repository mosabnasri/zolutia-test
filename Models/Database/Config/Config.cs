using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace OH.Models.DataBase
{
    public class Config 
    {
        public static string ServerIP { get; set; }
        private static bool DebugMode = false;
        
        public static string GetConnectionString()
        {
            return @"Server=ec2-23-21-224-106.compute-1.amazonaws.com;"
                + "User Id=thfmyblczjywvg;"
                + "Password=5bcf7daf7c1e39bfd2cb52a77333572510127a844ad00e6b57a9dda80e3469b1;"
                + "Database=dbg14nkg3vu2ha";
        }

        public static bool GetDebugMode()
        {
            return DebugMode;
        }
    }
}
