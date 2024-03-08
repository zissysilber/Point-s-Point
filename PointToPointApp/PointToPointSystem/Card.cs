using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{

    public enum CardStatusEnum { flipped, notflipped }
    public enum CardTypeEnum { image, name }
    public class Card : INotifyPropertyChanged
    {

        private int _cardvalue;
        public CardStatusEnum cardstatus;
        public int CardValue
        {
            get => _cardvalue;
            set
            {
                _cardvalue = value;
            }
        }

        public CardStatusEnum CardStatus
        {
            get => cardstatus;
            set
            {
                cardstatus = value;
            }
        }
        public CardTypeEnum CardType { get; set; }

        public string ImageName { get; set; } = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }
}
