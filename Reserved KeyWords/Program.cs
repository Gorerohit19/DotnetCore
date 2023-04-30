using Library;
using Referance;
using Array;
using SingletonDesignPattern;



/*
// Set the book value and get the book value
Book myBook = new Book();
myBook [2]="Rich dad Poor dad";
string title = myBook[2];

Console.WriteLine(title);

//Calling Defult Value
string title1 = myBook[3];
Console.WriteLine(title1);



int x = 10, y = 20;
Console.WriteLine("Before Swapping x="+x,"y="+y);
DemoClass.Swap(ref x, ref y);
Console.WriteLine("After Swapping x="+x,"y="+y);
float area, circum;
DemoClass.Calculate(5, out area, out circum);
Console.WriteLine("Area : {0}, Cicum : {1}", area, circum);


//Params
Test1.ViewNames("Rohit","Gaurav","Nikhil");
Test1.ViewNames("Sunday", "Monday", "tuesday","Wednesday","thursday","Friday","Saturday");
Test1.ViewNames("Rose","Lily","Merigold");
Test1.ViewNames("Iphone","Samsung","Xiaomi");


// Without Private class Initialization
Singleton obj1 = new Singleton();
obj1.MyMethod();
Singleton obj2 = new Singleton();
obj2.MyMethod();
//Screen Stop Karnya sati 
Console.ReadLine();
*/

//With Private class Initialization 
Singleton obj1 = Singleton.MyObject();
obj1.MyMethod();

