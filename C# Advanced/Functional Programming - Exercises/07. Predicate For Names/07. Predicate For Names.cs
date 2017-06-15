namespace _07.Predicate_For_Names
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Length>n)
                {
                    names.Remove(names[i]);
                    i--;
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

    }
}
    