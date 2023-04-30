namespace HR;

public class SalesEmployee:Employee
{
   public double Incentive {get; set;}

   public SalesEmployee():base()
   {

   }

   public SalesEmployee(string fName, string lName, DateTime bDate, int id, string em, string contact, 
                     double bSal, double da, int a, double incen):base(fName, lName, bDate, id, em, contact, bSal, da, a)
                     {
                        this.Incentive=incen;
                     }


    public override double ComputePay()
    {
        return base.ComputePay() + this.Incentive;
    }

/*
    //Shadowing technique
    //Hides the base class member in derived class by using keyword new
    public new double ComputePay()
    {
      return base.ComputePay()+ Insentive;
    }
*/

public override string ToString()
{
   return base.ComputePay()+ "Incentive ="+ Incentive;
}
   
}