using TFLCollection;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>();

employees.Add(new Employee (1, "Rohit", 15000));
employees.Add(new Employee (2,"Gaurav", 10000));
employees.Add(new Employee (3,"Nikhil",25000));

Console.WriteLine(" List of Employees Before Sort");
foreach(Employee emp in employees)
{
    Console.WriteLine(emp.id + " " + emp.name + " " + emp.salary);
}

EmpComparar ec = new EmpComparar();
employees.Sort(ec);

Console.WriteLine(" List of Employees After Sort");
foreach(Employee emp in employees)
{
    Console.WriteLine(emp.id + " " + emp.name + " " + emp.salary);
}
