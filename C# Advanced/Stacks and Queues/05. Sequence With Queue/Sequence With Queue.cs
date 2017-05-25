namespace _05.Sequence_With_Queue
{
    using System;
    using System.Collections.Generic;

    public class Sequence_With_Queue

    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            var elementsInSequence = new Queue<long>();
            var result = new List<long>();
            elementsInSequence.Enqueue(n);
            result.Add(n);

            while (result.Count < 50)
            {
                long currentElement = elementsInSequence.Dequeue();
                long firstNumber = currentElement + 1;
                long secondNumber = currentElement * 2 + 1;
                long thirdNumber = currentElement + 2;

                elementsInSequence.Enqueue(firstNumber);
                elementsInSequence.Enqueue(secondNumber);
                elementsInSequence.Enqueue(thirdNumber);

                result.Add(firstNumber);
                result.Add(secondNumber);
                result.Add(thirdNumber);

            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
