using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    class Program
    {
        public static System.Text.Encoding Unicode { get; }
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
                //bool
                //bool aceInHand = false;


                var deck = decks.cards;

                int cardNumber = -1;
                foreach (var card in deck)
                {
                    cardNumber++;
                    AscIICardPictures.findAscIIPicture(deck, cardNumber);
                }

                /*foreach (var card in deck)
                {
                    Console.WriteLine("{0}{1}{2}{3}",card.NameAlphabetic,card.NumericValue,card.Suit,card.AscIIPicture);
                }*/

                
                //Draws 2 cards and puts them in list players hand
                List<Card> playerHand = Player.startingDealPlayer(deck);

                //Draws 2 cards and puts them in the list dealers hand
                List<Card> dealerHand = Dealer.startingDealDealer(deck);

                int dealerHandValue = 0;
                dealerHandValue = Dealer.showOneOfDealersCards(dealerHand);

                //Displays the value of the dealers showing card
                Console.WriteLine("\nDealer Shows " + dealerHand[0].NumericValue + "\n");

                //Displays all of the players cards
                int playersHandValue = 0;
                playersHandValue = Player.displaysPlayersCards(playerHand, playersHandValue);

                //Displays Players Hand Value
                Console.WriteLine("\nYou drew " + playersHandValue + "\n");
                if (playersHandValue == 21)
                {
                    Console.WriteLine("Black Jack!!!\nYou Win!!!\n");
                }
                else
                {
                    int timesThroughTheHitOrMissLoop = 1;
                    do
                    {
                        if (playersHandValue > 21)
                        {
                            Console.WriteLine("Player Busted");
                            playerBusted = true;
                            break;
                        }
                        else if (playersHandValue == 21)
                        {
                            break;
                        }
                        Deal.askForHitOrStay(ref askForHitAgain, deck, playerHand, ref playersHandValue, ref timesThroughTheHitOrMissLoop);
                    } while (askForHitAgain);
                    if (playersHandValue == 21)
                    {
                        Console.WriteLine("Black Jack!!!\nYou Win!!!\n");
                    }
                    else
                    {
                        Console.WriteLine();

                        int timesThroughTheDealerLessThanLoop = 1;
                        if (playerBusted == false)
                        {
                            Deal.checkForDraw(ref dealerNeedsToDraw, deck, dealerHand, ref dealerHandValue, ref timesThroughTheDealerLessThanLoop);

                            Console.WriteLine("Dealer Has\n");
                            dealerHandValue = dealerHandValue - dealerHandValue;

                            Dealer.checkForDealerBust(ref dealerBusted, dealerHand, ref dealerHandValue);
                        }

                        Table.CheckForWin(playerBusted, dealerBusted, dealerHandValue, playersHandValue);
                    }
                }
                    
    
                continueProgram = Table.Restart();

            } while (continueProgram);
            
        }

        
    }
    
}
