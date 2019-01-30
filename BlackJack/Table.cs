using System;
using System.Collections.Generic;

namespace BlackJack
{
    internal class Table
    {
        public static bool Restart()
        {
            bool continueProgram;
            Console.WriteLine("Would you like to restart? y/n");
            string continueQuestionNoCase = Console.ReadLine();
            string continueQuestionUpCase = continueQuestionNoCase.ToUpper();
            if (continueQuestionUpCase == "Y")
            {
                continueProgram = true;
            }
            else if (continueQuestionUpCase == "N")
            {
                continueProgram = false;
            }
            else
            {
                Console.WriteLine("didn't reconise answer exiting");
                continueProgram = false;
            }

            return continueProgram;
        }
        public static void CheckForWin(bool playerBusted, bool dealerBusted, int dealerHandValue, int playersHandValue)
        {
            
            if (playerBusted)
            {
                Console.WriteLine("\nYou Lose");
            }
            else if (dealerBusted)
            {
                Console.WriteLine("\nYou Win");
            }
            else if (dealerHandValue > playersHandValue)
            {
                Console.WriteLine("\nHouse Wins");
            }
            else if (dealerHandValue < playersHandValue)
            {
                Console.WriteLine("\nYou Win");
            }
            else
            {
                Console.WriteLine("\nPush");
            }
        }

        public static void checkPlayerForBust(ref bool askForHitAgain, ref bool playerBusted, ref bool aceInHand, List<Card> playerHand, ref int playersHandValue)
        {
            foreach (var card in playerHand)
            {
                int aceCheckCardSuit = card.NumericValue;
                if (aceCheckCardSuit == 11)
                {
                    aceInHand = true;
                }
            }

            if (playersHandValue > 21 && aceInHand == false)
            {
                Console.WriteLine("\nYou Busted");
                playerBusted = true;
                askForHitAgain = false;

            }
            else if (aceInHand == true)
            {
                playersHandValue = playersHandValue - 10;
                if (playersHandValue > 21)
                {
                    Console.WriteLine("\nYou Busted");
                    playerBusted = true;
                    askForHitAgain = false;
                }
            }
        }
    }
}