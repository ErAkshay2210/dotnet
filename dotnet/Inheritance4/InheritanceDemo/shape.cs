namespace GDI;

public class Shape 
{
 protected string color;



 public Shape()
 {
    this.color="blue";

 }
 public Shape (string c)
 {
    this.color=c;

 }

 public string GetColor()
 {
     return this.color;

 }

public void SetColor(string c)
{
     this.color=c;
}


~Shape()
{
 System.Console.WriteLine("DeInitializing instance....");

}

}



