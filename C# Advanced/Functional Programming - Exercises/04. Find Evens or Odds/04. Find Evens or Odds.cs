namespace _04.Find_Evens_or_Odds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                 .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            var keyWord = Console.ReadLine();
            var startNumber = input[0];
            var endNumber = input[1];
            var numbers = new List<int>();
            for (int i = startNumber; i <= endNumber; i++)
            {
                numbers.Add(i);
            }
            Predicate<int> oddFinder = x => x % 2 != 0;
            Predicate<int> evenFinder = x => x % 2 != 1;
            List<int> result = new List<int>();
            if (keyWord == "odd")
            {
                result = numbers.FindAll(oddFinder);
            }
            else
            {
                result = numbers.FindAll(evenFinder);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
