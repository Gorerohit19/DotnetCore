using AuthenticationApp.Models;
using MySql.Data.MySqlClient;
namespace AuthenticationApp.Repositories;
public class UserRepository:IUserRepository{
    public static string conString="server=localhost;port=3306;user=root;password=password;database=simpledb";

    public bool ValidateUser(User user){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            string query="SELECT EXISTS(SELECT * FROM users where ContactNumber='"+user.ContactNumber+"' and OTP='"+user.OTP+"')";
            con.Open();
            MySqlCommand command=new MySqlCommand(query,con);
            MySqlDataReader reader=command.ExecuteReader();
            reader.Read();
            if((Int64)reader[0]==1){
                status=true;
            }
            reader.Close();
        }
        catch(Exception e){
            throw e;
        }
        finally{
            con.Close();
        }

        return status;

    }

}