using System;
using System.Collections.Generic;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Card> deck = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    Card y = new Card(x + 1, i );
                    deck.Add(y);

                }
            }
            Random rnd = new Random();
            int z = rnd.Next(0, 25);

            
            Console.WriteLine("{0} {1}", deck[z].Suit, deck[z].NumericValue);

            deck.Remove(deck[z]);

            Console.WriteLine("\n");

            foreach (var card in deck) {
                Console.WriteLine("{0} {1}", card.Suit, card.NumericValue);
            }

            Console.ReadLine();
        }
    }
    
}
