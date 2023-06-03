using System.IO;
using System.Text;

string filePath=@"F:\FilePath\Binary.txt";



// If you want to delete Existing File
if(File.Exists(filePath))
{
    File.Delete(filePath);
}


// Creating new File (Binary) and Writing Data inside

using(FileStream fs = File.Create(filePath)){
    string data="This is Transflower data";
    UTF8Encoding endcoder = new UTF8Encoding(true);

    //string data is Converted into Bytes
    byte[] binaryData = endcoder.GetBytes(data);

    // Binary data is Written into file
    fs.Write(binaryData, 0,binaryData.Length);
}

//Now We would try code for reading data from binary file
//get STream in read mode

using(FileStream fs = File.OpenRead(filePath))
{
    byte[] binaryData = new byte[1024];
    UTF8Encoding encoder = new UTF8Encoding(true);

    while(fs.Read(binaryData, 0, binaryData.Length)>0){
        //Data Which is in Binary format is COnverted into string
        string dataFromFile = encoder.GetString(binaryData);
        Console.WriteLine(dataFromFile);
    }
}