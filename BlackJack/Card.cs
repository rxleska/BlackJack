namespace BlackJack
{
    public class Card
    {
        public int NumericValue { get; set; }
        public SuitEnum SuitNumeric { get; set; }
        public string Suit { get { return SuitNumeric.ToString(); } }
        public Card(int numericValue, SuitEnum suit)
        {
            NumericValue = numericValue;
            SuitNumeric = suit;
            
        }
    }
}