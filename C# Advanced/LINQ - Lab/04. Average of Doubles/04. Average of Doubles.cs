namespace _04.Average_of_Doubles
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{input:F2}");
        }
    }
}
