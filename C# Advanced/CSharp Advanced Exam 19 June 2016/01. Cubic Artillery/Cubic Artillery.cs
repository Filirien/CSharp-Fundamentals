namespace _01.Cubic_Artillery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class CubicArtillery
    {
        public static void Main()
        {
            var capacity = int.Parse(Console.ReadLine());
            var queBunkers = new Queue<string>();
            var queWeapons = new Queue<int>();
            var currentCapacity = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Bunker Revision")
                {
                    break;
                }
                var elements = input.Split(' ');
                foreach (var element in elements)
                {

                    int weapon;
                    bool isNum = int.TryParse(element, out weapon);  //опитваме се да парснеме елемента към инт true а ако не стане false
                    if (isNum)
                    {
                        while (true)
                        {

                            if (currentCapacity + weapon > capacity)
                            {
                                if (queBunkers.Count == 1)
                                {
                                    if (weapon <= capacity)
                                    {
                                        queWeapons.Enqueue(weapon);
                                        currentCapacity += weapon;
                                        while (currentCapacity > capacity)
                                        {
                                            currentCapacity -= queWeapons.Dequeue();
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Write($"{queBunkers.Dequeue()} -> ");
                                    if (queWeapons.Count == 0)
                                    {
                                        Console.WriteLine("Empty");
                                    }
                                    else
                                    {
                                        Console.WriteLine(string.Join(", ", queWeapons));
                                    }
                                    queWeapons.Clear();
                                    currentCapacity = 0;
                                    continue;
                                }
                            }
                            else
                            {
                                queWeapons.Enqueue(weapon);
                                currentCapacity += weapon;
                            }
                            break;
                        }
                    }
                    else
                    {
                        queBunkers.Enqueue(element);
                    }
                }
            }
        }
    }
}
