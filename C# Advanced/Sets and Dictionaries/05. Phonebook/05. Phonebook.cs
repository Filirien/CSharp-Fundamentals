namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dic = new Dictionary<string, string>();
            var result = new Dictionary<string, string>();
            try
            {


                while (true)
                {
                    var line = Console.ReadLine().Split(new[] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (line[0] == "search")
                    {
                        break;
                    }
                    dic.Add(line[0], line[1]);
                }
                while (true)
                {
                    var line = Console.ReadLine();
                    if (line == "stop")
                    {
                        break;
                    }
                    if (!dic.ContainsKey(line))
                    {
                        Console.WriteLine($"Contact {line} does not exist.");
                    }
                    foreach (var item in dic)
                    {
                        if (item.Key == line)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine();
            }
        }
    }
}
