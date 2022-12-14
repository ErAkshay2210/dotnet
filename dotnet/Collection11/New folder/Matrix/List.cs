namespace Sales{

public class Vehicle : IEquatable<Vehicle>
{
       
       public int RegistartionNumber{get; set;}
       public string ModelName{get; set;}
       public double Price{get; set;}
       public string OwnerName{get; set;}
       public string ContactNumber{get; set;}
       public string Email{get; set;}



       public Vehicle()
       {
         this.RegistartionNumber=4565;
         this.ModelName="Swift";
         this.Price=350000;
         this.OwnerName="Yash Patil";
         this.ContactNumber="9921335485";
         this.Email="yashpatil@gmail.com";

       }

       public Vehicle(int id , string mName, double price, string name , string mobileno , string email)
     {
        this.RegistartionNumber=id;
        this.ModelName=mName;
        this.Price=price;
        this.OwnerName=name;
        this.ContactNumber=mobileno;
        this.Email=email;
      }


       public override string ToString()
       {
        System.Console.WriteLine("working");
        return  this.RegistartionNumber +" , "+ this.ModelName+" , "+ this.Price +" , "+this.OwnerName+" , "+this.ContactNumber+" , "+this.Email;
       }


       public override bool Equals (object obj)
       {
          if (obj == null) return false ;

          Vehicle objAsVehicle = obj as Vehicle;

          if (objAsVehicle==null) return false;

          else return Equals(objAsVehicle);
       }

       public override int GetHashCode()
       {
              return RegistartionNumber;
       }

       public bool Equals(Vehicle other )
       {
         if (other == null) return false ;
         return (this.RegistartionNumber.Equals(other.RegistartionNumber));

       }


       }
       

     }
 
