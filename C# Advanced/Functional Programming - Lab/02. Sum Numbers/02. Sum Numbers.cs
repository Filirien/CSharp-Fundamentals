namespace _02.Sum_Numbers
{
    using System;
    using System.Linq;
    public class SumNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(a => a)
                .ToList();
            var result = 0;
            for (int i = 0; i < input.Count; i++)
            {
                result += input[i];
            }
            Console.WriteLine(input.Count);
            Console.WriteLine(result);
        }
    }
}
