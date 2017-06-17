namespace _03.First_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ');
            var letters = Console.ReadLine()
                .Split(' ')
                .OrderBy(a => a);
            foreach (var letter in letters)
            {
                var result = input.
                    FirstOrDefault(w => w.ToLower()
                .StartsWith(letter.ToLower()));
                if (result!= null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine("No match");
        }
    }
}
