namespace _06.Reverse_And_Exclude
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var divisible = int.Parse(Console.ReadLine());
            var result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % divisible == 0)
                {
                    continue;
                }
                else
                {
                    result.Add(nums[i]);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
