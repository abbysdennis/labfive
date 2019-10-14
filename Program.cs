using System;

namespace LabFive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Creation of all the new string values
            string[] deck = new string[52];
            string[] suits = { "Hearts", "Spades", "Diamonds", "Clubs" };
            string[] cards = { "Ace", "King", "Queen", "Jack", "Ten", "Nine", "Eight", "Seven", "Six", "Five", "Four", "Three", "Two" };

            CreateDeck(suits, cards, deck);

            PrintDeck(deck);

            ShuffleDeck(deck);

            PrintDeck(deck);

            Console.ReadKey();
        }

        //This portion of the code creates the initial deck of cards
        public static void CreateDeck(string[] suits, string[] cards, string[] deck)
        {
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    deck[count] = cards[j] + " of " +  suits[i];
                    count++;
                }
            }
        }

        //This portion of the code prints the deck
        public static void PrintDeck(string[] deck)
        {
            Console.WriteLine("Deck: ");
            for (int i = 0; i < 52; i++)
            {
                Console.WriteLine(deck[i]);
            }
            Console.WriteLine("");
        }

        //This portion of the code shuffles the deck
        public static void ShuffleDeck(string[] deck)
        {
            Random r = new Random();
            for (int i = 0; i < 52; i++)
            {
                int j = r.Next(52);
                Swap(deck, i, j);
            }
        }

        //This portion of the code swaps the placement; part of the ShuffleDeck method
        public static void Swap(string[] suits, int i, int j)
        {
            string temp = suits[i];
            suits[i] = suits[j];
            suits[j] = temp;
        }
     
    }
}
