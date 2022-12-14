namespace CollectionDemo;
public class sortYearDscendingHelper : IComparer<car>
{
 public int Compare(car a,car b)
 {
     car c1 =(car)a;
     car c2 =(car)b;


     if (c1.year< c2.year)
      return 1;

      if (c2.year > c2.year)
      return -1;

      else 
      return 0;

 }

 

 }











