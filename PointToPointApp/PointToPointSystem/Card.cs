using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{

    public enum CardStatusEnum { flipped, notflipped }
    public class Card : INotifyPropertyChanged
    {
        private int _cardvalue;
         public CardStatusEnum cardstatus;
        public int CardValue { get => _cardvalue; set { _cardvalue = value; } }

        public CardStatusEnum CardStatus
        {
            get => cardstatus;
            set
            {
                cardstatus = value;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }
}
