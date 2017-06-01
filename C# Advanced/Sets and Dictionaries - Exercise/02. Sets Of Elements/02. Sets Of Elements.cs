namespace _02.Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            
            var n = arr[0];
            var m = arr[1];

            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                nSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < m; i++)
            {
                mSet.Add(int.Parse(Console.ReadLine()));
            }

            var result = nSet.Intersect(mSet);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
