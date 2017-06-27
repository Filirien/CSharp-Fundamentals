namespace _03.Cubic_Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class CubicMessages
    {
        public static void Main()
        {
            while (true)
            {
                var crypted = Console.ReadLine();
                var message = string.Empty;
                if (crypted == "Over!")
                {
                    break;
                }
                var m = int.Parse(Console.ReadLine());
                var regex = new Regex(@"(^\d+)([A-Za-z]+)(\d*)[^A-Za-z]*$");
                var matches = regex.Matches(crypted);
                if (matches.Count == 0)
                {
                    continue;
                }

                foreach (Match match in matches)
                {
                    if (match.Groups[2].Length != m)
                    {
                        break;
                    }
                    var leftIndex = match.Groups[1].Value;
                    var word = match.Groups[2].Value.ToList();
                    var rightIndex = match.Groups[3].Value;
                    var all = leftIndex + rightIndex;
                    var ds = all.ToCharArray().Select(x => int.Parse("" + x)).ToList();
                    for (int i = 0; i < ds.Count; i++)
                    {
                        if (ds[i] >= m)
                        {
                            message += " ";
                            continue;
                        }
                        var index = word[ds[i]];
                        message += index;
                    }
                    Console.Write($"{string.Join("", word)} == ");
                    Console.WriteLine(message);
                }
            }
        }
    }
}
