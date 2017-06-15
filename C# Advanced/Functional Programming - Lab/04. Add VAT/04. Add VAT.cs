namespace _04.Add_VAT
{
    using System;
    using System.Linq;
    public class AddVAT
    {
        public static void Main()
        {
            var input = Console.ReadLine()
             .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
             .Select(double.Parse)
             .ToArray();
            Func<double, double> result = n => n*1.2;
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{result(input[i]):F2}");
            }
        }
    }
}
