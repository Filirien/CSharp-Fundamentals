using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    private const double conditionerCar = 0.9;
    public Car(double fuelQuantity, double littersPerKilometer, double tankCapacity)
        : base(fuelQuantity, littersPerKilometer + conditionerCar, tankCapacity)
    {

    }
    public override double FuelQuantity
    {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit in tnak!");
            }
            base.FuelQuantity = value;
        }
    }
}
