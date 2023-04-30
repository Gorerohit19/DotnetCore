using System;

namespace AnnonymousTypeTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Program theProgram = new Program();
      Console.WriteLine("Demo Of Reflection");
      Type theType1=theProgram.GetType();
      Console.WriteLine("Type of Program:"+theType1.Name);
      var instance = new {
                          Id=19, FirstName="Rohit", LastName="Gore",
                          EmailId="gorerohit@gmail.com",
                          ContactNumber="7378982802",
                          Location = new {
                                          LandMark="Jagtap Chowk",
                                          City="Pune",
                                          State="Maharashtra",
                                          Country="India"
                                         }
                          };
      Type theType2=instance.GetType();
      Console.WriteLine("Type of Instance:"+theType2.Name);

      Console.WriteLine("Demo of Annonymous Data Type ...");
      Console.WriteLine(instance.Id+" "+instance.FirstName+" "+instance.LastName);
      Console.WriteLine(instance.Location.Country);
      Console.WriteLine(instance.Location.State);
      Console.WriteLine(instance.Location.City);
      Console.WriteLine(instance.Location.LandMark);
    }
  }
}
