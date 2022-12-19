namespace DeviceManagement
{

 public class Device : Drawable , Readable, Writable
    {


       public void Draw()
       {
             System.Console.WriteLine("drawing any Shape ");
       }
       //public void Print()
       //{
       //      System.Console.WriteLine(" printing any data using printer ");
       //}
       public void Read ()
       {
          System.Console.WriteLine(" reading data by using scanner");
       }
       public void Write()
       {
          System.Console.WriteLine(" write a data on pad ");
       }

    }
}