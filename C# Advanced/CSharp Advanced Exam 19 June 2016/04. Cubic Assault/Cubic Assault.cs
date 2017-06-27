namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CubicAssault
    {
        public static void Main()
        {
            var dic = new Dictionary<string, Dictionary<string, long>>();
            while (true)
            {
                var redMeteors = 0;
                var blackMeteors = 0;
                var greenMeteors = 0;
                var line = Console.ReadLine();
                if (line == "Count em all")
                {
                    break;
                }
                var input = line.Split(new string[] {" -> " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var regionName = input[0];
                var meteorType = input[1];
                var countMeteors = int.Parse(input[2]);
                // създаваме ги
                if (!dic.ContainsKey(regionName))
                {
                    dic[regionName] = new Dictionary<string, long>();

                    dic[regionName].Add("Green", 0);
                    dic[regionName].Add("Red", 0);
                    dic[regionName].Add("Black", 0);
                }

                if (meteorType == "Green")
                {
                    dic[regionName][meteorType] += countMeteors;
                }
                //RED
                else if (meteorType == "Red")
                {
                    dic[regionName][meteorType] += countMeteors;
                }
                // black
                else
                {
                    dic[regionName][meteorType] += countMeteors;
                }
                var greenAddition = dic[regionName]["Green"] / 1000000;
                dic[regionName]["Green"] %= 1000000;
                dic[regionName]["Red"] += greenAddition;
                var redAddition = dic[regionName]["Red"] / 1000000;
                dic[regionName]["Red"] %= 1000000;
                dic[regionName]["Black"] += redAddition;
            }
            // print
            foreach (var element in dic.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{element.Key}");
                foreach (var item in element.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {item.Key} : {item.Value}");
                }
            }
        }
        
    }
}
