namespace _04.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Basic_Queue_Operations
    {
        public static void Main()
        {
            var operations = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var que = new Queue<int>();
            var n = operations[0];
            var s = operations[1];
            var x = operations[2];

            for (int i = 0; i < n; i++)
            {
                que.Enqueue(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                que.Dequeue();
            }
            if (que.Contains(x))
            {
                Console.WriteLine("true");
            }

            else if (que.Count() == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(que.Min());
            }

        }
    }
}
