using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{
    public class Picture : INotifyPropertyChanged
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

        public string ImageSourceMaui
        {
            get
            {
                string path = "C:\\Users\\zissy\\source\\repos\\Point-to-Point\\PointToPointApp\\PointToPointApp\\PointToPointMaui\\PointToPointMaui\\Resources\\Images\\";

                return path;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
