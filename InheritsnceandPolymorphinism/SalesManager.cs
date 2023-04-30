namespace HR;

public class SalesManager:SalesEmployee
{
    public double Bonus {get; set;}

    public SalesManager():base()
    {

    }

    public SalesManager(string fName, string lName, DateTime bDate, int id, string em, string contact, 
                     double bSal, double da, int a, double incen, double bonus ):base(fName, lName, bDate, id, em, contact, bSal, da, a, incen)
   {
    this.Bonus=bonus;
   }

    public override double ComputePay()
    {
        return base.ComputePay()+ Bonus;
    }

    public override string ToString()
    {
        return base.ToString()+ "Bonus ="+ Bonus;
    }
}