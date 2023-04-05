using Ecommerce;

namespace HR;

public class Employee:Person
{
    protected int id;
    protected string depatment;
    protected double basicSalary;
    protected double hra;
    protected double da;


public Employee()
{}

public Employee(string fName, string lName, string em, string contact, int id, string depatment, double bSal, double hra, double da) : base(fName, lName, em, contact)
{
    this.id=id;
    this.depatment=depatment;
    this.basicSalary=bSal;
    this.hra=hra;
    this.da=da;
}

public virtual double ComputePay()
{
  double salary = this.basicSalary + this.hra +(da*25);
  return salary;
}

}