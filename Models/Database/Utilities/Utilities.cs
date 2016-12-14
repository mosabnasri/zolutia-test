using System;
//using System.Web.Hosting;

namespace OH.Models.DataBase
{
    public class Utitlities 
    {
        public static object Get_Null_Or_Value(object value)
        {
            return value != null ? value : DBNull.Value;
        }
    }
}
