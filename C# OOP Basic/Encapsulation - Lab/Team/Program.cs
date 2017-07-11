using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var firstTeam = new Team("Niki");

        for (int i = 0; i < lines; i++)
        {

            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));

            firstTeam.AddPlayer(person);
        }
        Console.WriteLine(firstTeam);
    }
}
