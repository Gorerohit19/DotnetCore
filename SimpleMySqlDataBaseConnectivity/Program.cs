using MySql.Data.MySqlClient;

string conStr = "server=localhost; uid=root; password=;database=classicmodels";

MySqlConnection con = new MySqlConnection();

try {
    con.ConnectionString=conStr;
    con.Open();
    string query = "select * from employees";
    MySqlCommand cmd = new MySqlCommand(query, con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while(rdr.Read()){
        Console.WriteLine(rdr[0]+":"+rdr[1]+":"+rdr[2]+":"+rdr[4]);
        Console.WriteLine(rdr["employeeNumber"]+":"+rdr["lastName"]+":"+rdr["firstName"]+":"+rdr["email"]);
    }
    rdr.Close();

}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
 con.Close();
}