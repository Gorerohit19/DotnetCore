using Training;

Student std1 = new Student();
Student std2 = new Student(25, "Gaurav Desai","M.com");
Student std3 = new Student(60,"Nikhil Jambhulkar","BE","jambhulkar.nikhil@gmail.com");

Console.WriteLine(std1);
Console.WriteLine(std2);
Console.WriteLine(std3);



int noOfInstance =Student.GetCount();
Console.WriteLine(" Number of Instance of Student Class = {0}", noOfInstance);

Console.WriteLine("Hello, World!");
