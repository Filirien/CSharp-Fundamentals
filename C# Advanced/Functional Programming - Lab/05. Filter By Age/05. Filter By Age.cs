namespace _05.Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FilterByAge
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, int>();

            for (int i = 0; i < n+1; i++)
            {
                var input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var age = int.Parse(input[1]);
                var name = input[0];
                dic[name] = age;
            }
                var condition =Console.ReadLine();
                Func<int, bool> tester = CreateTester(condition, age);
            
                Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

                PrintFilteredStudent(people, tester, printer);
            

            
        }

        private static void PrintFilteredStudent(object people, object tester, Action<KeyValuePair<string, int>> printer)
        {
            throw new NotImplementedException();
        }

        public static Action<KeyValuePair<string, int>>
                                CreatePrinter(string format)
        {
            switch (format)
    case "name":
                return person => Console.WriteLine($"{person.Key}");
            case "age":
                return person => Console.WriteLine($"{person.Value}");
            case "name age":
                return person =>
                   Console.WriteLine($"{person.Key} – {person.Value}");
            default: return null;
            }

            public static Func<int, bool> CreateTester
                     (string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;
                case "older": return x => x > age;
                default: return null;
            }
        }

    }
}
