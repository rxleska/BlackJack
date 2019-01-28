using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool continueProgram = true;
            do
            {
                Console.Clear();
                Shoe decks = new Shoe();
                decks.GenerateDeck();

                bool dealerNeedsToDraw = true;
                bool askForHitAgain = true;
                bool playerBusted = false;
                bool dealerBusted = false;
                bool aceInHand = false;
                

                var deck = decks.cards;
                //DrawCardDisplayDeck(deck);

                //Draws 2 cards and puts them in list players hand
                List<Card> playerHand = new List<Card>();
                draw(deck, playerHand);
                draw(deck, playerHand);

                //Draws 2 cards and puts them in the list dealers hand
                List<Card> dealerHand = new List<Card>();
                draw(deck, dealerHand);
                draw(deck, dealerHand);


                int dealerHandValue = 0;


                //Displays one of the dealers cards and ?? ?? as the other card
                Console.WriteLine("{0} {1}", dealerHand[0], dealerHand[0].NameAlphabetic);
                Console.WriteLine("?? ??");
                // Calculates the dealers hand value
                dealerHandValue = dealerHand[1].NumericValue + dealerHand[0].NumericValue;

                //Displays the value of the dealers showing card
                Console.WriteLine("\nDealer Shows " + dealerHand[0].NumericValue + "\n");

                //Displays all of the players cards
                int playersHandValue = 0;
                playersHandValue = displaysPlayersCards(playerHand, playersHandValue);

                //Displays Players Hand Value
                Console.WriteLine("\nYou drew " + playersHandValue + "\n");


                // doWhile Loop ask for hit or stay
                int timesThroughTheHitOrMissLoop = 1;
                do
                {
                    Console.WriteLine("Hit or Stay (H or hit to hit/S or stay to stay)");
                    string hitOrMissNoCase = Console.ReadLine();
                    string hitOrMissUpCase = hitOrMissNoCase.ToUpper();

                    if (hitOrMissUpCase == "H" || hitOrMissUpCase == "HIT")
                    {
                        //Adds a card to players Hand then diplays the new card
                        timesThroughTheHitOrMissLoop++;
                        draw(deck, playerHand);
                        Console.WriteLine("\nYou Drew a {1} of {0}", playerHand[timesThroughTheHitOrMissLoop],
                                                                   playerHand[timesThroughTheHitOrMissLoop].NumericValue);

                        //Displays all of the players cards
                        playersHandValue = 0;
                        playersHandValue = displaysPlayersCards(playerHand, playersHandValue);
                        Console.WriteLine("\nYour Hand Value is {0}", playersHandValue);
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
                        }
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
                } while (askForHitAgain);

                Console.WriteLine();

                int timesThroughTheDealerLessThanLoop = 1;

                // while loop to check if dealer need to hit or stay
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

                Console.WriteLine("Dealer Has\n");
                dealerHandValue = dealerHandValue - dealerHandValue;
                foreach (var card in dealerHand)
                {
                    Console.WriteLine("{0} {1}", card, card.NameAlphabetic);
                    dealerHandValue = dealerHandValue + card.NumericValue;
                }
                if (dealerHandValue > 21)
                {
                    Console.WriteLine("\nDealer Bust");
                    dealerBusted = true;
                }



                if (dealerHandValue > playersHandValue && dealerBusted == false || playerBusted == true)
                {
                    Console.WriteLine("\nHouse Wins");
                }
                else if (dealerHandValue < playersHandValue && playerBusted == false || dealerBusted == true)
                {
                    Console.WriteLine("\nYou Win");
                }
                else
                {
                    Console.WriteLine("\nPush");
                }

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
            } while (continueProgram);
        }

        private static int displaysPlayersCards(List<Card> playerHand, int playersHandValue)
        {
            Console.WriteLine("Your hand shows:");
            foreach (var card in playerHand)
            {
                Console.WriteLine("{0} {1}", card, card.NameAlphabetic);
                playersHandValue = playersHandValue + card.NumericValue;

            }

            return playersHandValue;
        }

        public static void draw(List<Card> deck, List<Card> yourHand)
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
