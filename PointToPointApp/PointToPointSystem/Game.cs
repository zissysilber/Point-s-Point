using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{
    public class Game : INotifyPropertyChanged
    {
        public enum GameStatusEnum { playing, beginplaying, notplaying, finishedplaying }
        public enum CurrentCardPlayingEnum { none, imagecard, namecard }
        List<string> lstmatchingsetmessage;
        List<string> lstimagecardimagename;
        List<string> lstnamecardimagename;
        List<List<Card>> lstallcards;
        GameStatusEnum _gamestatus = GameStatusEnum.notplaying;
        CurrentCardPlayingEnum _currentcard = CurrentCardPlayingEnum.none;
        private Card _imagecard;
        private Card _namecard;
        private bool _matchedset;
        private int _matchingset;
        public int numberofsetsmatched = 0;
        System.Drawing.Color _bordercolor;

        public Game()
        {
            ImageCard = new();
            NameCard = new();
            StartButton = new();
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
            lstallcards = new() { ImageCardList, NameCardList };
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

        public bool imagecardflipped { get; set; }
        public bool namecardflipped { get; set; }
        public bool revealimage { get; set; }

        public int matchingsetnum
        {
            get => _matchingset;
            set
            {
                _matchingset = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }
        public StartButton StartButton { get; set; }
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

        public bool matchedset
        {
            get => _matchedset;
            set
            {
                _matchedset = value;
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
                    if (this.CurrentCard == CurrentCardPlayingEnum.imagecard && namecardflipped == false)
                    {
                        message = "Can you find the name of this destination?";
                    }
                    else if (this.CurrentCard == CurrentCardPlayingEnum.namecard && imagecardflipped == false)
                    {
                        message = "Can you find the picture of this destination?";
                    }
                    else if (imagecardflipped == true && namecardflipped == true && matchedset == true && numberofsetsmatched < 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Click NEW TURN to discover more!";

                    }
                    else if (imagecardflipped == true && namecardflipped == true && matchedset == true && numberofsetsmatched == 8)
                    {
                        message = lstmatchingsetmessage[matchingsetnum] + "\r\n Congratulations!  You've matched all the pictures!";

                    }
                    else if (imagecardflipped == true && namecardflipped == true && matchedset == false)
                    {
                        message = "Oops!  Click NEW TURN for another chance.";

                    }
                    else if (this.CurrentCard == CurrentCardPlayingEnum.none && namecardflipped == false && imagecardflipped == false)
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


        public void StartGame()
        {
            ResetValues();
            
            StartButton.StartButtonStatus = StartButton.StartButtonStatusEnum.reset;
            this.GameStatus = GameStatusEnum.beginplaying;
            SetupImages();
        }

        public void Turn(int cardspot)
        {
            if (CurrentCard == CurrentCardPlayingEnum.imagecard)
            {
                if (imagecardflipped == false)
                {
                    Card card = this.ImageCardList[cardspot];
                    ImageCard = card;
                    imagecardflipped = true;
                    revealimage = true;
                }
            }

            else if (CurrentCard == CurrentCardPlayingEnum.namecard)
            {
                if (namecardflipped == false)
                {
                    Card card = this.NameCardList[cardspot];
                    NameCard = card;
                    namecardflipped = true;
                    revealimage = true;
                }
            }

            if (imagecardflipped == true && namecardflipped == true)
            {
                DetectMatch();
            }

            if (imagecardflipped == true && namecardflipped == true && numberofsetsmatched < 8)
            {
                //btnNewTurn.BorderColor = Colors.Crimson;
                //btnNewTurn.BorderWidth = 5;
            }
            if (imagecardflipped == true && namecardflipped == true && numberofsetsmatched == 1)
            {
                StartButton.BorderColor = StartButton.ButtonHighlightColor;
                //StartButton.BorderWidth = 5;
            }
        }

        private void SetupImages()
        {
            List<string> usedimagelist = new();
            List<string> usednamelist = new();
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
                        c.CardValue = lstnamecardimagename.IndexOf(newimage);
                    }
                }
            }
        }

        public void DetectMatch()
        {
            if (ImageCard.CardValue == NameCard.CardValue)
            {
                numberofsetsmatched++;
                matchedset = true;
                matchingsetnum = ImageCard.CardValue;
                if (numberofsetsmatched == 8)
                {
                    GameStatus = GameStatusEnum.finishedplaying;
                }
            }
            else matchedset = false;
        }

        public void EndTurn()
        {
            imagecardflipped = false;
            namecardflipped = false;
            CurrentCard = CurrentCardPlayingEnum.none;
            matchedset = false;
            imagecardflipped = false;
            namecardflipped = false;

        }

        public void NewTurn()
        {
            EndTurn();
        }
        private void ResetValues()
        {
            GameStatus = GameStatusEnum.notplaying;
            imagecardflipped = false;
            namecardflipped = false;
            CurrentCard = CurrentCardPlayingEnum.none;
            numberofsetsmatched = 0;
            lstallcards.ForEach(lst => lst.ForEach(crd => crd.ImageName = ""));
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }



    }
}
