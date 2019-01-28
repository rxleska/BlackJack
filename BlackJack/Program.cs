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

            List<Card> playerHand = new List<Card>();
            draw(deck, playerHand);
            draw(deck, playerHand);


            int playersHandValue = 0;
            foreach (var card in playerHand)
            {
                Console.WriteLine("{0} {1}", card, card.NameAlphabetic);
                playersHandValue = playersHandValue + card.NumericValue; 
            }
            
            Console.WriteLine("\n"+playersHandValue+"\n");


            foreach (var card in deck)
            {
                Console.WriteLine("{0} {1}", card, card.NameAlphabetic);
            }

            Console.ReadLine();
        }

        private static void draw(List<Card> deck, List<Card> yourHand)
        {
            Random rnd = new Random();
            int z = rnd.Next(0, deck.Count);
            var selected = deck[z];
            yourHand.Add(selected);
            deck.Remove(deck[z]);
        }

        private static void DrawCardDisplayDeck(List<Card> deck)
        {
            Random rnd = new Random();
            int z = rnd.Next(0, deck.Count);

            Console.WriteLine("{0} {1}", deck[z], deck[z].NameAlphabetic);

            deck.Remove(deck[z]);

            Console.WriteLine("\n");

            foreach (var card in deck)
            {
                Console.WriteLine("{0} {1}", card, card.NameAlphabetic);
            }
        }
    }
    
}
