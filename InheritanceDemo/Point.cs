namespace GDI;

public class Point {
    private int x;
    public int X{
        get{return this.x;}
        set{this.x=value;}
    }

    public int Y {get; set;}

    public override string ToString()
    {
        string strData ="X ="+ this.X + " , Y ="+this.Y;
        return strData;
    }
}