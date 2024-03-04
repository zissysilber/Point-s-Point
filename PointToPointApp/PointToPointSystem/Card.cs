namespace PointToPointSystem
{
    public enum CardStatusEnum { flipped, notflipped }
    public class Card
    {
        private int _cardvalue;
        CardStatusEnum _cardstatus;
        public int CardValue { get => _cardvalue; set { _cardvalue = value; } }

        public CardStatusEnum CardStatus { get => _cardstatus; set { _cardstatus = value; } }

    }
}
