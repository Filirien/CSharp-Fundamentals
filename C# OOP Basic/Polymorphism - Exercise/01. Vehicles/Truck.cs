using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Vehicle
{
    private const double conditionerTruck = 1.6;
    private const double lostFuelFactor = 0.95;
    public Truck(double fuelQuantity, double littersPerKilometer) 
        : base(fuelQuantity, littersPerKilometer+1.6)
    {
    }
    public override void Refuel(double fuelAmount)
    {
        base.Refuel(fuelAmount*lostFuelFactor);
    }
}
