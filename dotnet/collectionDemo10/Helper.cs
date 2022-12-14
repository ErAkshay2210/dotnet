namespace CollectionDemo;

public class sortMakeDescendingHelper : IComparer<car>
{


    public int Compare(car a,car b)
    {
         car c1= (car)a;

         car c2 =(car)b;
          
         return String.Compare(c2.make, c1.make);


    }
}


