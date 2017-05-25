namespace _06.A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            var dic = new Dictionary<string, double>();
            string oldOne = null;
            for (int i = 1; i < 1000; i++)
            {
                if (i%2==1)
                {
                    var line = Console.ReadLine();
                    oldOne = line;
                    if (line == "stop")
                    {
                        break;
                    }
                    if (!dic.ContainsKey(line))
                    {
                        dic[line] = 0;
                    }
                }
                else
                {
                    var line = int.Parse(Console.ReadLine());
                    dic[oldOne] += line;
                }

            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
