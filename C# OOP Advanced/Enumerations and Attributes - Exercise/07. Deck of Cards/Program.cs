using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        string command = Console.ReadLine();

        if (command == "Card Deck")
        {
            foreach (var rank in Enum.GetValues(typeof(CardRanks)))
            {
                Console.WriteLine($"{rank} of {Suits.Clubs}");
            }
            foreach (var rank in Enum.GetValues(typeof(CardRanks)))
            {
                Console.WriteLine($"{rank} of {Suits.Diamonds}");
            }
            foreach (var rank in Enum.GetValues(typeof(CardRanks)))
            {
                Console.WriteLine($"{rank} of {Suits.Hearts}");
            }
            foreach (var rank in Enum.GetValues(typeof(CardRanks)))
            {
                Console.WriteLine($"{rank} of {Suits.Spades}");
            }
        }
    }
}
