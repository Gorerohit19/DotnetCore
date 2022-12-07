using MySql.Data.MySqlClient;
namespace DAL;

public static class MySqlDBManager{
   public static string conStr="server=localhost;uid=root;password=Rohit@7378;port=3306;database=demo1";
   
   public static bool CreateTable(){

    bool status = false;
    MySqlConnection con = new MySqlConnection();
    con.ConnectionString = conStr;

    try{
        string query = "create table cars (carId int not null primary key auto_increment,"+
                        "carCompany varchar(25),"+
                        "modelName varchar(25),"+
                        "price decimal(10,2)"+
                        ")";
        Console.WriteLine(query);
        MySqlCommand cmd = new MySqlCommand(query, con);
        con.Open();
        cmd.ExecuteNonQuery();
        status = true;
    }
    catch(Exception e){
        Console.WriteLine("Exception :"+e.Message);
    }
    finally{
        con.Close();
    }
    return status;
   }

    public static bool Insert(string carCompany, string modelName, double price)
    {
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conStr;
        con.Open();
        try{
            string query = "insert into cars (carCompany, modelName, price) values('"+carCompany+
                            "','"+modelName+"','"+price+"')";
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            Console.WriteLine("Exception :"+e.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }

    public static bool Update(int id, string carCompany, string modelName, double price){
        bool status = false;
        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conStr;

        try{
            string query = "update cars set carCompany='"+carCompany+"',"+
                            "modelName='"+modelName+"',"+
                            "price="+price+
                            " where carId="+id;
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            Console.WriteLine("Exception ="+e.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }

    public static bool Delete(int id){
        bool status = false;

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conStr;
        try{
            string query = "delete from cars where carId="+id;
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            status = true;
        }
        catch(Exception e){
            Console.WriteLine("Exception ="+e.Message);
        }
        finally{
            con.Close();
        }
        return status;
    }

    public static void ShowAllCars(){
        MySqlConnection con = new MySqlConnection();
        try{
            con.ConnectionString = conStr;
            con.Open();
            string query = "select * from cars";
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read()){
                Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]);
            }
            rdr.Close();
        }
        catch(Exception e){
            Console.WriteLine("Exception :"+e.Message);
        }
        finally{
            con.Close();
        }
    }

     public static void ShowCarById(int id){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        try{
            con.ConnectionString=conStr;
            con.Open();
            string query = "SELECT * FROM cars WHERE carId="+id;
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
                {
                    Console.WriteLine(rdr["carId"]+"***" + rdr["carCompany"]+" -- "+rdr["modelName"]+" -- "+rdr["price"]+"')");
                    status=true;
                }
                rdr.Close();
            }
        catch(Exception ee){
            Console.WriteLine("Exception :  "+ee.Message);
        }

        finally{
            con.Close();
        }

}
}