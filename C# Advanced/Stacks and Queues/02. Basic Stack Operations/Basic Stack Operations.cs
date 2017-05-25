namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Basic_Stack_Operations
    {
        public static void Main()
        {
            var operations = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var nums = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();
            var n = operations[0];
            var s = operations[1];
            var x = operations[2];

            for (int i = 0; i < n; i++)
            {
                stack.Push(nums[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count() == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Pop());
                }
            }
        }
    }
}
