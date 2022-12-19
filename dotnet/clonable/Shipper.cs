namespace TFL
{
   public class Shipper:ICloneable

{
    public int id ;

    public string name;


    public Shipper()
    {
        this.id =1;
        this.name ="SuryaCuriers";
    }
    public Shipper (int id, string name )
    {
        this.id =id;
        this.name=name;
    }

        public object Clone()
        {
          Shipper temp =new Shipper();
          temp.id=this.id;
          temp.name=this.name;

          return temp;

        }
        public override string ToString()
        {
            return "Id=\t" +id +" , "+ "Name="  +name;
        }
    }

}

       