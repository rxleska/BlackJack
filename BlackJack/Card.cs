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
                    return "C";
                case SuitEnum.Diamond:
                    return "D";
                case SuitEnum.Heart:
                    return "H";
                case SuitEnum.Spade:
                    return "S";
                default:
                    return "";
            }
        }
    }
}