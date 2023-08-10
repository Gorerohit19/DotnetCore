using System;
using OverLoading;
using OverRiding;

// 1) Methode Overloading Example
// Calculator cal = new Calculator();
// // Int
// cal.Add(7,7);
// //Double
// cal.Add(10,12);

//2) Operator OverLoading Example
// int x = 5;
// int y = 5;
// int sum = x + y;
// Console.WriteLine("Operator Overloading.."+sum);

// // OverRiding 
// // obj1 is the object of Polygon class
        Polygon obj1 = new Polygon();

//         // calls render() method of Polygon Superclass 
        obj1.render();

//         // here, obj1 is the object of derived class Square 
        obj1 = new Square();

//         // calls render() method of derived class Square
        obj1.render();