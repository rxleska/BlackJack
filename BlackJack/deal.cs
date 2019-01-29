﻿using System;
using System.Collections.Generic;
namespace BlackJack
{
    public class Deal
    {
        public static void checkForDraw(ref bool dealerNeedsToDraw, List<Card> deck, List<Card> dealerHand, ref int dealerHandValue, ref int timesThroughTheDealerLessThanLoop)
        {
            while (dealerNeedsToDraw)
            {
                timesThroughTheDealerLessThanLoop++;
                if (dealerHandValue <= 16)
                {
                    draw(deck, dealerHand);
                    dealerHandValue = dealerHandValue + dealerHand[timesThroughTheDealerLessThanLoop].NumericValue;
                }
                else
                {
                    //breaks loop
                    dealerNeedsToDraw = false;
                }
            }
        }
        public static void draw(List<Card> deck, List<Card> yourHand)
        {
            Random rnd = new Random();
            int z = rnd.Next(0, deck.Count);
            var selected = deck[z];
            yourHand.Add(selected);
            deck.Remove(deck[z]);
        }
        public static void askForHitOrStay(ref bool askForHitAgain, List<Card> deck, List<Card> playerHand, ref int playersHandValue, ref int timesThroughTheHitOrMissLoop)
        {
            Console.WriteLine("Hit or Stay (\"H\" or \"hit\" to hit/\"S\" or \"stay\" to stay)");
            string hitOrMissNoCase = Console.ReadLine();
            string hitOrMissUpCase = hitOrMissNoCase.ToUpper();

            if (hitOrMissUpCase == "H" || hitOrMissUpCase == "HIT")
            {
                //Adds a card to players Hand then diplays the new card
                timesThroughTheHitOrMissLoop++;
                Deal.draw(deck, playerHand);
                Console.WriteLine("\nYou Drew a {1} of {0}", playerHand[timesThroughTheHitOrMissLoop],
                                                           playerHand[timesThroughTheHitOrMissLoop].NumericValue);

                //Displays all of the players cards

                playersHandValue = 0;
                playersHandValue = Player.displaysPlayersCards(playerHand, playersHandValue);
                Console.WriteLine("\nYour Hand Value is {0}", playersHandValue);


            }
            //Exits the doWhile Loop
            else if (hitOrMissUpCase == "S" || hitOrMissUpCase == "STAY")
            {
                askForHitAgain = false;
            }
            //Displays error message then restarts the loop
            else
            {
                Console.WriteLine("Player System didn't Reconize Answer");
            }
        }
    }
}