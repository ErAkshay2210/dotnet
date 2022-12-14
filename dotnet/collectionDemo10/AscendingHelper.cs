namespace CollectionDemo;
public class sortYearAscendingHelper :IComparable<car>
{
public int Compare(car x,car y)
{
    if (x.year > y.year)
           return 1;

    if (x.year < y.year)  
     return -1; 

    else
     return 0;

}
}






