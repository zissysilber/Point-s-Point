using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{


    public class StartButton : INotifyPropertyChanged
    {

        public enum StartButtonStatusEnum { start, reset }

        StartButtonStatusEnum _startbuttonstatus = StartButtonStatusEnum.start;
        public StartButtonStatusEnum StartButtonStatus
        {
            get => _startbuttonstatus;
            set
            {
                _startbuttonstatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("StartButtonDescription");
            }
        }
        public string StartButtonDescription
        {
            get
            {
                string message = "START!";
                if (StartButtonStatus == StartButtonStatusEnum.reset)
                {
                    message = "Start Again!";
                }
                return message;
            }
        }
        
        System.Drawing.Color _bordercolor;
        public System.Drawing.Color ButtonHighlightColor { get; set; } = System.Drawing.Color.Crimson;
        public System.Drawing.Color ButtonNoHightlight { get; set; } = System.Drawing.Color.White;

        public System.Drawing.Color BorderColor
        {
            get => _bordercolor;
            set
            {
                _bordercolor = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("BorderColorMaui");
            }
        }

        public Microsoft.Maui.Graphics.Color BorderColorMaui
        {
            get => this.ConvertToMauiColor(this.BorderColor);
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }


        private Microsoft.Maui.Graphics.Color ConvertToMauiColor(System.Drawing.Color systemColor)
        {
            float red = systemColor.R / 255f;
            float green = systemColor.G / 255f;
            float blue = systemColor.B / 255f;
            float alpha = systemColor.A / 255f;

            return new Microsoft.Maui.Graphics.Color(red, green, blue, alpha);
        }
    }
}
