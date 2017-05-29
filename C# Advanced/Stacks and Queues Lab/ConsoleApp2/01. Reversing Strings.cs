namespace _01._Reversing_Strings
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var stack = new Stack<char>();

            for (int i = 0; i < line.Length; i++)
            {
                stack.Push(line[i]);
            }

            Console.WriteLine(string.Join("", stack));
        }
    }
}
