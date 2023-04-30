namespace HR;

public class Employee:Person
{
    public int EmpId {get; set;}
    public string Email {get; set;}
    public string ContactNumber {get; set;}

    protected double BasicSalary {get; set;}

    protected double DailyAllowance {get; set;}

    protected int Attendance {get; set;}

    public Employee():base()
    {

    }

    public Employee(string fName, string lName, DateTime bDate, int id, string em, string contact, 
                     double bSal, double da, int a):base(fName, lName, bDate)
    {
        this.Email=em;
        this.ContactNumber=contact;
        this.BasicSalary=bSal;
        this.DailyAllowance=da;
        this.Attendance=a;
    }

   public virtual double ComputePay()
   {
     double salary = BasicSalary + DailyAllowance * Attendance;
     return salary;
   }

    public override string ToString()
    {
        return base.ToString() +this.Email +" "+ this.ContactNumber +" "+ this.BasicSalary +" " + this.DailyAllowance +" "
                      + this.Attendance; 
    }


}