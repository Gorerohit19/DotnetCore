using System;
using System.Data;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DisconnectedTest;

public class DeparmentDBManger
{
    public static string connectionStr = "server=localhost; userid=root; password=Rohit@7378; port=3306; database=transflower";

    public static List<Department> GetAllDepartment()
    {
        List<Department> departments = new List<Department>();

        IDbConnection con = new MySqlConnection();
        con.ConnectionString = connectionStr;

        string query = "SELECT * FROM departments";
        MySqlCommand cmd = new MySqlCommand(query,con as MySqlConnection);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        try
        {
           da.Fill(ds);
           DataTable dt = ds.Tables[0];
           foreach(DataRow datarow in dt.Rows)
           {
             int id = int.Parse(datarow["id"].ToString());
             string name = datarow["name"].ToString();
             string location = datarow["location"].ToString();

             Department dept = new Department{
                Id =id,
                Name = name,
                Location = location,
             };
             departments.Add(dept);
           }
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return departments; 
    }

    public static Department GetDepartmetById(int deptid)
    {
        Department department = null;
        List<Department> departments = new List<Department>();
        IDbConnection con = new MySqlConnection();
        con.ConnectionString = connectionStr;

        string query = "SELECT * FROM departments WHERE id="+ deptid;
        MySqlCommand cmd = new MySqlCommand(query, con as MySqlConnection);

        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        try
        {
            da.Fill(ds);
            DataTable dt = ds.Tables[0];

            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = dt.Columns["id"];
            dt.PrimaryKey = keycolumns;

            DataRow dataRow = ds.Tables[0].Rows.Find(deptid);

            int id = int.Parse(dataRow["id"].ToString());
            string name = dataRow["name"].ToString();
            string location = dataRow["location"].ToString();

            department = new Department{
                Id=id,
                Name=name,
                Location=location,
            };   
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return department;
    }

    public static List<Department> GetByLocation(string deptlocation)
    {
        List<Department> departments = new List<Department>();
        Department department = null;

        IDbConnection con = new MySqlConnection(connectionStr);

        string query = "SELECT * FROM departments WHERE location="+ deptlocation;
        MySqlCommand cmd = new MySqlCommand(query, con as MySqlConnection);
        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(da);
        try
        {
            da.Fill(ds);

            DataTable dt = ds.Tables["departments"];
            foreach(DataRow dataRow in dt.Rows)
            {
                int id = int.Parse(dataRow["id"].ToString());
                string name = dataRow["name"].ToString();
                string location = dataRow["location"].ToString();
                department = new Department{
                Id=id,
                Name=name,
                Location=location,
                };
            departments.Add(department);
            }
            
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return departments;
    }

    public static Department GetByDepartmentId(int deptid)
    {
        Department department = null;

        IDbConnection con = new MySqlConnection(connectionStr);
        IDbCommand cmd = new MySqlCommand();
        cmd.CommandText = "SELECT * FROM departments WHERE id=@ID";

        MySqlParameter param = new MySqlParameter();
        param.DbType = DbType.Int16;
        param.Value = deptid;
        param.ParameterName = "@ID";

        cmd.Parameters.Add(param);
        cmd.Connection = con;

        MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
        DataSet ds = new DataSet();

        try
        {
            da.Fill(ds);

            DataTable dt = ds.Tables["departments"];
            foreach(DataRow dataRow in dt.Rows)
            {
                int id = int.Parse(dataRow["id"].ToString());
                string name = dataRow["name"].ToString();
                string location = dataRow["loaction"].ToString();

                department = new Department{
                    Id=id,
                    Name=name,
                    Location=location,
                };
            }
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return department;
    }

    public static bool Insert(Department newdepartment)
    {
        bool status = false;

        IDbConnection con = new MySqlConnection();
        con.ConnectionString = connectionStr;

        string cmdstr = "SELECT * FROM departments";
        IDbCommand cmd = new MySqlCommand();
        
        cmd.Connection = con as MySqlConnection;
        cmd.CommandText = cmdstr;

        MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
        DataSet ds = new DataSet();

        try
        {
            MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(da);
            MySqlCommand deleteCommand = cmdbuilder.GetDeleteCommand();
            string strDeleteCommand = deleteCommand.CommandText;

            da.Fill(ds);

            DataRow newRow = ds.Tables[0].NewRow();
            newRow["id"] = newdepartment.Id;
            newRow["name"] = newdepartment.Name;
            newRow["location"] = newdepartment.Location;

            ds.Tables[0].Rows.Add(newRow);
            da.Update(ds);
            status = true ;
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return status;
    }

    public static bool Update(Department thedept)
    {
        bool status = false;

        List<Department> departments = new List<Department>();
        IDbConnection con = new MySqlConnection();
        con.ConnectionString = connectionStr;

        IDbCommand cmd = new MySqlCommand();
        cmd.CommandText = "SELECT * FROM departments";
        cmd.Connection = con;

        MySqlDataAdapter da = new MySqlDataAdapter();
        DataSet ds = new DataSet();

        try
        {
            MySqlCommandBuilder cmdbuilder = new MySqlCommandBuilder(da);
            da.Fill(ds);

            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = ds.Tables[0].Columns["id"];
            ds.Tables[0].PrimaryKey = keycolumns;

            DataRow dataRow = ds.Tables[0].Rows.Find(thedept.Id);
            dataRow["name"] = thedept.Name;
            dataRow["location"] = thedept.Location;

            da.Update(ds);
        }
        catch(MySqlException exp)
        {
            string exceptionMessage = exp.Message;
        }
        return status;
    }
     public static bool Delete(int deptId)
        {
            bool status = false;

            IDbConnection con = new MySqlConnection();
            con.ConnectionString = connectionStr;
            
            IDbCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM departments";
            cmd.Connection = con;
            
            MySqlDataAdapter da = new MySqlDataAdapter(cmd as MySqlCommand);
            DataSet ds = new DataSet();

            try
            {
                MySqlCommandBuilder cmdbldr = new MySqlCommandBuilder(da);
                da.Fill(ds);

                DataColumn[] keyColumns = new DataColumn[1];
                keyColumns[0] = ds.Tables[0].Columns["Id"];
                ds.Tables[0].PrimaryKey = keyColumns;

                DataRow datarow = ds.Tables[0].Rows.Find(deptId);
                datarow.Delete();
                da.Update(ds);
            }

            catch (MySqlException exp)
            {
                string exceptionMessage = exp.Message;
            }
            return status;
        }
}

 


