namespace HR;

public class Manager:Employee
{
    private double bonus;
    private int stokeOption;

    public Manager(string fName, string lName, string email, string contactNumber, int id, string depatment, double basicSalary, double hra, 
                    double da, double bonus, int stocks): base (fName, lName, email, contactNumber, id, depatment, basicSalary, hra, da )
      {
           this.bonus=bonus;
           this.stokeOption=stocks;           
      }

    public override double ComputePay()
    {
        float profit = 0.7f;
        double salary = this.bonus +(stokeOption * profit) + base.ComputePay();
        return salary;
    }
}

