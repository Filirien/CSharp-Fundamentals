using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        // Initialize deck
        var cardRankNames = Enum.GetNames(typeof(CardRanks));
        var cardSuitNames = Enum.GetNames(typeof(Suits));
        var deck = new Dictionary<string, Card>();

        for (int i = 0; i < cardSuitNames.Length; i++)
        {
            string currentCardSuit = cardSuitNames[i];

            for (int j = 0; j < cardRankNames.Length; j++)
            {
                string currentCardRank = cardRankNames[j];
                deck.Add($"{currentCardRank} of {currentCardSuit}", new Card(currentCardRank, currentCardSuit));
            }
        }

        // Get player names
        string firstPlayer = Console.ReadLine();
        string secondPlayer = Console.ReadLine();

        // Get player cards
        List<Card> firstPlayerCards = new List<Card>();
        GetCardsForPlayer(firstPlayerCards, deck);

        List<Card> secondPlayerCards = new List<Card>();
        GetCardsForPlayer(secondPlayerCards, deck);

        // Get players most powered card
        Card firstPlayerMaxMostPoweredCard = firstPlayerCards.Max();
        Card secondPlayerMostPoweredCard = secondPlayerCards.Max();

        if (firstPlayerMaxMostPoweredCard.CompareTo(secondPlayerMostPoweredCard) > 0)
        {
            Console.WriteLine(
                $"{firstPlayer} wins with {firstPlayerMaxMostPoweredCard.Rank} of {firstPlayerMaxMostPoweredCard.Suit}.");
        }
        else
        {
            Console.WriteLine(
                $"{secondPlayer} wins with {secondPlayerMostPoweredCard.Rank} of {secondPlayerMostPoweredCard.Suit}.");
        }
    }

    public static void GetCardsForPlayer(List<Card> playerCards, Dictionary<string, Card> availableCards)
        {
            while (playerCards.Count < 5)
            {
                string targetCard = Console.ReadLine();
                if (availableCards.ContainsKey(targetCard))
                {
                    if (availableCards[targetCard] == null)
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        playerCards.Add(availableCards[targetCard]);
                        availableCards[targetCard] = null;
                    }
                }
                else
                {
                    Console.WriteLine("No such card exists.");
                }
            }
        }
    }