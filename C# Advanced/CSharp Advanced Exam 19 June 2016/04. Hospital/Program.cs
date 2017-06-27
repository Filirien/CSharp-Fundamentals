using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<string, Dictionary<string, List<string>>>();
            var dicRooms = new Dictionary<string, Dictionary<int, string>>();
            var department = string.Empty;
            var doctor = string.Empty;
            var patient = string.Empty;
            var pacient = 0;
            var room = 1;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Output")
                {
                    break;
                }
                var input = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                department = input[0];
                doctor = input[1] + " " + input[2];
                patient = input[3];
                if (!dic.ContainsKey(department))
                {
                    dic[department] = new Dictionary<string, List<string>();
                    dicRooms[department] = new Dictionary<int, string>();
                    dic[department][doctor] = new List<string>();
                }
                dic[department][doctor].Add(patient);
            }
            var last = Console.ReadLine();


            foreach (var item in dic)
            {
                if (last == item.Key)
                {
                    foreach (var element in item.Value)
                    {
                        Console.WriteLine(element.Value);

                    }
                }
                else
                {

                    foreach (var elemenet in dic[department][doctor])
                    {
                        Console.WriteLine(string.Join("",elemenet));
                       
                    }
                }
            }
        }
    }
}