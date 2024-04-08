using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{

    public enum CardStatusEnum { flipped, notflipped }
    public enum CardTypeEnum { image, name }
    public class Card : INotifyPropertyChanged
    {
        private bool _isvisible = false;
        private int _cardvalue  ;
        private string _imagename = "";

        public int CardValue
        {
            get => _cardvalue;
            set
            {
                _cardvalue = value;
            }
        }

        public string ImageName
        {
            get => _imagename;
            set
            {
                _imagename = value;
                InvokePropertyChanged();
            }
        }

        public bool IsVisible
        {
            get => _isvisible;
            set
            {
                _isvisible = value;
                InvokePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
