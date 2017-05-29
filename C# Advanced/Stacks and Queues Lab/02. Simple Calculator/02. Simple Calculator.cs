namespace _02.Simple_Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(line.Reverse());
            while (stack.Count > 1)
            {
                var first    = int.Parse(stack.Pop());
                var od = stack.Pop();
                var second = int.Parse(stack.Pop());

                switch (od)
                {
                    case "+" :
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
