namespace GDI;

public class Line:Shape
{
 protected Point startPoint;

protected Point endPoint;
 public Line ()
   {
    this.startPoint=new Point();
  
    this.startPoint.X=20;
    this.startPoint.Y=40;
   
    this.endPoint=new Point();

    this.endPoint.X=15;
    this.endPoint.Y=45;

    this.color="blue";
 }
 public Line (Point p1, Point p2,string c)

   {
    this.startPoint=p1;
    this.endPoint=p2;

    this.color=c;
   }

public override string ToString()
   {
    string strStartPoint=this.startPoint.ToString();
    string strEndPoint=this.endPoint.ToString();
    string data=string.Format( "("+strStartPoint + "),( "+ strEndPoint + ") , "+ this.color);
    return data;
   }
}


