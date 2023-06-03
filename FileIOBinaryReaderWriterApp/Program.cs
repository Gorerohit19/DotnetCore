using System.IO;

string filePath=@"F:\FilePath\BinaryWriter.txt";

//Write data into file using BinaryWriter class

FileStream fs=new FileStream(filePath, FileMode.Create);
using(BinaryWriter bw=new BinaryWriter(fs)){
    bw.Write(19.25);
    bw.Write("Welcome to Transflower for learning technolgy ");
    bw.Write(300);
    bw.Write(true);
}

//Read data from file using BinaryReader

FileStream fs2=File.Open(filePath, FileMode.Open);

using(BinaryReader br=new BinaryReader(fs2)){
    Console.WriteLine(br.ReadDouble());
    Console.WriteLine(br.ReadString());
    Console.WriteLine(br.ReadInt32());
    Console.WriteLine(br.ReadBoolean());
}