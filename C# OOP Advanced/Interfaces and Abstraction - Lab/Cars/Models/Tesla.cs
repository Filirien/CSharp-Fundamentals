using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tesla : IElectricCar, ICar
{
    public string Model { get; }
    public string Color { get; }
    public int Battery { get; }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    public string Start()
    {
        return $"Engine start";
    }

    public string Stop()
    {
        return $"Breaaak!";
    }

    public override string ToString()
    {
        return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries{Environment.NewLine}" +
               $"{Start()}{Environment.NewLine}" +
               $"{Stop()}";
    }

}
