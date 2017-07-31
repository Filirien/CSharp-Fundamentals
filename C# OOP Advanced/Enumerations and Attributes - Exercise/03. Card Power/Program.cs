using System;
public class StartUp
{
    public static void Main()
    {
        var firstLine = Console.ReadLine();
        var secLine = Console.ReadLine();

        var suits = typeof(CardRanks);
        string[] cardSuitNames = Enum.GetNames(suits);
        var sum = 0;
        CardRanks rankPower;
        var isValidRank = Enum.TryParse(firstLine, out rankPower);
        if (isValidRank)
        {
            sum = (int)rankPower;
        }
        Suits suitPower;
        var isValidSuit = Enum.TryParse(secLine, out suitPower);
        if (isValidSuit)
        {
            sum += (int)suitPower;
        }
        Console.WriteLine($"Card name: {firstLine} of {secLine}; Card power: {sum}");
    }
}
