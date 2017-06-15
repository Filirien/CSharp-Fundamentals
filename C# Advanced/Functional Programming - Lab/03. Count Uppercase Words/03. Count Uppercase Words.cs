namespace _03.Count_Uppercase_Words
{
    using System;
    using System.Linq;
    public class CountUppercaseWords
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            input.Where(checker)
                .ToList()
                .ForEach(n => Console.WriteLine(n));
        }

    }

}
