using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bus : Vehicle
{
    private const double conditionerBus = 1.4;
    public Bus(double fuelQuantity, double littersPerKilometer, double tankCapacity)
        : base(fuelQuantity, littersPerKilometer, tankCapacity)
    {

    }
    public override double FuelQuantity
    {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tnak!");
            }
            base.FuelQuantity = value;
        }
    }
    public override bool Drive(double distance, bool isAcOn)
    {
        double requiredFuel = 0;
        if (isAcOn)
        {
            requiredFuel = distance * (this.LittersPerKilometer + conditionerBus);
        }
        else
        {
            requiredFuel = distance * this.LittersPerKilometer;
        }
        if (requiredFuel <= this.FuelQuantity)
        {
            this.FuelQuantity -= requiredFuel;
            return true;
        }
        return false;

    }
}
