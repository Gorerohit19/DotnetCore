using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

string conStr = "server=localhost; uid=root; password=Rohit@7378; database=demo1";
MySqlConnection con = new MySqlConnection(conStr);

try{
    con.Open();
    string query = "insert into employee (EmpId, EmpName, EmpAge, EmpDept) values(5,'Rohan', 20, 'Sales')";
    MySqlCommand cmd = new MySqlCommand(query, con);
    cmd.ExecuteNonQuery();

}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    con.Close();
}

