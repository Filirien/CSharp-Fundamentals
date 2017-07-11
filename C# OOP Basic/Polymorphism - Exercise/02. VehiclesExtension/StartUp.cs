using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var carInformation = Console.ReadLine().Split(' ').ToList();
        Vehicle car = new Car(double.Parse(carInformation[1]), double.Parse(carInformation[2]),double.Parse(carInformation[3]));
        var truckInformation = Console.ReadLine().Split(' ').ToList();
        Vehicle truck = new Truck(double.Parse(truckInformation[1]), double.Parse(truckInformation[2]),double.Parse(carInformation[3]));
        var busInfo = Console.ReadLine().Split(' ').ToList();
        Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            try
            {


                var input = Console.ReadLine().Split(' ').ToList();
                var vehicle = input[1];
                if (vehicle == "Car")
                {

                    ExecuteAction(car, input[0], double.Parse(input[2]));
                }
                else if (vehicle == "Truck")
                {
                    ExecuteAction(truck, input[0], double.Parse(input[2]));
                }
                else if ( vehicle == "Bus")
                {
                    ExecuteAction(bus, input[0], double.Parse(input[2]));
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine(car);
        Console.WriteLine(truck);
        Console.WriteLine(bus);
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
            case "DriveEmpty":

                Console.WriteLine(car.TryTravelDistance(param,false));
                break;
        }
    }
}