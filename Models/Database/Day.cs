using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace WebApplication.Models.DataBase
{
    public partial class Day
    {
		public int Id { get; set; }
		public int Number { get; set; }
		public DateTime Date { get; set; }
		public int Creation_User_Id { get; set; }
		public DateTime Creation_Date { get; set; }
		public Nullable<int> Close_User_Id { get; set; }
		public Nullable<DateTime> Close_Date { get; set; }
		public bool Is_Sent { get; set; }
		public Nullable<DateTime> Send_Date { get; set; }
        public Nullable<bool> Is_Current { get; set; }
		public bool Is_Blocked { get; set; }

        public Day() { }

   //     public Day(DataRow dr)
   //     {
			//Id = int.Parse(dr["Id"].ToString());
			//Number = int.Parse(dr["Number"].ToString());
			//Date = (DateTime)dr["Date"];
			//Creation_User_Id = int.Parse(dr["Creation_User_Id"].ToString());
			//Creation_Date = (DateTime)dr["Creation_Date"];
			//Close_User_Id = (dr["Close_User_Id"] == System.DBNull.Value) ? (int?)null : Convert.ToInt32(dr["Close_User_Id"]);
			//Close_Date = (dr["Close_Date"] == System.DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr["Close_Date"]);
			//Is_Sent = Convert.ToBoolean(dr["Is_Sent"].ToString());
   //         Send_Date = (dr["Send_Date"] == System.DBNull.Value) ? (DateTime?)null : Convert.ToDateTime(dr["Send_Date"]);
			//Is_Current = (dr["Is_Current"] == System.DBNull.Value) ? (Boolean?)null : Convert.ToBoolean(dr["Is_Current"]); 
			//Is_Blocked = Convert.ToBoolean(dr["Is_Blocked"].ToString());
   //     }
    }
}

