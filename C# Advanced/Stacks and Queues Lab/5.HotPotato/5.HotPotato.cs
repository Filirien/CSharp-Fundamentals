namespace _5.HotPotato
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
                       
            while (que.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    que.Enqueue(que.Dequeue());
                }
                Console.WriteLine($"Removed {que.Dequeue()}");
            }
            Console.WriteLine($"Last is {que.Dequeue()}");

        }
    }
}
