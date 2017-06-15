namespace _01.Action_Print
{
    using System;
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
            var result = a.Split(' ');
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
