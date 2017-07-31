using System;

public class Program
{
    public static void Main()
    {
        var suits = typeof(Suits);
        string[] cardSuitNames = Enum.GetNames(suits);
        Console.WriteLine($"Card Suits:");
        foreach (var suit in cardSuitNames)
        {
            Suits color;
            var isValid = Enum.TryParse(suit, out color);
            if (isValid)
            {
                Console.WriteLine($"Ordinal value: {(int)color}; Name value: {suit}");

            }
        }
    }
}
