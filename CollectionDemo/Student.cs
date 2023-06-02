namespace HBGCollection;
public class Student
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string Location {get; set;}

    public override string ToString()
    {
        return this.Id + " " + this.Name + " " + this.Location;
    }
}