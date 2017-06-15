namespace _03.Custom_Min_Function
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {

        public static void Main()
        {
            var nums = Console.ReadLine();
            Func<string, int> numbers = Print;
            Console.WriteLine(numbers(nums)); 
        }
        private static int Print(string nums)
        {
            var result = nums.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(a => a.Trim()).Select(int.Parse).ToList();
            var set = new HashSet<int>();
            foreach (var item in result)
            {
                set.Add(item);
            }
            return set.Min();
        }
    }
}