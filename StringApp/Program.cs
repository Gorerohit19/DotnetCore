using System.Text;
using System.Collections.Generic;

/*
//Declearing  String
string str1;

//Declearing And Initializing String
string str2= " Hello World";
string str3= "Welcome to CSharp";

//Initializing Empty String
string str4 = String.Empty;

//Initializing Null String
string str5 = null;


//Creating String From Charatures
char[] letters = { 'A', 'B', 'C', 'D'};
string str6 =new string(letters);

Console.WriteLine(str6);


//C# string Literal (Regular, Vervatim)
string names = "Rohit\nGaurav\nNikhil";
Console.WriteLine(names);

string msg = "Welcom to \"TransFlower\" World";
Console.WriteLine(msg);

//Verbatim string is Created using special symbol @
//Following is an example of using verbatim literal @ in c# programming language to represent a multiline string and
// a file path.
string path = @"C:\Users\admin\HandsOn\StringApp";
Console.WriteLine(path);

string msg2 = @"Hi,
My name is Rohit
I'm Learning Dotnet core";
Console.WriteLine(msg2);

string msg3 = @"Im living in pune";
Console.WriteLine(msg3);

//C# Formate For Strings
string name = "Rohit";
string location ="Pune";
string user = string.Format(" Name:{0}, Location:{1}", name, location);
Console.WriteLine(user);


//C# Access Individual Characters from Strings
string name1 ="Rohit Gore";
for(int i =0; i< name.Length; i++)
{
    Console.WriteLine(name1[i]);
}

//Following is the example declaring and initializing strings, formatting string value, and 
//use string literals to represent data in the c# programming language.

string firstName="Rohit";
string lastName="Gore";
string location1="Pune";

string name3=firstName+" "+ lastName+" "+ location1;
Console.WriteLine(name3);
string userInfo=string.Format("FirstName:{0}, LastName:{1}, Location:{2}", firstName,lastName, location);
Console.WriteLine(userInfo);
string names1="Kalpesh\nRupesh\nTanmay";
Console.WriteLine(names1); 
string path1=@"C:\Users\admin\HandsOn\StringApp";
Console.WriteLine(path1);
string msg4=@"Hi Guest,
    Welcome to Transflower World
    Learning Made Easy";
Console.WriteLine(msg4);
string msg5=@"His Name was Tanmay";
Console.WriteLine(msg5);

Console.WriteLine("\nEnter Key to Exit");
Console.ReadLine();

//C# String Splite Method Example

string msg6 = "Rohit, Gaurav, Nikhil";
string[] strarr = msg6.Split(',');
for(int i =0; i<strarr.Length;i++)
{
    Console.WriteLine(strarr[i]);
}
Console.WriteLine("\n Enter key to Exit");
Console.ReadLine();

//C# Split String with Multiple Delimiters
//Following is the example of splitting the given string with multiple delimiters in the c# programming language.

string msg7="Rohit,Gaurav-Nikhil%Akhilesh";
string[] strarr2=msg7.Split(new char[]{',','-','%'}, StringSplitOptions.RemoveEmptyEntries);
for(int i = 0; i < strarr2.Length; i++ )
{
    Console.WriteLine(strarr2[i]);
}
Console.WriteLine("\n Enter Key to Exit");
Console.ReadLine();

//Following is the example of using the Replace() method to replace a particular part of a string or a character c# programming language.

string msg8 = " Hi Guest";
string nwmsg = msg8.Replace("Hi"," Welcome");
Console.WriteLine("Old Message : {0}", msg8);
Console.WriteLine("New Message : {0}", nwmsg);


string x = "aaaa";
string nx = x.Replace("a", "b").Replace("b","c");
Console.WriteLine("Old : {0}", x);
Console.WriteLine("New : {0}", nx);

string y ="1 2 3 4 5 6 7";
string ny = y.Replace(" ",",");
Console.WriteLine("Old : {0}", y);
Console.WriteLine("New : {0}", ny);


string d = "Rohit Gaurav Nikhil Akhilesh";
string nd = d.Replace(" ","\n");
Console.WriteLine("Old : {0}", d);
Console.WriteLine("New : {0}", nd);

Console.WriteLine("\n Press Enter Key to exit");
Console.ReadLine();


//Following is the example of using the Concat() method to append or concatenate one or more strings and return it as a new string in the c# programming language.

string msg9 = "Welcome To";
string msg10 = " "+ "TransFlower";
Console.WriteLine(" Message : {0}", string.Concat(msg9, msg10));

string name4 = "Tanmay";
string name5 = ","+ "Stifan";
string name6 = ","+ "Sameer";
Console.WriteLine(" User Names : {0}", string.Concat(name4, name5, name6));

Console.WriteLine("\n Press Enter to Exit ...");
Console.ReadLine();


//Following is the example of using Contains() method to check whether the given value occurs within the string or not in the c# programming language.

string message = "Welcome To TransFlower";
string subtxt = "TransFlower";
Console.WriteLine("Does {0} Contain {1}? : {2}", message, subtxt,subtxt.Contains(subtxt));
string subtxt2 = "TransFlower";
Console.WriteLine(" Does {0} Contains {1}? : {2}", message, subtxt2,subtxt2.Contains(subtxt2));

Console.WriteLine("\n Press Enter to Exit ...");
Console.ReadLine();


string message1 = "My Name is Rohit";
string subtxt3 = "Name";
Console.WriteLine(" Does {0} Contains {1}? : {2}", message1, subtxt3,subtxt3.Contains(subtxt3));
*/

//To perform a case-insensitive string comparison, you need to use the string IndexOf method. Following is the example of performing a case insensitive search in the c# programming language.





