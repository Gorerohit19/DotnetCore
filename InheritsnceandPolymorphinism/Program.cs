using GDI;
using HR;

Shape shape = new Line();
shape.Draw();

Point pt1 = new Point{ X=45, Y=60};
Point pt2 = new Point{ X=50, Y=25};
string theColor = "White";

Shape shape2 = new Line(pt1, pt2, theColor);

shape2.Draw();

 Person thePerson=new Person();
 Person thePerson1=new Person("Akhilesh","Patil",new DateTime(2000,02,11));
 Console.WriteLine(thePerson);
 Console.WriteLine(thePerson1);

 Employee emp=new Employee("Nikhil","Jambhulkar",new DateTime(1999,06,15),16,"nikhil.jambhulkar@gmail.com","9822113667",5000,200,20);
 Employee emp1=new Employee();
 Console.WriteLine(emp);
 Console.WriteLine(emp1);

Employee theEmployee=new Employee("Shubham","Patil",new DateTime (2000,02,11),30,"patil.shubham@gmail.com","9932145698",3000,200,21);
double employee=theEmployee.ComputePay();

Console.WriteLine(" The Employee Salary is ="+ employee);

Employee theEmployee1 = new SalesEmployee("Aman","Lavande",new DateTime(1998,7,13),45,"lavande.aman@gail.com","8967501236",3000,200,18,2000);
double employee2=theEmployee1.ComputePay()+theEmployee.ComputePay();

Console.WriteLine("The SalesEmployee Salary ="+employee2);

SalesEmployee objManger = new SalesManager("Tanmay","Dhavde",new DateTime(1989,04,14),20,"tanmay.dhavde@gmail.com","9912334566",45000,1000,26,5000,10000);
SalesEmployee theManager = new SalesManager("Tanmay","Dhavde",new DateTime(1989,04,14),20,"tanmay.dhavde@gmail.com","9912334566",45000,1000,26,5000,10000);
double mgr=theEmployee.ComputePay()+theEmployee1.ComputePay()+theManager.ComputePay();

Console.WriteLine("The Manager Salary ="+mgr);