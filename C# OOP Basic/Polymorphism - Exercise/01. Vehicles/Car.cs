using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    private const double conditionerCar = 0.9;
    public Car(double fuelQuantity, double littersPerKilometer)
        : base(fuelQuantity, littersPerKilometer+conditionerCar)
    {
        
    }
}
