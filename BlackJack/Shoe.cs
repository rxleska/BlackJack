using System;
using System.Collections.Generic;

namespace BlackJack
{
    internal class Shoe
    {
        public List<Card> cards { get; set; }

        public Shoe()
        {
            cards = new List<Card>();
        }

        public void GenerateDeck()
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 13; x++)
                {
                    Card y = new Card(x + 1, (SuitEnum)i);
                    cards.Add(y);
                }
            }
        }
    }
}