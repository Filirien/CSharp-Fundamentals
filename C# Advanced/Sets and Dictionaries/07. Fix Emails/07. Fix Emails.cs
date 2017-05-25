namespace _07.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var dic = new Dictionary<string, string>();
            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
               var check = email.Split(new[] { '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (check[1] == "us" || check[1]=="uk")
                {
                    continue;
                }
                dic.Add(name,email);
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
