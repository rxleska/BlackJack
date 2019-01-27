using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe decks = new Shoe();
            decks.GenerateDeck();

            var deck = decks.cards;
            //DrawCardDisplayDeck(deck);



            Console.ReadLine();
        }

        private static void DrawCardDisplayDeck(List<Card> deck)
        {
            Random rnd = new Random();
            int z = rnd.Next(0, deck.Count);

            Console.WriteLine("{0} {1}", deck[z], deck[z].NumericValue);

            deck.Remove(deck[z]);

            Console.WriteLine("\n");

            foreach (var card in deck)
            {
                Console.WriteLine("{0} {1}", card, card.NumericValue);
            }
        }
    }
    
}
