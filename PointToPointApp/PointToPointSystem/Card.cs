using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{

    public enum CardStatusEnum { flipped, notflipped }
    public enum CardTypeEnum { image, name }
    public class Card : INotifyPropertyChanged
    {
        private bool _isvisible = true;
        private int? _cardvalue;
        private bool _setmatched;

        public int? CardValue
        {
            get => _cardvalue;
            set
            {
                _cardvalue = value;
            }
        }
        public bool IsVisible
        {
            get
            {
                if (SetMatched == true)
                {
                    _isvisible = false;
                }
                return _isvisible;
            }
            set
            {
                _isvisible = value;
                InvokePropertyChanged();
            }
        }

        public bool SetMatched
        {
            get => _setmatched;
            set
            {
                _setmatched = value;
                InvokePropertyChanged();
                InvokePropertyChanged("IsVisible");
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
