using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{

    public enum CardStatusEnum { flipped, notflipped }
    public enum CardTypeEnum { image, name }
    public class Card : INotifyPropertyChanged
    {

        private int _cardvalue;
        public CardStatusEnum CardStatus { get; set; }
        public int CardValue
        {
            get => _cardvalue;
            set
            {
                _cardvalue = value;
            }
        }

        public string ImageName { get; set; } = "";



        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }
}
