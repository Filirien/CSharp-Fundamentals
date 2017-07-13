using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mouse : Mammal
{
    public Mouse(string animalName, string animalType, double animalWeight, string livingRegion) 
        : base(animalName,animalType, animalWeight, livingRegion)
    {
    }
    public override void makeSound()
    {
        Console.WriteLine($"SQUEEEAAAK!");
    }
    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Vegetable")
        {
            throw new ArgumentException($"{this.GetType().Name}s are not eating that type of food!");
        }

        base.Eat(food);
    }

    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.EatFood}]";
    }
}
