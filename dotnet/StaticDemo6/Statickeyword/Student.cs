namespace Trainning
{

public class Student
{

  public int id;
  public string fullname;
  public string branchName;
  public string location;
  public string contactNumber;
  public static int count;


 public Student()
   {
      this.id= 01;
      this.fullname="Akshay Tanpure";
      this.branchName="Mechanical";
      count=count+1;
   }
 public Student(int i , string name, string bName, string address)
    {
      this.id=i;
      this.fullname=name;
      this.branchName=bName;
      this.location=address;
      count=count+1;

    }

 public Student(int i, string name ,string bName,string address,string mobileNumber)
    {
      this.id=i;
      this.fullname=name;
      this.branchName=bName;
      this.location=address;
      this.contactNumber=mobileNumber;
      count=count+1;

    }
  
  public override string ToString()
    {

      string data = string.Format ("{0},{1},{2},{3},{4},", this.id,this.fullname,this.branchName,this.location,this.contactNumber);
      return  data;

    }


public void ShowStatus()
{
    Console.WriteLine("I am a student ");
}
public static int GetCount()
{
    return count;
}


}


















}

