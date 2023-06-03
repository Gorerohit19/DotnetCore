using System;
//MongoDB.Driver  
using MongoDB.Bson;  
using MongoDB.Driver; 

namespace StudentsMongodbCRUDTest
{   
    public class Student  
    {  
        public ObjectId Id { get; set; }  
        public string studentFirstName { get; set; }  
        public string studentLastName { get; set; }  
        public string email { get; set; }  
        public string contactNumber { get; set; }  
        public string location {get; set;}
    }  
    public class Program
    {
        protected static IMongoClient client;  
        protected static IMongoDatabase database;  

        public static Student GetStudent()  
        {  
            Console.WriteLine("Please enter Student first name : ");  
            string firstName = Console.ReadLine();  
  
            Console.WriteLine("Please enter Student last name : ");  
            string lastName = Console.ReadLine();  
  
            Console.WriteLine("Please enter Student Email : ");  
            string email = Console.ReadLine();  
  
            Console.WriteLine("Please enter Student Contact Number : ");  
            string contactNumber = Console.ReadLine(); 

            Console.WriteLine("Please enter Student Location : ");  
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
        
        public static void CRUDwithMongoDb()  
        {  
            client = new MongoClient();  
            database = client.GetDatabase("transflower");  
            var collection = database.GetCollection<Student>("tapstudent");  
  
            Console.WriteLine("Press select your option from the following\n1 - Insert\n2 - UpdateOne Document\n3 - Delete\n4 - Read All\n");  
            string userSelection = Console.ReadLine();  
  
            switch (userSelection)  
            {  
                case "1":   
                    //Insert  
                    collection.InsertOne(GetStudent());  
                    break;  
  
                case "2":   
                    //Update  
                    var obj1 = GetStudent();  
  
                    collection.FindOneAndUpdate<Student>  
                        (   Builders<Student>.Filter.Eq("studentFirstName", obj1.studentFirstName),  
                            Builders<Student>.Update.Set("studentLastName", obj1.studentLastName).Set("email", obj1.email).Set("contactNumber", obj1.contactNumber).Set("location",obj1.location));  
                    break;  
  
                case "3":   
                    //Find and Delete  
                    Console.WriteLine("Please Enter the first name to delete the record(so called document) : ");  
                    var deletefirstName = Console.ReadLine();  
                    collection.DeleteOne(s => s.studentFirstName == deletefirstName);  
                    break;  
  
                case "4":   
                    //Read all existing document  
                    var all = collection.Find(new BsonDocument());  
                    Console.WriteLine();  
  
                    foreach (var i in all.ToEnumerable())  
                    {  
                        Console.WriteLine(i.Id + "  " + i.studentFirstName + "\t" + i.studentLastName + "\t" + i.email + "\t" + i.contactNumber + "\t" + i.location);  
                    }  
                    break;  
  
                default:  
                    Console.WriteLine("Please choose a correct option");  
                    break;  
            }  
  
            //To continue with Program  
            Console.WriteLine("\n--------------------------------------------------------------\nPress Y for continue...\n");  
            string userChoice = Console.ReadLine();  
  
            if (userChoice == "Y" || userChoice == "y")  
            {  
                CRUDwithMongoDb();  
            }  
        }  

        static void Main(string[] args)
        {
            CRUDwithMongoDb();   
            Console.WriteLine("Hello World!");
        }
    }
}
