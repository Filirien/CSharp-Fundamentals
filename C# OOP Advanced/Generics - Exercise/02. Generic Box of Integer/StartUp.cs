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
        var genericList = new List<string>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            genericList.Add(input);
        }
       
        for (int i = 0; i < genericList.Count; i++)
        {
            Console.WriteLine($"System.Int32: {genericList[i]}");
        }
    }
}
