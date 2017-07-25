using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        var genericList = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());
            genericList.Add(input);
        }
        var comparingElement = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Swap(genericList, comparingElement[0], comparingElement[1]);
        for (int i = 0; i < genericList.Count; i++)
        {
            Console.WriteLine($"System.Int32: {genericList[i]}");
        }
    }
    public static void Swap<T>(IList<T> list, int first, int second)
    {
        var firstIndex = first;
        var secondIndex = second;
        var old = list[firstIndex];
        list[firstIndex] = list[secondIndex];
        list[secondIndex] = old;
    }
}
