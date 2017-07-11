using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public abstract class Vehicle
{
    public Vehicle(double fuelQuantity,double littersPerKilometer)
    {
        this.FuelQuantity = fuelQuantity;
        this.LittersPerKilometer = littersPerKilometer;
    }
    public double FuelQuantity { get; set; }
    public double LittersPerKilometer { get; set; }
    
    private bool Drive (double distance)
    {
        var fuelRequired = distance * this.LittersPerKilometer;
        if (fuelRequired <=this.FuelQuantity)
        {
            this.FuelQuantity -= fuelRequired;
            return true;
        }
        return false;
    }
    public string TryTravelDistance(double distance)
    {
        if (this.Drive(distance))
        {
            return $"{this.GetType().Name} travelled {distance} km";

        }
        return $"{this.GetType().Name} needs refueling";
    }
    public virtual void Refuel (double fuelAmount)
    {
        this.FuelQuantity += fuelAmount;
    }
    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
