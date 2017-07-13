using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string animalInfo = Console.ReadLine();

        while (animalInfo != "End")
        {
            string[] animalArgs = animalInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Mammal animal;

            if (animalArgs[0] == "Mouse")
            {
                animal = new Mouse(animalArgs[1], animalArgs[0],double.Parse(animalArgs[2]), animalArgs[3]);
            }
            else if (animalArgs[0] == "Zebra")
            {
                animal = new Zebra(animalArgs[1], animalArgs[0], double.Parse(animalArgs[2]), animalArgs[3]);
            }
            else if (animalArgs[0] == "Cat")
            {
                animal = new Cat(animalArgs[1], animalArgs[0],double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
            }
            else
            {
                animal = new Tiger(animalArgs[1], animalArgs[0],double.Parse(animalArgs[2]), animalArgs[3]);
            }

            string[] foodArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Food food;

            if (foodArgs[0] == "Vegetable")
            {
                food = new Vegetable(int.Parse(foodArgs[1]));
            }
            else
            {
                food = new Meat(int.Parse(foodArgs[1]));
            }

            try
            {
                animal.makeSound();
                animal.Eat(food);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            Console.WriteLine(animal.ToString());

            animalInfo = Console.ReadLine();
        }
    }
}

