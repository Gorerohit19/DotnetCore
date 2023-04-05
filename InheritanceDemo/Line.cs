namespace GDI;


    public class Line:Shape
    {
        private Point startPoint;
        private Point endPoint;     
    
     
     //Default Contrator
    public Line()
    {
        this.startPoint=new Point();
        this.startPoint.X=0;
        this.startPoint.Y=0;

        this.endPoint=new Point();
        this.endPoint.X=0;
        this.endPoint.Y=0;

        this.color="Blue";
    }

    public Line(Point pt1, Point pt2, string c)
    {
        this.startPoint=pt1;
        this.endPoint=pt2;
        this.color=c;
    }

    public override string ToString()
    {
        string strStartPoint=this.startPoint.ToString();
        string strEndPoint=this.endPoint.ToString();
        string data = string.Format("("+strStartPoint + "),( "+ strEndPoint + ")," + this.color); 
        return data;
    }

}

