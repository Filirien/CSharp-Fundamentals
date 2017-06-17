namespace _01.Take_Two
{
    using System;
    using System.Linq;
    public class TakeTwo
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => 10 <= a && a <= 20)
                .Distinct()
                .Take(2)
                .ToList();
            Console.WriteLine(string.Join(" ",input));
        }
    }
}
