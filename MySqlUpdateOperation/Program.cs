using System.Data;
using MySql.Data.MySqlClient;


string conStr = "server=localhost; uid=root; password=Rohit@7378; database=demo1";
MySqlConnection con = new MySqlConnection(conStr);

try{
    con.Open();
    string query = "update employee set EmpAge=22, EmpDept=Electric where EmpId=1";
    MySqlCommand cmd = new MySqlCommand(query, con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while(rdr.Read()){
        Console.WriteLine(rdr[0]+"--"+rdr[1]+"--"+rdr[2]+"--"+rdr[3]);
    }
    rdr.Close();
}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
    con.Close();
}