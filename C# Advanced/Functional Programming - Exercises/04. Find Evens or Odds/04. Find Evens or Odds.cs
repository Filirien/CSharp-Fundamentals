namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var dif = Console.ReadLine();
            Func<string, string, List<int>> nums = EvenOrOdd;
            var result = nums(line, dif);
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static List<int> EvenOrOdd(string numbers, string isEven)
        {
            var result = numbers.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var a = new List<int>();

            for (int i = result[0]; i <= result[1]; i += 2)
            {
                a.Add(i);
            }
            if (isEven == "even")
            {
                a.Select(s => s % 2 == 0);
            }
            else if (isEven == "odd")
            {
                a.Select(s => s % 2 == 1);
            }

            return a;
        }
    }
}
