namespace _02.Sets_Of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var set = new HashSet<int>();
            var n = input[0];
            var m = input[1];
            for (int i = 0; i < n; i++)
            {
                var line =int.Parse(Console.ReadLine());
                set.Add(line);
            }
            for (int i = 0; i < m; i++)
            {
                var line = int.Parse(Console.ReadLine());
                set.Add(line);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
