namespace _08.Custom_Comparator
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var eveNums = nums.Where(a => a % 2 == 0).OrderBy(a => a).ToList();
            var oddNegNums = nums.Where(a => a % 2 == -1).OrderBy(a => a).ToList();
            var oddNums = nums.Where(a => a % 2 == 1).OrderBy(a => a).ToList();
            Console.WriteLine(string.Join(" ", eveNums).Trim() + " " + string.Join(" ", oddNegNums).Trim() + " " + string.Join(" ", oddNums).Trim());
        }
    }
}
