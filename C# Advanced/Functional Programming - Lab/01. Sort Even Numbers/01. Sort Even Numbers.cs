namespace _01.Sort_Even_Numbers
{
    using System;
    using System.Linq;
    public class SortEvenNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(a => a % 2 == 0)
                .OrderBy(a => a)
                .ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
