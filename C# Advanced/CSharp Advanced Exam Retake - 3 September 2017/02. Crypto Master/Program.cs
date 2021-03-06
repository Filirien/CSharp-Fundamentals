﻿namespace _02._Crypto_Master
{
    using System;
    using System.Linq;

    public class Program
    {
       public static void Main()
        {
            int[] numbers = Console.ReadLine()
               .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int maxSequence = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                for (int step = 1; step < numbers.Length; step++)
                {
                    int currentIndex = index;
                    int nextIndex = (index + step) % numbers.Length;
                    int currentSequence = 1;

                    while (numbers[currentIndex] < numbers[nextIndex])
                    {
                        currentIndex = nextIndex;
                        nextIndex = (nextIndex + step) % numbers.Length;
                        currentSequence++;
                    }
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
