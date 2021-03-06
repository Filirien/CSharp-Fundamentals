﻿namespace _04.Count_Symbols
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> charCounter = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (!charCounter.ContainsKey(current))
                {
                    charCounter[current] = 0;
                }

                charCounter[current]++;
            }

            foreach (var item in charCounter)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
