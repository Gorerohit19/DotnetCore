namespace TFLCollection;
public class Employee
{
    public int id;
    public string name;
    public float salary;

    public Employee(int i, string nm, float sal)
    {
        this.id=i;
        this.name=nm;
        this.salary=sal;
    }

    public override string ToString()
    {
        return this.id + " " + this.name + " " + this.salary;
    }

}