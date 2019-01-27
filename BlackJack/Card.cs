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