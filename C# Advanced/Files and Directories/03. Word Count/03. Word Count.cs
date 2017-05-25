namespace _03.Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dict = new Dictionary<string, int>();
            var text = File.ReadAllText(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\04_WordCount\words1.txt").Split(new [] {',','.',':','?','!', ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in text)
            {
                dict[item] = 0;
            }    
            var text1 = File.ReadAllText(@"C:\Users\Niki\Desktop\C# Fundamentals\Exercises\03. CSharp-Advanced-Files-And-Directories\04_WordCount\text1.txt").Split(new [] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var item in text1)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
