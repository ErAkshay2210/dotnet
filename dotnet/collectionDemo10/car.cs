using System.Collections;
namespace CollectionDemo
{  
public class car : IComparable
 
 {  public int year;
    public string make;
    public int Year
    {
       get{return this.year;}
       set {this.year = value;}
    }
     public string Make
    {
        get{ return this.make;}
        set{this.make=value;}
    }
  public car(string make,int year)
  {
    this.make=make;
    this.year =year;
  }
 public int CompareTo(object obj)
  {
     car secondCar=(car)obj;


     if(year > secondCar.year)

        return 1;

     if (year < secondCar.year)

        return -1;

     else 

        return 0; 
  }

 int IComparable.CompareTo(object obj)
 {
     car c=(car)obj;
     return String.Compare(this.make,c.make);
 }

 public static IComparable<car> sortYearAscendingHelper()
 {
     return(IComparable<car>) new sortYearAscendingHelper();
 }

 public static IComparable<car>sortYearDescending()
 {
     return (IComparable<car>)new sortYearDescending();
 }
 public static (IComparable<car> sortMakeDescending()
 {
     return (IComparable<car> )new sortMakeDescendingHelper();
 }

 }

 

 

