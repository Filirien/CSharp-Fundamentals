using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Felime
{
    private string breed;

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public Cat(string animalName, string animalType,double animalWeight, string livingRegion,string breed)
        : base(animalName, animalType, animalWeight, livingRegion)
    {
        this.Breed = breed;
    }
    public override void makeSound()
    {
        Console.WriteLine("Meowwww");
    }
    public override void Eat(Food food)
    {
        base.Eat(food);
    }
    public override string ToString()
    {
        return $"{this.AnimalType}[{this.AnimalName}, {this.breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.EatFood}]";
    }
}
