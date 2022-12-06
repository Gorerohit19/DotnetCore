using MySql.Data.MySqlClient;

string conStr = "server=localhost; uid=root; password=Rohit@7378;database=classicmodels";

MySqlConnection con = new MySqlConnection();

try{
    con.ConnectionString=conStr;
    con.Open();

    string sql ="Select customerName, country from customers where country='USA' ";
    MySqlCommand cmd = new MySqlCommand(sql, con);
    MySqlDataReader rdr = cmd.ExecuteReader();

    while(rdr.Read()){
        Console.WriteLine(rdr[0]+"--"+rdr[1]);
    }
    rdr.Close();


}
catch(Exception e){
    Console.WriteLine(e.Message);
}
finally{
con.Close();
}