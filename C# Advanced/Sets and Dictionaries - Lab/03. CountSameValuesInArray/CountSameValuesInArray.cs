namespace _03.CountSameValuesInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CountSameValuesInArray
    {
        public static void Main()
        {
            var dic = new SortedDictionary<double, int>();
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dic.ContainsKey(input[i]))
                {
                    dic[input[i]] = 0;
                }
                dic[input[i]]++;
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
