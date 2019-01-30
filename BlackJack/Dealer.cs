using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Dealer
    {
        public static List<Card> startingDealDealer(List<Card> deck)
        {
            List<Card> dealerHand = new List<Card>();
            Deal.draw(deck, dealerHand);
            Deal.draw(deck, dealerHand);
            return dealerHand;
        }
        public static void checkForDealerBust(ref bool dealerBusted, List<Card> dealerHand, ref int dealerHandValue)
        {
            foreach (var card in dealerHand)
            {
                Console.WriteLine(card.AscIIPicture);
                //Console.WriteLine("{1} {0}", card, card.NameAlphabetic);
                dealerHandValue = dealerHandValue + card.NumericValue;
            }
            if (dealerHandValue > 21)
            {
                Console.WriteLine("\nDealer Bust");
                dealerBusted = true;
            }
        }
        public static int showOneOfDealersCards(List<Card> dealerHand)
        {
            int dealerHandValue;
            //Displays one of the dealers cards and ?? ?? as the other card
            Console.WriteLine(dealerHand[0].AscIIPicture);
            //Console.WriteLine("{2}\n{1} {0}", dealerHand[0], dealerHand[0].NameAlphabetic, dealerHand[0].AscIIPicture);
            //Console.WriteLine("?? ??");
            // Calculates the dealers hand value
            dealerHandValue = dealerHand[1].NumericValue + dealerHand[0].NumericValue;
            return dealerHandValue;
        }
    }
}
