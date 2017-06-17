namespace _05.Min_Even_Number
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            try
            {
                var input = Console.ReadLine()
               .Split().Select(double.Parse)
               .Where(a => a % 2 == 0)
               .Min();
                Console.WriteLine($"{input:f2}");
            }

            catch (Exception)
            {

                Console.WriteLine("No match");
            }
        }
    }
}
