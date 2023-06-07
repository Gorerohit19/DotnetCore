using MySql.Data.MySqlClient;

  namespace HR{

  public class Employees
 {

  public static string connectionStr = "server =localhost; uid=root ; password = root; port =3306; database = Tap";
    

 public static void ShowAll()
 {
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString=connectionStr;
        
        try 
          {
           string query =" SELECT * FROM employees";
           con.Open();
           MySqlCommand cmd = new MySqlCommand(query,con);
           MySqlDataReader rdr =cmd.ExecuteReader();
              while (rdr.Read()){
                System.Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]+"--"+rdr[4]+"--"+rdr[5]);
                }
               rdr.Close();
               

          }
        catch(Exception e)
        {
           System.Console.WriteLine("Exception :" +e.Message);
        }
        finally
        {
          con.Close();
        }
    }
       public static void ShowById ()
       {
           MySqlConnection con = new MySqlConnection();
           con.ConnectionString= connectionStr;

           try {
               System.Console.WriteLine("  Enter Employee Id");
               int id = Convert.ToInt32(Console.ReadLine());
               string query =" SELECT * FROM employees Where empId ="+id;
               con.Open();
               MySqlCommand cmd= new MySqlCommand(query,con);
               MySqlDataReader rdr = cmd.ExecuteReader();
               while(rdr.Read())
                {
                  System.Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]+"--"+rdr[4]+"--"+rdr[5]);
                }
               rdr.Close();
           }
           catch(Exception e)
           {
            System.Console.WriteLine("Exception :"+ e.Message);
           }
          finally 
          {
            con.Close();
          }

       }
   
    public static bool InsertEmployees()
    {
      bool status =false;

      MySqlConnection con =new MySqlConnection();
      con.ConnectionString=connectionStr;
        
          try 
          {
            
             System.Console.WriteLine("Insert Values in EmployeesTable");
             System.Console.WriteLine("Enter Employee FirstName");
             string empFirstName =Console.ReadLine();
             System.Console.WriteLine(":Enter Employee LastName");
             string empLastName=Console.ReadLine();
             System.Console.WriteLine(": Enter Employee Email");
             string  Email =Console.ReadLine();
             System.Console.WriteLine(": Enter Employee Address ");
             string EmpAdd= Console.ReadLine();
             System.Console.WriteLine(":Enter Employee DepId");
             int deptId= Convert.ToInt32(Console.ReadLine());

             string query = "Insert into Employees (empFirstName,empLastName,empEmail,empAddress, deptId) Values( '"+empFirstName+"','"
             + empLastName+"','"+Email+"','"+EmpAdd+"','"+deptId+"')";
             MySqlCommand cmd = new MySqlCommand(query,con);
             con.Open();
             cmd.ExecuteNonQuery();

           status = true;
          }
          catch (Exception e)
          {
            System.Console.WriteLine("Exception:"+e.Message);
          }
          finally 
          {
            con.Close();
          }
          return status;

   }

 public static bool UpdateEmployeeDetails()
 {
      bool status = false;

      MySqlConnection con= new MySqlConnection();
      con.ConnectionString =connectionStr;

      try 
      {
      
            
             System.Console.WriteLine("Update Values in EmployeesTable");
             int id =Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("Update Employee FirstName");
             string empFirstName =Console.ReadLine();
             System.Console.WriteLine(":Update Employee LastName");
             string empLastName=Console.ReadLine();
             System.Console.WriteLine(": Update Employee Email");
             string  Email =Console.ReadLine();
             System.Console.WriteLine(": Update Employee Address ");
             string EmpAdd= Console.ReadLine();
             System.Console.WriteLine(":Update  Employee DepId");
             int deptId= Convert.ToInt32(Console.ReadLine());

             string query = "Update Employees SET empFirstName ='"+empFirstName+"',"+"empLastName ='"+empLastName+"',"+"empEmail='"+Email+"',"+
                            "empAddress='"+ EmpAdd+"',"+"deptId="+deptId + 
                            " WHERE empId ="+id;

             MySqlCommand cmd = new MySqlCommand(query,con);
             con.Open();
             cmd.ExecuteNonQuery();
             status=true;
       }
       catch (Exception e )
           {
             System.Console.WriteLine("Exception:" +e.Message);
           }
       finally 
           {
              con.Close ();
            }
       return status;

 }
public static bool DeleteEmployeeDetails()
{
     bool status =false;

     MySqlConnection con= new MySqlConnection();
     con.ConnectionString=connectionStr;

     try 
     {
       System.Console.WriteLine(" Enter Employee Id :");

        int id = Convert.ToInt32(Console.ReadLine());
        string query =" DELETE FROM Employees WHERE empId ="+id;
 
       MySqlCommand cmd = new MySqlCommand(query,con);
       con.Open();
       cmd.ExecuteNonQuery();
       status =true;
       
     }
     catch(Exception ee )
     {
      System.Console.WriteLine("Exception :"+ ee.Message);
     }
     finally
     {
      con.Close();

     }
 return status;
  }
   }
   }




﻿
