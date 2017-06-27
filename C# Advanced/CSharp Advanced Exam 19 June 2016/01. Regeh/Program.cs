namespace _01.Regeh
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            var index = 0;
            var secondIndex = 0;
            var sum = 0;
            var pattern = @"\[(.[^\[!\s]+)<(\d+)REGEH(\d+)>(.+?)]";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                index = int.Parse(match.Groups[2].Value);
                sum += index+input.Length;
                sb.Append(input[sum%input.Length]);
            
                secondIndex = int.Parse(match.Groups[3].Value);
                sum += secondIndex+input.Length;
                sb.Append(input[sum%input.Length]);
              
            }
            Console.WriteLine(sb);

        }
    }
}