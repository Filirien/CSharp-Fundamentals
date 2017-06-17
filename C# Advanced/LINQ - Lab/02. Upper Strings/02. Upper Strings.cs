namespace _02.Upper_Strings
{
    using System;
    using System.Linq;
    public class UpperStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split()
                .ToList();

                input.Select(a => a.ToUpper())
                .ToList()
                .ForEach(a => Console.Write(a + " "));
        }
    }
}
