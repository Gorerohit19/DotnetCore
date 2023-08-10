namespace OverRiding;
public class Square : Polygon
{
    // overriding render() method 
    public override void render()
    {
        Console.WriteLine("Rendering Square...");
    }
}