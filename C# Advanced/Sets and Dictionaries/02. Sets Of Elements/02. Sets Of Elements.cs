namespace _02.Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstSet = new HashSet<string>();
            var secondSet = new HashSet<string>();

            for (int i = 0; i < n[0]; i++)
            {
                var num = Console.ReadLine();
                firstSet.Add(num);
            }
            for (int i = 0; i < n[1]; i++)
            {
                var num = Console.ReadLine();
                secondSet.Add(num);
            }
            firstSet.IntersectWith(secondSet);
            foreach (var item in firstSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
