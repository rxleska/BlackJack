using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Shoe
    {
        public List<Card> cards { get; set; }

        public Shoe()
        {
            cards = new List<Card>();
        }

        public void GenerateDeck()
        {
            for (int numberOfDecks = 0; numberOfDecks < 4; numberOfDecks++)
            {
                for (int numberOfSuites = 0; numberOfSuites < 4; numberOfSuites++)
                {
                    for (int numberOfCardsPerSuit = 0; numberOfCardsPerSuit < 10; numberOfCardsPerSuit++)
                    {
                        Card y = new Card(numberOfCardsPerSuit + 1, (SuitEnum)numberOfSuites, (NameEnum)numberOfCardsPerSuit);
                        cards.Add(y);
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        Card y = new Card(10, (SuitEnum)numberOfSuites, (NameEnum)i + 10);
                        cards.Add(y);
                    }
                }
            }
        }
    }
}