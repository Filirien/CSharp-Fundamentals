namespace _3.DecimalToBinaryConverter
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
            int value = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(value, 2);
            Console.WriteLine(binary);
        }
    }
}
