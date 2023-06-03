using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MongoDbTest;

public class StudentDBManager
{
    protected static IMongoClient client;

    protected static IMongoDatabase database;

    public static Student GetStudent()
    {
        Console.WriteLine("Please Enter Student First Name :");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please Enter Student Last Name :");
        string lastName = Console.ReadLine();

        Console.WriteLine("Please Enter Student Email :");
        string email = Console.ReadLine();

        Console.WriteLine("Please Enter Student Contact Number :");
        string contactNumber = Console.ReadLine();

        Console.WriteLine("Please Enter Student Location");
        string location = Console.ReadLine();

        Student student = new Student()
        {
            studentFirstName = firstName,
            studentLastName = lastName,
            email = email,
            contactNumber = contactNumber,
            location = location
        };
        return student;
    }
    public static List<Student> GetAllStudent()
    {
        List<Student> students = new List<Student>();
        client = new MongoClient();  
        database = client.GetDatabase("transflower");  
        var collection = database.GetCollection<Student>("tapstudent");
        return students;
    }
}