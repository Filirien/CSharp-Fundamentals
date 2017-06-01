namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('-');

            var phonebook = new Dictionary<string, string>();

            while (input[0] != "search")
            {
                string name = input[0];
                string phone = input[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phone);
                }
                else
                {
                    phonebook[name] = phone;
                }

                input = Console.ReadLine().Split('-');
            }

            string input2 = Console.ReadLine();



            while (input2 != "stop")
            {
                if (phonebook.ContainsKey(input2))
                {
                    Console.WriteLine($"{input2} -> {phonebook[input2]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input2} does not exist.");
                }

                input2 = Console.ReadLine();
            }
        }
    }
}
