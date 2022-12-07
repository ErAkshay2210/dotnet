using GDI;

Shape theShape =new Shape();
Shape theShape2=new Shape("pink");


string obj1color=theShape.GetColor();
string obj2color=theShape2.GetColor();

Console.WriteLine("First object color ={0}",
obj1color);

Console.WriteLine("Second object color ={0}", obj2color);

Console.WriteLine( "Terminating application");

Line l1=new Line();
Console.WriteLine(l1.ToString());

Point p11 =new Point();
p11.X=10;
p11.Y=100;

Point p22 =new Point ();
p22.X=10;
p22.Y=65;

Line  L2 =new Line (p11,p22, "Black");
Console.WriteLine(L2.ToString());



