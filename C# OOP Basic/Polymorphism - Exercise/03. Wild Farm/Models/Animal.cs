using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal
{
    private string animalName;
    private string  animalType;
    private double animalWeight;
    private int eatFood;

    public Animal(string animalName,string animalType, double animalWeight)
    {
        this.AnimalName = animalName;
        this.AnimalWeight = animalWeight;
        this.AnimalType = animalType;
    }
    public int EatFood
    {
        get { return eatFood; }
        set { eatFood = value; }
    }


    public double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }


    public string  AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }
     
    public virtual void makeSound()
    {
        
    }
    public virtual void Eat(Food foodQuantity)
    {
        this.eatFood += foodQuantity.QuantityFood;
    }
}
