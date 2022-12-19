namespace MATH
{
public class DemoClass
{    

   public void Swap(int c , int c2) 
{
      int temp =c;
      c=c2;
      c2=temp;
}

 public static void Swapp(ref  int n1,  ref int n2)
 {
     int temp =n1;
     n1=n2;
     n2=temp;
   
 }
 public static void Calculate(float radius,out float area, out float circum)
{
   area = 3.14f*radius *radius;
   circum=2*3.14f *radius;

}

     
}


}
/*using Library;
   
     Books mybooks =new Books();
     mybooks [2]="mogali in jungle";
     string title =mybooks[2];
     
     System.Console.WriteLine(title);
    */

  /*
  
    using MATH;

    int x=10;
    int y=20;

    DemoClass.Swapp( ref x ,  ref y); //here we use refrence thats why value change in stack
  
   System.Console.WriteLine(x);
   System.Console.WriteLine(y);


*/


/*
 float area,circum;

    DemoClass.Calculate(4.5f,out area ,out circum);
    
    System.Console.WriteLine(area);
    System.Console.WriteLine(circum);

*/

