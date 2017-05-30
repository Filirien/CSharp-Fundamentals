namespace _06.A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            for (int i = 1; ; i++)
            {
                string resource = Console.ReadLine();

                if (resource.Equals("stop"))
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!myDict.ContainsKey(resource))
                {
                    myDict.Add(resource, 0);
                }
                
                myDict[resource] += quantity;
            }

            foreach (var item in myDict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
