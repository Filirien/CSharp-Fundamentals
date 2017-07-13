using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var foods = Console.ReadLine().Split(' ').ToList();
        var mood = new MoodFactory();
        var points = 0;
        for (int i = 0; i < foods.Count; i++)
        {
            var foodFactory = new FoodFactory();
            Food food = foodFactory.GetFood(foods[i]);
            points += food.GetHappinessPoints();
        }
        Console.WriteLine(points);
        Console.WriteLine(mood.GetMood(points));
    }
}

