using Accounding;

public class Transaction : Creditable, Debitable
{
    public void Deposite()
    {
        Console.WriteLine("Amount is added into shoppers account");
    }

    public void Withdraw()
    {
        Console.WriteLine("Amount is Withdrawn from consumers shoppers account");
    }
}