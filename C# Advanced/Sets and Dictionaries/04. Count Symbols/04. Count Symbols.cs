namespace _04.Count_Symbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToArray();
            var dic = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {

                if (!dic.ContainsKey(text[i]))
                {
                    dic[text[i]] = 0;
                }
                dic[text[i]]++;
            }

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
