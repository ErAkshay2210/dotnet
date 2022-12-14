namespace TAP
{
    public class Student
    {

     private int id ;

     private string name;

     private string location;

     private string sclass;

 
     public Student()
     {
          this.id =01;
          this.name="Vedant";
          this.location="pune";
          this.sclass="5th";
 
     }

     public Student (int i, string sname, string slocation, string scl)
     {
         this.id=i;
         this.name=sname;
         this.location=slocation;
         this.sclass=scl;

     }

    public void setID (int ID)
    {
        this.id =ID;

    }
    public int  getId()
    {
        return this.id;

    }
    public void setName (string n)
    {
      this.name=n;

    }
     public string getName()
     {
        return this.name;
     }
    public void setLocation (string l)
    {
      this.location=l;

    }
     public string getLocation()
     {
        return this.location;
     }
    public void setClass (string standard)
    {
      this.sclass=standard;

    }
     public string getClass()
     {
        return this.sclass;
     }


    public override string ToString(){
            return  this.getId() + " "+ this.getLocation() + " "+ this.getName()+""
        + this.getClass();
        }


      


    }
















































    }