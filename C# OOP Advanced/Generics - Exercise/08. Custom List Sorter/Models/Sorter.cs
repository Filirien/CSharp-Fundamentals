using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Sorter<T>  where T : IComparable<T>
{
    public static void Sort(CustomList<T> customList)
    {
        customList = customList.OrderBy(a => a);
    }
    
}