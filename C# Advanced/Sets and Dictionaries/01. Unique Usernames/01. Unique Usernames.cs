namespace _01.Unique_Usernames
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                set.Add(line);
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
