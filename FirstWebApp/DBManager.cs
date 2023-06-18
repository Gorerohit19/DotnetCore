namespace BOL;

public class DBManager
{
    public static Product GetById(int id)
    {
        Product product =new Product{Id =id, Title="Moto-G", Description="Flip and Slim", UnitPrice=25000, Quntity=120};
        return product;  
    }
    
}