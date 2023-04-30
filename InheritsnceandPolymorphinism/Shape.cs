namespace GDI;

public abstract class Shape
{
    public string Color {get; set;}
  public Shape()
  {
    this.Color = "Yellow";
  }

  public Shape(string c)
  {
    this.Color=c;
  }

  public abstract void Draw();

  public virtual void Show()
  {
    Console.WriteLine("Showing Shape ...");
  }
}