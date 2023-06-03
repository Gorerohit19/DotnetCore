
using System.IO;

string filePath = @"F:\FilePath\StreamWriter.txt";

//File content Writing
FileStream fs = new FileStream(filePath, FileMode.Create);
using (StreamWriter sw = new StreamWriter(fs)){
    sw.WriteLine(" Welcome To Transflower");
    sw.WriteLine("\n Learning Experience");
    sw.WriteLine("\n Doing ordinary things extra ordinary");
}

// Reading File Content

using(StreamReader sr = new StreamReader(filePath)){
    string txt;
    //Reading data from File, Until the end of File is Reached 
    while((txt=sr.ReadLine())!=null){
        Console.WriteLine(txt);
    }
}
