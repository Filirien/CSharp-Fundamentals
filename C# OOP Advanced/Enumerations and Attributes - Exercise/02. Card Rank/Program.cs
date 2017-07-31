using System;
public class Program
{
    public static void Main()
    {
        var suits = typeof(CardRanks);
        string[] cardSuitNames = Enum.GetNames(suits);
        Console.WriteLine($"Card Ranks:");
        foreach (var suit in cardSuitNames)
        {
            CardRanks color;
            var isValid = Enum.TryParse(suit, out color);
            if (isValid)
            {
                Console.WriteLine($"Ordinal value: {(int)color}; Name value: {suit}");

            }
        }
    }
}
