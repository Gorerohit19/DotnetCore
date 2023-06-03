/**
Two integers can be easily compared using their numerical value. 
Two Strings can be compared according to their lexicographical order.
But what about objects of classes which consists of different data types?
How would the compiler know if one object is equal to another object? 
What if we need to sort a list of objects? 
How would we define the comparison parameter for two objects?
This is where the Comparer class comes in handy.
**/
using System.Collections;
namespace TFLCollection;
public class EmpComparar:IComparer<Employee>
{
     public int Compare(Employee e1, Employee e2)
    {
        /*
        int ret = e1.name.Length.CompareTo(e2.name.Length);
        return ret;
        */

        if(e1.salary > e2.salary)
        {
            return 1;
        }
        else if(e1.salary < e2.salary)
        {
            return -1;
        }
        else
        return 0;
    }
   
}
