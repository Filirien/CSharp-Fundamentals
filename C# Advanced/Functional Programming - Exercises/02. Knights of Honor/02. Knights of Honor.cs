
namespace _02.Knights_of_Honor
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
            var print = Console.ReadLine();

            Action<string> names = Names;
            names(print);
        }

        public static void Names(string a)
        {
            var result = a.Split(new [] {' '},StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
            foreach (var item in result)
            {
                Console.WriteLine($"Sir {item}");
            }
        }
    }
}
