namespace _03.Periodic_Table
{
    using System;
    using System.Collections.Generic;
    public  class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var chCompounds = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    chCompounds.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(" ", chCompounds));
        }
    }
}
