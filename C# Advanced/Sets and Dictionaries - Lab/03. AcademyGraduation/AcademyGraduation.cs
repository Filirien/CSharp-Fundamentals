namespace _04.AcademyGraduation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class AcademyGraduation
    {
        public static void Main()
        {
            var dic = new SortedDictionary<string, double>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split(' ').Select(double.Parse).Average();
                dic[name] = grades;
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} is graduated with {item.Value}");
            }
        }
    }
}