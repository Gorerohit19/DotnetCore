using DeviceManagement;

//Multiple Interface Inheritance is allowed but
//Multple Implementation Inheritance is not allows on OOPs

public class Device :Printable, Readable, Drawable, Writable
{
    public void Print()
    {
        Console.WriteLine("Printing any data using Printer");
    }

    public void Read()
    {
        Console.WriteLine("Reader any data using Scanner");
    }

    public void Draw()
    {
        Console.WriteLine("Drawing any Shape");
    }

    public void Write()
    {
        Console.WriteLine("Writing information on Pad");
    }
}
