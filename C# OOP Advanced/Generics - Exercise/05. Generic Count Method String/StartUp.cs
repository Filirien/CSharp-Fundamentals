using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var genericList = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            genericList.Add(input);
        }
        string comparingElement = Console.ReadLine();
        Console.WriteLine(Compare(genericList, comparingElement));
    }
    public static int Compare<T>(IList<T> list, T element)
        where T : IComparable<T>
    {
        return list.Count(i => i.CompareTo(element) > 0);
    }
}
