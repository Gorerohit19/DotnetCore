namespace TFL;


public class ReflectedClass
{
    public string Property1 { get; set; }

    public int Add(int first, int second) //This method
    {
        return first + second;
    }

    public override string ToString()
    {
        return  " Reflected Class Instnace ToString implementation";
    }
}
