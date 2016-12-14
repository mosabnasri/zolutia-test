using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Npgsql;

namespace WebApplication.Models.DataBase
{
    public partial class Day
    {
        public class Access
        {
            public static int Count()
            {
                try
                {
                    NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
                    cnn.Open();

                    //var connString = "Server=192.168.99.100;User Id=pipeline;Password=pipeline;Database=pipeline";
                    //var conn = new NpgsqlConnection { ConnectionString = connString };
                    cnn.Open();
                    var sql = "SELECT COUNT(*) FROM Day";
                    var cmd = cnn.CreateCommand();
                    cmd.CommandText = sql;
                    var count = cmd.ExecuteScalar();
                    cnn.Close();

                    return (int)count;
                }
                catch (Exception Ex)
                {
                    if (OH.Models.DataBase.Config.GetDebugMode())
                    {
                        throw;
                    }
                    else
                    {
                        OH.Models.DataBase.Helpers.BugReport(Ex);
                    }
                    return -1;
                }
            }

            #region Default Methods
            //public static Day Get(int Id)
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "SELECT * FROM Day WHERE Id=@Id";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);
            //        cmd.Parameters.AddWithValue("Id", Id);
            //        NpgsqlDataReader SelectAdapter = new NpgsqlDataReader(cmd);

            //        cnn.Close();

            //        DataTable dt = new DataTable();
            //        SelectAdapter.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            return new Day(dt.Rows[0]);
            //        }
            //        else
            //        {
            //            return null;
            //        }
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return null;
            //    }
            //}

            //public static List<Day> Get()
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "SELECT * FROM Day";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);
            //        NpgsqlDataAdapter SelectAdapter = new NpgsqlDataAdapter(cmd);

            //        cnn.Close();

            //        DataTable dt = new DataTable();
            //        SelectAdapter.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            return Helpers.GetListFromDataTable(dt);
            //        }
            //        else
            //        {
            //            return new List<Day>();
            //        }
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return null;
            //    }
            //}

            //public static List<Day> Get(List<int> LIds)
            //{
            //    if (LIds != null && LIds.Count > 0)
            //    {
            //        try
            //        {
            //            NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //            cnn.Open();


            //            NpgsqlCommand cmd = new NpgsqlCommand();
            //            cmd.Connection = cnn;

            //            string queryIds = string.Empty;
            //            for (int i = 0; i < LIds.Count; i++)
            //            {
            //                queryIds += "@Id" + i + ",";
            //                cmd.Parameters.AddWithValue("Id" + i, LIds[i]);
            //            }
            //            queryIds = queryIds.TrimEnd(',');

            //            string query = "SELECT * FROM Day WHERE Id IN (" + queryIds + ")";
            //            cmd.CommandText = query;

            //            NpgsqlDataAdapter SelectAdapter = new NpgsqlDataAdapter(cmd);

            //            cnn.Close();

            //            DataTable dt = new DataTable();
            //            SelectAdapter.Fill(dt);
            //            if (dt.Rows.Count > 0)
            //            {
            //                return Helpers.GetListFromDataTable(dt);
            //            }
            //            else
            //            {
            //                return new List<Day>();
            //            }
            //        }
            //        catch (Exception Ex)
            //        {
            //            if (OH.Models.DataBase.Config.GetDebugMode())
            //            {
            //                throw;
            //            }
            //            else
            //            {
            //                OH.Models.DataBase.Helpers.BugReport(Ex);
            //            }
            //            return null;
            //        }
            //    }
            //    return null;
            //}

            //public static int Add(Day T)
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "INSERT INTO Day(Number,Date,Creation_User_Id,Creation_Date,Close_User_Id,Close_Date,Is_Sent,Send_Date,Is_Current,Is_Blocked)  VALUES (@Number,@Date,@Creation_User_Id,@Creation_Date,@Close_User_Id,@Close_Date,@Is_Sent,@Send_Date,@Is_Current,@Is_Blocked)";

            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);
            //        cmd.Parameters.AddWithValue("Number", T.Number);
            //        cmd.Parameters.AddWithValue("Date", T.Date);
            //        cmd.Parameters.AddWithValue("Creation_User_Id", T.Creation_User_Id);
            //        cmd.Parameters.AddWithValue("Creation_Date", T.Creation_Date);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Close_User_Id", T.Close_User_Id);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Close_Date", T.Close_Date);
            //        cmd.Parameters.AddWithValue("Is_Sent", false);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Send_Date", T.Send_Date);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Is_Current", T.Is_Current);
            //        cmd.Parameters.AddWithValue("Is_Blocked", T.Is_Blocked);

            //        int InsertedID = cmd.ExecuteNonQuery();

            //        if (InsertedID > 0)
            //        {
            //            query = "SELECT last_insert_id()";
            //            cmd = new NpgsqlCommand(query, cnn);
            //            object _InsertedID = cmd.ExecuteScalar();

            //            if (_InsertedID != null)
            //            {
            //                InsertedID = int.Parse(_InsertedID.ToString());
            //            }
            //            else
            //            {
            //                InsertedID = -1;
            //            }
            //        }
            //        else
            //        {
            //            InsertedID = -1;
            //        }

            //        cnn.Close();

            //        return InsertedID;
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return -1;
            //    }
            //}
            #endregion

            //#region Custom Methods
            //public static Day Get_Current_Day()
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();
                    
            //        string query = "SELECT * FROM Day WHERE Is_Current=@Is_Current";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Is_Current", true);
            //        NpgsqlDataAdapter SelectAdapter = new NpgsqlDataAdapter(cmd);

            //        cnn.Close();

            //        DataTable dt = new DataTable();
            //        SelectAdapter.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //        {
            //            return new Day(dt.Rows[0]);
            //        }
            //        else
            //        {
            //            return null;
            //        }
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return null;
            //    }
            //}

            //public static int Set_Sent(int Id)
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "UPDATE Day SET Is_Sent=@Is_Sent WHERE Id=@Id";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);

            //        cmd.Parameters.AddWithValue("Id", Id);
            //        cmd.Parameters.AddWithValue("Is_Sent", true);

            //        int r = cmd.ExecuteNonQuery();

            //        cnn.Close();

            //        return r;
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return -1;
            //    }
            //}

            //public static int Set_Blocked(int Id)
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "UPDATE Day SET Is_Blocked=@Is_Blocked WHERE Id=@Id";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);

            //        cmd.Parameters.AddWithValue("Id", Id);
            //        cmd.Parameters.AddWithValue("Is_Blocked", true);

            //        int r = cmd.ExecuteNonQuery();

            //        cnn.Close();

            //        return r;
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return -1;
            //    }
            //}

            //public static int Set_Closed(int Id, int Close_User_Id)
            //{
            //    try
            //    {
            //        NpgsqlConnection cnn = new NpgsqlConnection(OH.Models.DataBase.Config.GetConnectionString());
            //        cnn.Open();

            //        string query = "UPDATE Day SET Is_Sent=@Is_Sent, Is_Blocked=@Is_Blocked, Close_User_Id=@Close_User_Id, Close_Date=@Close_Date, Is_Current=@Is_Current WHERE Id=@Id";
            //        NpgsqlCommand cmd = new NpgsqlCommand(query, cnn);

            //        cmd.Parameters.AddWithValue("Id", Id);
            //        cmd.Parameters.AddWithValue("Is_Sent", false);
            //        cmd.Parameters.AddWithValue("Is_Blocked", true);
            //        cmd.Parameters.AddWithValue("Close_User_Id", Close_User_Id);
            //        cmd.Parameters.AddWithValue("Close_Date", DateTime.Now);
            //        cmd = Helpers.AddNullableWithValue(cmd, "Is_Current", DBNull.Value);

            //        int r = cmd.ExecuteNonQuery();

            //        cnn.Close();

            //        return r;
            //    }
            //    catch (Exception Ex)
            //    {
            //        if (OH.Models.DataBase.Config.GetDebugMode())
            //        {
            //            throw;
            //        }
            //        else
            //        {
            //            OH.Models.DataBase.Helpers.BugReport(Ex);
            //        }
            //        return -1;
            //    }
            //}
            //#endregion

            //#region Helpers
            //public class Helpers
            //{
            //    public static List<Day> GetListFromDataTable(DataTable dt)
            //    {
            //        List<Day> L = new List<Day>(dt.Rows.Count);
            //        foreach (DataRow dr in dt.Rows)
            //        { L.Add(new Day(dr)); }
            //        return L;
            //    }

            //    public static NpgsqlCommand AddNullableWithValue(NpgsqlCommand cmd, string name, object value)
            //    {
            //        if (null != value)
            //            cmd.Parameters.AddWithValue(name, value);
            //        else
            //            cmd.Parameters.AddWithValue(name, DBNull.Value);

            //        return cmd;
            //    }
            //}
            //#endregion
        }
    }
}
