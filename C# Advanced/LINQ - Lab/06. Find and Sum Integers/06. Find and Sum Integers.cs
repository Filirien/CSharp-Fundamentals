namespace _06.Find_and_Sum_Integers
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = input.Split(' ').Select(w =>
            {
                long value;
                bool success = long.TryParse(w, out value);
                return new  { value, success };
            })
            .Where(s => s.success)
            .Select(n=>n.value)
            .ToList();
            if (result.Count != 0)
            {
                Console.WriteLine(result.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
