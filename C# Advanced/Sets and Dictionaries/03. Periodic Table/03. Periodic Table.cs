namespace _03.Periodic_Table
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int k = 0; k < line.Length; k++)
                {
                    set.Add(line[k]);
                }
            }
            foreach (var item in set)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
