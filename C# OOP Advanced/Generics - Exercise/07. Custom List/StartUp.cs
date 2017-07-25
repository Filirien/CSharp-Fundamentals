using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        var customList = new CustomList<string>();

        string inputLine = Console.ReadLine();
        while (inputLine != "END")
        {
            string[] commandArgs = inputLine.Split();
            string commandName = commandArgs[0];

            switch (commandName)
            {
                case "Add":
                    string currentElement = commandArgs[1];
                    customList.Add(currentElement);
                    break;
                case "Remove":
                    int targetRemoveIndex = int.Parse(commandArgs[1]);
                    customList.Remove(targetRemoveIndex);
                    break;
                case "Contains":
                    string targetElement = commandArgs[1];
                    Console.WriteLine(customList.Contains(targetElement));
                    break;
                case "Swap":
                    int firstIndex = int.Parse(commandArgs[1]);
                    int secondIndex = int.Parse(commandArgs[2]);
                    customList.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    string element = commandArgs[1];
                    Console.WriteLine(customList.CountGreaterThan(element));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                
                case "Print":
                    foreach (var item in customList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }

            inputLine = Console.ReadLine();
        }
    }
}
