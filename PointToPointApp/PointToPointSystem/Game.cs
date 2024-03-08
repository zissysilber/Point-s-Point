using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using static PointToPointSystem.Card;

namespace PointToPointSystem
{
    public class Game : INotifyPropertyChanged
    {
        public enum GameStatusEnum { playing, beginplaying, notplaying, finishedplaying }

        public enum CurrentCardPlayingEnum { none, imagecard, namecard }
        public enum StartButtonStatusEnum { start, reset }

        public bool revealimage { get; set; } = false;

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
        List<string> lstimagecardimagename;
        List<string> lstnamecardimagename;


        GameStatusEnum _gamestatus = GameStatusEnum.notplaying;
        StartButtonStatusEnum _startbuttonstatus = StartButtonStatusEnum.start;
        CurrentCardPlayingEnum _currentcard = CurrentCardPlayingEnum.none;
        private Card _imagecard;
        private Card _namecard;
        private bool _matchedset;
        private int _matchingset;
        public int numberofsetsmatched = 0;


        Card card = new();

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
            lstimagecardimagename = new() 
            {
                "arihakadosh.jpg",
                "churva.jpg",
                "keverrochel.jpg",
                "kosel.jpg",
                "mearashamechpela.jpg",
                "rabbimeirbalhaness.jpg",
                "rabishimonbaryochai.jpg",
                "yamhamelech.jpg"
            };
            lstnamecardimagename = new()
            {
                "arihakadoshwithname.jpg",
                "churvawithname.jpg",
                "keverrochelwithname.jpg",
                "koselwithname.jpg",
                "mearashamechpelawithname.jpg",
                "rabbimeirbalhanesswithname.jpg",
                "rabishimonbaryochaiwithname.jpg",
                "yamhamelechwithname.jpg"
            };

            for (int i = 0; i < 8; i++)
            {
                this.ImageCardList.Add(new Card());
            }

            for (int i = 0; i < 8; i++)
            {
                this.NameCardList.Add(new Card());
            }
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

        public List<Card> NameCardList { get; private set; } = new();
        public List<Card> ImageCardList { get; private set; } = new();
        public Card ImageCard
        {
            get => _imagecard;
            set
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

        public CardStatusEnum FlippedCardStatus
        {
            get => card.cardstatus;
            set
            {
                card.cardstatus = value;
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
                    if (CurrentCard == CurrentCardPlayingEnum.imagecard && NameCard.CardStatus == CardStatusEnum.notflipped)
                    {
                        message = "Can you find the name of this destination?";
                    }
                    else if (CurrentCard == CurrentCardPlayingEnum.namecard && ImageCard.CardStatus == CardStatusEnum.notflipped)
                    {
                        message = "Can you find the picture of this destination?";
                    }
                    else if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped && matchedset == true && numberofsetsmatched < 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Click NEW TURN to discover more!";

                    }
                    else if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped && matchedset == true && numberofsetsmatched == 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Congratulations!  You've matched all the pictures!";

                    }
                    else if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped && matchedset == false)
                    {
                        message = "Oops!  Click NEW TURN for another chance.";

                    }
                    else if (CurrentCard == CurrentCardPlayingEnum.none && NameCard.CardStatus == CardStatusEnum.notflipped && ImageCard.CardStatus == CardStatusEnum.notflipped)
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
            SetupImages();
        }

        public void Turn(int cardspot)
        {
            if (CurrentCard == CurrentCardPlayingEnum.imagecard)
            {
                if (ImageCard.CardStatus == CardStatusEnum.notflipped)
                {
                    Card card = this.ImageCardList[cardspot];
                    ImageCard = card;
                    ImageCard.CardStatus = CardStatusEnum.flipped;
                    revealimage = true;
                }
            }

             else if (CurrentCard == CurrentCardPlayingEnum.namecard)
            {
                if (NameCard.CardStatus == CardStatusEnum.notflipped)
                {
                    Card card = this.NameCardList[cardspot];
                    NameCard = card;
                    NameCard.CardStatus = CardStatusEnum.flipped;
                    revealimage = true;
                }
            }
           

            if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped)
            {
                DetectMatch();
                
                ////Format Button NewTurn
                //if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped && numberofsetsmatched < 8)
                //{
                //    btnNewTurn.BorderColor = Colors.Crimson;
                //    btnNewTurn.BorderWidth = 5;
                //    btnNewTurn.TextColor = Colors.LightSkyBlue;
                //}
                //if (ImageCard.CardStatus == CardStatusEnum.flipped && NameCard.CardStatus == CardStatusEnum.flipped && numberofsetsmatched == 8)
                //{
                //    btnStart.BorderColor = Colors.Crimson;
                //    btnStart.BorderWidth = 5;
                //    btnStart.TextColor = Colors.LightSkyBlue;
                //}

                //UpdateMap();
            }

        }

        private void SetupImages()
        { 
            List<string> usedimagelist = new();List<string> usednamelist = new();
            Random rnd = new();
           
            foreach (Card c in ImageCardList)
            {
                while (c.ImageName == "")
                {
                    string newimage = lstimagecardimagename[rnd.Next(0, lstimagecardimagename.Count())];
                   
                    if (usedimagelist.Where(i => i == newimage).Count() == 0)
                    {
                        usedimagelist.Add(newimage);
                        c.ImageName = newimage;
                        c.CardValue = lstimagecardimagename.IndexOf(newimage);
                        c.CardStatus = CardStatusEnum.notflipped;
                    }
                }
            }
            foreach (Card c in NameCardList)
            {
                while (c.ImageName == "")
                {
                    
                    string newimage = lstnamecardimagename[rnd.Next(0, lstnamecardimagename.Count())];
                    
                    if (usednamelist.Where(i => i == newimage).Count() == 0)
                    {
                        usednamelist.Add(newimage);
                        c.ImageName = newimage;
                        c.CardType = CardTypeEnum.name;
                        c.CardValue = lstnamecardimagename.IndexOf(newimage);
                        c.CardStatus = CardStatusEnum.notflipped;
                    }
                }
            }
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
            ImageCard.CardStatus = CardStatusEnum.notflipped;
            NameCard.CardStatus = CardStatusEnum.notflipped;
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
            ImageCard.CardStatus = CardStatusEnum.notflipped;
            NameCard.CardStatus = CardStatusEnum.notflipped;
            CurrentCard = CurrentCardPlayingEnum.none;
            numberofsetsmatched = 0;
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
