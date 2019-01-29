namespace BlackJack
{
    public class Card
    {
        public int NumericValue { get; set; }
        public SuitEnum SuitNumeric { get; set; }
        public string Suit { get { return SuitNumeric.ToString(); } }
        public NameEnum NameAlphabetic { get; set; }
        public Card(int numericValue, SuitEnum suit, NameEnum cardName)
        {
            if (numericValue == 1)
            {
                NumericValue = 11;
            }
            else
            {
                NumericValue = numericValue;
            }
            SuitNumeric = suit;
            NameAlphabetic = cardName;
            
        }
        public override string ToString()
        {
            switch (this.SuitNumeric)
            {
                case SuitEnum.Club:
                    return "of Clubs";
                case SuitEnum.Diamond:
                    return "of Diamonds";
                case SuitEnum.Heart:
                    return "of Hearts";
                case SuitEnum.Spade:
                    return "of Spades";
                default:
                    return "";
            }
        }
    }
}