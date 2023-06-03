using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDbTest;
public class DisplayManager
{
    public static void ShowManu()
    {
        Console.WriteLine("Transflower Option :\n");
        Console.WriteLine();
        Console.WriteLine("Choose Option : \n");
        Console.WriteLine("0.Exist");
        Console.WriteLine("1.List Of Student");
        Console.WriteLine("2.Insert Student Information");
        Console.WriteLine("3.Update Student Information");
        Console.WriteLine("4.Delete Student Information");
    }

    public static void ShowAllCollection()
    {
        List<Student> students = UIManager.GetallStudent();
        foreach(Student theStudent in students)
        {
            Console.WriteLine(theStudent.Id +" "+ theStudent.studentFirstName +" "+ theStudent.studentLastName
                              +" "+ theStudent.email +" "+ theStudent.location);
        }
    }
}