using System.Text;
using System.Collections.Generic;

string filePath = @"F:\FilePath\Test.txt";

if(File.Exists(filePath))
{
    File.Delete(filePath);
}

//Exception Handling
try{
    //Text Write
    using(TextWriter writer = File.CreateText(filePath))
    {
        string data ="My name is Rohit Gore";
        writer.WriteLine(data);
    }

    // Text Reading 
    using(TextReader reader = File.OpenText(filePath))
    {
        string data = reader.ReadToEnd();
        Console.WriteLine(data);
    }
}
    catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
