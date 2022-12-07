namespace GDI
{


public class Point
{
 private int x;
 public int X
  {
       get{ return this.x;}
       set{this.x=value;}
  }
 private int y;
public int Y
   {
       get{ return this.y;}
       set{this.y=value;}
   }

public override string ToString()
    {
       
       string strData ="X ="+ this.X + ",Y="+this.Y;
       
       return strData;
       
       
    }

}
}