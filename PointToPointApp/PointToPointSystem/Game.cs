using System.ComponentModel;
using System.Runtime.CompilerServices;
using static PointToPointSystem.Card;

namespace PointToPointSystem
{
    public class Game : INotifyPropertyChanged
    {
        public enum GameStatusEnum { playing, beginplaying, notplaying, finishedplaying }
        public enum ImageCardStatusEnum { flipped, notflipped }
        public enum NameCardStatusEnum { flipped, notflipped }
        public enum CurrentCardPlayingEnum { none, imagecard, namecard }
        public enum StartButtonStatusEnum { start, reset }

        public bool matchedset
        {
            get => _matchedset; set
            {
                _matchedset = value;
                this.InvokePropertyChanged();
            }
        }
        public int matchingsetnum
        {
            get => _matchingset; set
            {
                _matchingset = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }

        List<string> lstmatchingsetmessage;

        ImageCardStatusEnum _imagecardstatus = ImageCardStatusEnum.notflipped;
        NameCardStatusEnum _namecardstatus = NameCardStatusEnum.notflipped;
        GameStatusEnum _gamestatus = GameStatusEnum.notplaying;
        StartButtonStatusEnum _startbuttonstatus = StartButtonStatusEnum.start;
        CurrentCardPlayingEnum _currentcard = CurrentCardPlayingEnum.none;
        private Card _imagecard;
        private Card _namecard;
        private bool _matchedset;
        private int _matchingset;
        public int numberofsetsmatched = 0;
       


        public Game()
        {
            ImageCard = new();
            NameCard = new(); 
            lstmatchingsetmessage = new()
            {
                "The Ari Hakadosh is buried in Tzfas.",
                "The Churva is a shul in Yerushalayim.",
                "Kever Rochel is in Beis Lechem.",
                "The Kosel is in Yerushalayim.",
                "Mearas Hamachpela is in Chevron.",
                "The kever of Rabbi Meir Bal Haness is in Tiverya.",
                "The kever of Rabi Shimon Bar Yochai is in Meron.",
                "The salt in Yam Hamelech makes everything float in the water."
            };
        }
        public GameStatusEnum GameStatus
        {
            get => _gamestatus;
            set
            {
                _gamestatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }
        public Card ImageCard
        {
            get => _imagecard; set
            {
                _imagecard = value;
                this.InvokePropertyChanged();
            }
        }

        public Card NameCard
        {
            get => _namecard;
            set
            {
                _namecard = value;
                this.InvokePropertyChanged();
            }
        }



        public ImageCardStatusEnum ImageCardStatus
        {
            get => _imagecardstatus;
            set
            {
                _imagecardstatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }
        public NameCardStatusEnum NameCardStatus
        {
            get => _namecardstatus;
            set
            {
                _namecardstatus = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }

        public CurrentCardPlayingEnum CurrentCard
        {
            get => _currentcard;
            set
            {
                _currentcard = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }

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
        public string GameMessageDescription
        {
            get
            {
                string message = "";
                if (this.GameStatus == GameStatusEnum.notplaying)
                {
                    message = "Let's Explore Eretz Yisrael!\r\nClick START to begin the game.";
                }
                else if (this.GameStatus == GameStatusEnum.playing)
                {
                    if (CurrentCard == CurrentCardPlayingEnum.imagecard && NameCardStatus == NameCardStatusEnum.notflipped)
                    {
                        message = "Can you find the name of this destination?";
                    }
                    else if (CurrentCard == CurrentCardPlayingEnum.namecard && ImageCardStatus == ImageCardStatusEnum.notflipped)
                    {
                        message = "Can you find the picture of this destination?";
                    }
                    else if (ImageCardStatus == ImageCardStatusEnum.flipped && NameCardStatus == NameCardStatusEnum.flipped && matchedset == true && numberofsetsmatched < 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Click NEW TURN to discover more!";

                    }
                    else if (ImageCardStatus == ImageCardStatusEnum.flipped && NameCardStatus == NameCardStatusEnum.flipped && matchedset == true && numberofsetsmatched == 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Congratulations!  You've matched all the pictures!";

                    }
                    else if (ImageCardStatus == ImageCardStatusEnum.flipped && NameCardStatus == NameCardStatusEnum.flipped && matchedset == false)
                    {
                        message = "Oops!  Click NEW TURN for another chance.";

                    }
                    else if (CurrentCard == CurrentCardPlayingEnum.none && NameCardStatus == NameCardStatusEnum.notflipped && ImageCardStatus == ImageCardStatusEnum.notflipped)
                    {
                        message = "Where will we travel next?";
                    }
                }
                else if (this.GameStatus == GameStatusEnum.finishedplaying)
                {
                    message = "Congratulations!  You've matched all the pictures!";
                }
                else if (this.GameStatus == GameStatusEnum.beginplaying)
                {
                    message = "Click a Button!";
                    this.GameStatus = GameStatusEnum.playing;
                }
                return message;
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
            set { }
        }
        public void StartGame()
        {
            ResetValues();
            this.StartButtonStatus = StartButtonStatusEnum.reset;
            this.GameStatus = GameStatusEnum.beginplaying;
        }

        public void DetectMatch()
        {

            if (ImageCard.CardValue == NameCard.CardValue)
            {
                matchedset = true;
                numberofsetsmatched++;
                matchingsetnum = ImageCard.CardValue;
            }
        }

        public void EndTurn()
        {
            ImageCardStatus = ImageCardStatusEnum.notflipped;
            NameCardStatus = NameCardStatusEnum.notflipped;
            CurrentCard = CurrentCardPlayingEnum.none;
            matchedset = false;

        }

        public void NewTurn()
        {
            EndTurn();
        }
        private void ResetValues()
        {
            GameStatus = GameStatusEnum.notplaying;
            ImageCardStatus = ImageCardStatusEnum.notflipped;
            NameCardStatus = NameCardStatusEnum.notflipped;
            CurrentCard = CurrentCardPlayingEnum.none;
            numberofsetsmatched = 0;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        private void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
