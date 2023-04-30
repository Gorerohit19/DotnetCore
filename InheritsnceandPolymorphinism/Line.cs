namespace GDI;

public sealed class Line : Shape
{
   public Point StartPoint {get; set;}

   public Point EndPoint {get; set;}

   public Line() : base()
   {
    this.StartPoint=new Point {X=0, Y=0};
    this.EndPoint=new Point {X=0, Y=0};
    this.Color="Yellow";
   }

   public Line(Point pt1, Point pt2, string c):base(c)
   {
    this.StartPoint=pt1;
    this.EndPoint=pt2;
    this.Color=c;
   }

    public override void Draw()
    {
       Console.WriteLine(" StartPoint= {0}, {1}, EndPoint= {2},{3}, Color={4}", StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y, Color);
    }

    public override void Show()
    {
        Console.WriteLine(" Line is Showing ...");
        base.Show();
    }

    ~Line()
    {
        
    }
}