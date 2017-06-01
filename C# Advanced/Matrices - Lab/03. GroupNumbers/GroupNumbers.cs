namespace _03.GroupNumbers
{
    using System;
    using System.Linq;
    public class GroupNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var zero = input.Where(a => Math.Abs(a) % 3 == 0).ToArray();
            var one = input.Where(a => Math.Abs(a) % 3 == 1).ToArray();
            var two = input.Where(a => Math.Abs(a) % 3 == 2).ToArray();
            Console.WriteLine(string.Join(" ",zero));
            Console.WriteLine(string.Join(" ",one));
            Console.WriteLine(string.Join(" ",two));
        }
    }
}
