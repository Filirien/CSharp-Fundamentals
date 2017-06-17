namespace _07.Bounded_Numbers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var result = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Where(n => input.Min() <= n && n <= input.Max())
                .ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
