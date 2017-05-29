namespace _6.MathPotato
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var childrens = Console.ReadLine().Split();
            var que = new Queue<string>(childrens);
            var n = int.Parse(Console.ReadLine());
            int cycle = 1;
            while (que.Count > 1)
            {
                for (int i = 0; i < n-1; i++)
                {
                    que.Enqueue(que.Dequeue());
                }


                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {que.Peek()}");
                }

                else
                {
                    Console.WriteLine($"Removed {que.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {que.Dequeue()}");
        }

        public static bool IsPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
