using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{
    public class MapPin : INotifyPropertyChanged
    {
        private bool _isvisible = false;
        public bool IsVisible
        {
            get => _isvisible;
            set
            {
                _isvisible = value;
                this.InvokePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

        public string PinName { get; set; } = "";

    }
}

