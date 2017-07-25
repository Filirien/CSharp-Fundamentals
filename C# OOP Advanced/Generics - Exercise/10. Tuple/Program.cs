using System;
using System.Runtime.InteropServices;

public class Startup
{
    public static void Main()
    {
        string[] tuple1Args = Console.ReadLine().Split();
        var tuple1 = new Threeuple<string, string, string>(tuple1Args[0],tuple1Args[1], tuple1Args[2]);

        string[] tuple2Args = Console.ReadLine().Split();
        var tuple2 = new Tuple<string, int>(tuple2Args[0], int.Parse(tuple2Args[1]));

        string[] tuple3Args = Console.ReadLine().Split();
       var tuple3 = new Tuple<int, double>(int.Parse(tuple3Args[0]), double.Parse(tuple3Args[1]));

        Console.WriteLine($"{tuple1.Item1} {tuple1.Item2} -> {tuple1.Item3}");
        Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");
        Console.WriteLine($"{tuple3.Item1} -> {tuple3.Item2}");
    }
}