using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Mammal : Animal
{
    private string livingRegion;

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public Mammal(string animalName, string animalType,double animalWeight, string livingRegion)
        : base(animalName,animalType, animalWeight)
    {
        this.LivingRegion = livingRegion;
    }
    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.EatFood}]";
    }
}
