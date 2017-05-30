namespace _07.Fix_Emails
{
    using System;
    using System.Collections.Generic;
    public class Program
    {
       public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var combo = new Dictionary<string, string>();

            while (name != "stop")
            {
                var email = Console.ReadLine();
                string ending = email.Substring(email.Length - 2, 2).ToLower();
                if (ending != "uk" && ending != "us")
                {
                    combo.Add(name, email);

                }
                name = Console.ReadLine();
            }
            foreach (var item in combo)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
