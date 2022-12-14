namespace TFLCollections;

public class Employee{
    private int id;
    private string fname;
    private string lname;

    public Employee(){
         this.id=99;
        this.fname="Ravi";
        this.lname="Tambade";

    }
    public Employee(int i, string f, string l){
        this.id=i;
        this.fname=f;
        this.lname=l;
    }
    public void setId(int id){
        this.id=id;
    }

    public int getId(){
        return this.id;
    }

    public void setFirstName(string  name){
        this.fname=name;
    }

    public string getFirstName(){
        return this.fname;
    }

    public void setLastName(string  name){
        this.lname=name;
    }

    public string getLastName(){
        return this.lname;
    }


 public override string ToString(){
            return  this.getId() + " "+ this.getFirstName() + " "+ this.getLastName();
        }

}
