namespace BlackJack
{
    public class Card
    {
        public int NumericValue { get; set; }
        public int SuitNumeric { get; set; }
        public string Suit { get; set; }
        public Card(int numericValue, int suit)
        {
            NumericValue = numericValue;
            SuitNumeric = suit;
            if (SuitNumeric == 0)
            {
                Suit = "Heart";
            }
            else if (SuitNumeric == 1)
            {
                Suit = "Club";
            }
            else if (SuitNumeric == 2)
            {
                Suit = "Diamond";
            }
            else if (SuitNumeric == 3)
            {
                Suit = "Spade";
            }
            else
            {
                return;
            }
        }
    }
}