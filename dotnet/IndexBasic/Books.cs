namespace Library
{
 public class Books
 {

    public Books ()
    {

        this.titles[0]="Harry Potter";
         this.titles[1]="Mahabharat";
        this.titles[2]="Ramayan";
        this.titles[3]="RIch Dad Poor dad";
         
    }
    
   private string [] titles = new string[100];

   public string this [int index]
   {
    get {  
         if (index <0 || index >=100)
        
         throw new Exception("index is less than 0 or gretter than 100");
         else 
         return titles [index];
    }
    set { 

        if ( index <0 || index >=100)
        throw new Exception("index is less than 0 or gretter than 100");
        else 
        titles [index] =value;
     }
   }

   
   



   }



 }

