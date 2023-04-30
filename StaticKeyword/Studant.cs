namespace Training;
public class Student
{
    private int id;
    private string fullName;
    private string qualification;
     
    private string email;

    private static int count;

    public Student()
    {
        this.id=19;
        this.fullName="Rohit Gore";
        this.qualification="BTech";
        this.email="gore.rohit@gmail.com";  
        count=count +1;
    }

    public Student(int id, string fName, string qual)
    {
       this.id=id;
       this.fullName=fName;
       this.qualification=qual;
       this.email="tflpvtltd@gmail.com";
       count=count +1;

    }

    public Student(int id, string fName, string qual,string em)
    {
        this.id=id;
        this.fullName=fName;
        this.qualification=qual;
        this.email=em;
        count=count +1;
    }

    public override string ToString()
    {
        string data = string.Format(" {0}, {1}, {2}, {3}", this.id, this.fullName, this.qualification, this.email);
        return data;
    }

    public static int GetCount()
    {
        return count;
    }
}