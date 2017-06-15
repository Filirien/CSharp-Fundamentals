namespace _05.Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<List<int>, List<int>> sum;
            var result = new List<int>();
            result = numbers;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (command == "add")
                {
                    sum = Add;
                   result = sum(result);
                }
                else if (command == "multiply")
                {
                    sum = Multiply;
                   result = sum(result);
                }
                else if (command == "subtract")
                {
                    sum = Subtract;
                    result = sum(result);
                }
                else if (command == "print")
                {
                   Print(result);
                }
            }
        }

        private static void Print(List<int> print)
        {
            foreach (var item in print)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static List<int> Add(List<int> input)
        {
            return input.Select(s => s + 1).ToList();
        }

        private static List<int> Subtract(List<int> input)
        {
            return input.Select(s => s - 1).ToList();
        }

        private static List<int> Multiply(List<int> input)
        {
            return input.Select(s => s * 2).ToList();
        }
    }
}
