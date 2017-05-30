namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var enterSymbol = new string[3];
            var input = new Dictionary<string, string>();
            while (enterSymbol[0] != "END")
            {
                enterSymbol = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                if (enterSymbol[0] == "A")
                {
                    AttachInfo(enterSymbol, input);
                }
                else if (enterSymbol[0] == "S")
                {
                    PrintInfo(enterSymbol, input);
                }
            }
        }
        public static void PrintInfo(string[] info, Dictionary<string, string> phoneBook)
        {
            if (phoneBook.ContainsKey(info[1]))
            {
                Console.WriteLine($"{info[1]} -> {phoneBook[info[1]]}");
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", info[1]);
            }
        }
        public static void AttachInfo(string[] info, Dictionary<string, string> phoneBook)
        {
            if (phoneBook.Keys.Contains(info[1]))
            {
                phoneBook[info[1]] = info[2];
            }
            else
            {
                phoneBook.Add(info[1], info[2]);
            }
        }
    }
}
