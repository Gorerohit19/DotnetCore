using System;
using System.Reflection;
using TFL;

/*

Reflection is a technique that allows us to retrieve metadata and 
information about an element, 
rather than the element itself. 
The most basic way to do reflection is to use the GetType() method,
 but we can also use reflection to get information about 
 methods, constructors, properties, and more.

*/

int myInt = 5;
Type type = myInt.GetType();
Console.WriteLine(type);

Assembly assembly = typeof(DateTime).Assembly;
Console.WriteLine(assembly);



ReflectedClass reflected = new ReflectedClass();
MemberInfo member = reflected.GetType().GetMethod("Add"); //Pass name of method
Console.WriteLine(member); //Output: Int32 Add(Int32, Int32)

/*
We can also get information about the defined property,
as well as information about the object's constructor, 
which will be the implicit public parameterless constructor 
since we did not define an explicit one.
*/

PropertyInfo property = reflected.GetType().GetProperty("Property1");
Console.WriteLine(property); //Output: System.String Property1

ConstructorInfo constructor = reflected.GetType().GetConstructor(new Type[0]);
Console.WriteLine(constructor); //Output: Void .ctor()

//Creating an instance using Reflection

ReflectedClass newReflected = new ReflectedClass();

var reflectedType = newReflected.GetType();

object newObject = Activator.CreateInstance(reflectedType);
Console.WriteLine(newObject); //_17AttributesAndReflection.ReflectedClass
