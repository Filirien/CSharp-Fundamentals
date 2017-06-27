namespace _01.Second_Nature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var flowers = Console.ReadLine().Split(' ').ToList();
            var buckets = Console.ReadLine().Split(' ').ToList();
            var stackFlowers = new Stack<int>();
            var stackBucket = new Stack<int>();
            var eternalBlooms = new Queue<int>();
            for (int i = flowers.Count - 1; i >= 0; i--)
            {
                stackFlowers.Push(int.Parse(flowers[i]));
            }
            for (int i = 0; i < buckets.Count; i++)
            {
                stackBucket.Push(int.Parse(buckets[i]));
            }
            var water = 0;
            var flower = 0;

            while (stackFlowers.Count != 0 && stackBucket.Count != 0)
            {
                water = stackBucket.Pop();
                flower = stackFlowers.Pop();
                var difference = water - flower;
                if (difference > 0)
                {
                    if (stackBucket.Count > 0)
                    {
                        var nextWater = stackBucket.Pop();
                        stackBucket.Push(nextWater + difference);
                        flower = 0;
                    }
                }
                else if (difference < 0)
                {
                    water = 0;
                    stackFlowers.Push(difference * (-1));
                    flower = 0;
                }
                else
                {
                    eternalBlooms.Enqueue(flower);
                }
            }
            if (stackBucket.Count > 0)
            {
                Console.WriteLine(string.Join(" ", stackBucket));
            }
            else
            {
                Console.WriteLine(string.Join(" ", stackFlowers));
            }
            Console.WriteLine(eternalBlooms.Count == 0 ? "None" : string.Join("", eternalBlooms));
        }
    }
}
