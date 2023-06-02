using HBGCollection;
using MobileCollection;
using System;
using System.Collections.Generic;

/*
List<int> marks = new List<int>();
marks.Add(96);
marks.Add(56);
marks.Add(75);

foreach(int number in marks)
{
    Console.WriteLine(number);
}

List<Student> allStudents = new List<Student>();
allStudents.Add(new Student{Id=12, Name="Rohit Gore", Location="Pune"});
allStudents.Add(new Student{Id=13, Name="Gaurav Desai", Location="Pune"});
allStudents.Add(new Student{Id=14, Name="Nikhil Jambhulkar", Location="Pune"});

Console.WriteLine(" List of HBG Students");
foreach(Student s in allStudents)
{
    Console.WriteLine(s);
}
*/

Console.WriteLine(" List of Mobiles");
List<Mobile> mobiles = new List<Mobile>();
mobiles.Add(new Mobile("Appale",14,"Iphone 14",129000));
mobiles.Add(new Mobile("Samsung",22,"S22", 100000));
mobiles.Add(new Mobile("Vivo",40,"X20",80000));
mobiles.Add(new Mobile("One+",11,"C2",25000));
mobiles.Add(new Mobile("Realme",27,"C22",30000));

foreach(Mobile mob in mobiles)
{
    Console.WriteLine(mob);
}

// Check the list for Model Number #10. This calls the IEquatable.Equals method
// of the Mobile class, which checks the ModelNumber for equality.
// Contains Code
Console.WriteLine("\n Contains (\"10\") : {0}",
mobiles.Contains(new Mobile {ModelNumber = 10, ModelName=""}));


 // Insert a new Mobile at position 3.
 Console.WriteLine("Insert (3,\"MobileCompany,ModelNumber,ModelName,Price");
mobiles.Insert(3, new Mobile(){MobileCompany="Moto", ModelNumber=30, ModelName="Egde", Price=24000});

// You have to Display List again for inserted new Item in List
foreach(Mobile mob in mobiles)
{
    Console.WriteLine(mob);
}
Console.WriteLine("New Mobile Moto is Added in List \n");


    // This will remove ModelNumber 40 even though the ModelName is different,
    // because the Equals method only checks ModelNumber for equality.
    mobiles.Remove(new Mobile(){MobileCompany="Vivo",ModelNumber=40,ModelName="X20",Price=80000});
     
     //Display Remove Mobile.
    foreach(Mobile mob in mobiles)
    {
        Console.WriteLine(mob);
    }

    Console.WriteLine("\RemoveAt(3)");
    // This Will Remove the Mobile at index 3
     mobile.RemoveAt(4);
    
    // Displaying Remove Item
    foreach(Mobile mob in mobiles)
    {
        Console.WriteLine(mob);
    }




    



        


