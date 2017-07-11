using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var carInformation = Console.ReadLine().Split(' ').ToList();
        Vehicle car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]));
        var truckInformation = Console.ReadLine().Split(' ').ToList();
        Vehicle truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]));

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var vehicle = input[1];
            if (vehicle == "Car")
            {
                
                ExecuteAction(car, input[0], double.Parse(input[2]));
            }
            else
            {
                ExecuteAction(truck, input[0], double.Parse(input[2]));
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
    }

    private static void ExecuteAction(Vehicle car, string command, double param)
    {
        switch (command)
        {
            case "Drive":
                var result = car.TryTravelDistance(param);
                Console.WriteLine(result);
                break;
            case "Refuel":
                car.Refuel(param);
                break;
        }
    }
}