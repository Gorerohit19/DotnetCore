using Ecommerce;
using GDI;
using HR;

Shape theShape=new Shape();
Shape theShape2=new Shape("Yellow");

string objColor=theShape.Getcolor();
string obj2Color=theShape2.Getcolor();
Console.WriteLine(" First Object Colour = {0}", objColor);
Console.WriteLine(" Second Object Colour = {0}", obj2Color);

Console.WriteLine(" Terminating Application");

Line l1=new Line();
Console.WriteLine(l1.ToString());

Point pt1=new Point();
pt1.X=19;
pt1.Y=68;

Point pt2=new Point();
pt2.X=100;
pt2.Y=36;

Line l2=new Line(pt1,pt2,"green");
Console.WriteLine(l2.ToString());


Employee mgr1 = new Manager("Rohit","Gore","gore.rohit@gmail.com","7378982802",19,"Selles",5000,2000,200,1500,100);
Employee mgr2 = new Manager("Gaurav","Desai","desaigaurav@gmail.com","8888314096",25,"Marketing",3000,1000,100,2000,50);

//Polymorphism is working 

//even if you call method against parent class reference , still object is pointing to Derived Class

double mgr1Salary=mgr1.ComputePay();
double mgr2Salary=mgr2.ComputePay();

Console.WriteLine(" First Manager Salary = {0}", mgr1Salary);
Console.WriteLine(" Second Manager Salary = {0}", mgr2Salary);