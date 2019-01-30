using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Player
    {
        public static List<Card> startingDealPlayer(List<Card> deck)
        {
            List<Card> playerHand = new List<Card>();
            Deal.draw(deck, playerHand);
            Deal.draw(deck, playerHand);
            return playerHand;
        }
        public static int displaysPlayersCards(List<Card> playerHand, int playersHandValue)
        {
            Console.WriteLine("Your hand shows:");
            foreach (var card in playerHand)
            {
                Console.WriteLine(card.AscIIPicture);
                //Console.WriteLine("{1} {0}", card, card.NameAlphabetic);
                playersHandValue = playersHandValue + card.NumericValue;
            }

            return playersHandValue;
        }
    }
}
