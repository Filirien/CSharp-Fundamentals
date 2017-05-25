namespace _03.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Maximum_Element
    {
        public static void Main()
        {
            var stack = new Stack<int>();
            var n = int.Parse(Console.ReadLine());
            var maxStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var nums = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (nums[0]==1)
                {
                    stack.Push(nums[1]);
                }
                else if (nums[0]==2)
                {
                    stack.Pop();
                }
                else if (nums[0]==3)
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
