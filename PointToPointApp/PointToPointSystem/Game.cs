using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PointToPointSystem
{
    public class Game : INotifyPropertyChanged
    {
        public event EventHandler? ScoreChanged;
        public event PropertyChangedEventHandler? PropertyChanged;
        public enum GameStatusEnum { playing, notplaying, finishedplaying }
        public enum CurrentCardPlayingEnum { none, imagecard, namecard }

        List<string> lstmatchingsetmessage;
        private List<List<Card>> lstallcards = new();
        private List<List<MapPin>> lstpins = new();


        GameStatusEnum _gamestatus = GameStatusEnum.notplaying;
        CurrentCardPlayingEnum _currentcard = CurrentCardPlayingEnum.none;

        private bool _matchedset;
        private int _matchingset;
        public int numberofsetsmatched = 0;

        public static int gameswon = 0;

        public Game()
        {
            StartButton = new();
            NewTurnButton = new();

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

            for (int i = 0; i < 8; i++)
            {
                this.ImageCardList.Add(new Card());
                this.NameCardList.Add(new Card());

                this.MapPinList.Add(new MapPin());
                this.MapPinLabelList.Add(new MapPin());

                this.PictureImageCardList.Add(new Picture());
                this.PictureNameCardList.Add(new Picture());

                lstallcards = new() { ImageCardList, NameCardList };
                lstpins = new() { MapPinList, MapPinLabelList };
            }
        }

        public bool NewGame { get; set; } = true;

        public StartButton StartButton { get; set; }
        public NewTurnButton NewTurnButton { get; set; }

        public List<Card> NameCardList { get; set; } = new();
        public List<Card> ImageCardList { get; set; } = new();

        public List<Picture> PictureImageCardList { get; set; } = new();
        public List<Picture> PictureNameCardList { get; set; } = new();
        public List<MapPin> MapPinList { get; set; } = new();
        public List<MapPin> MapPinLabelList { get; set; } = new();
        public bool ImageCardFlipped { get; set; }
        public bool NameCardFlipped { get; set; }
        public bool RevealImage { get; set; }

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
        public bool MatchedSet
        {
            get => _matchedset;
            set
            {
                _matchedset = value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }
        public int? MatchingSetNum
        {
            get => _matchingset;
            set
            {
                _matchingset = (int)value;
                this.InvokePropertyChanged();
                this.InvokePropertyChanged("GameMessageDescription");
            }
        }

        public int ButtonImageCard { get; set; }
        public int ButtonNameCard { get; set; }
        public int PicImageCard { get; set; }
        public int PicNameCard { get; set; }

        public string GameMessageDescription
        {
            get
            {
                string message = "";
                if (this.GameStatus == GameStatusEnum.notplaying)
                {
                    message = "Let's Explore Eretz Yisrael!\r\nClick START to begin the game.";
                }
                else if (this.GameStatus == GameStatusEnum.playing && this.CurrentCard == CurrentCardPlayingEnum.none)
                {
                    message = "Click a Button!\r\n";
                }
                else if (this.GameStatus == GameStatusEnum.playing && MatchingSetNum != null)
                {
                    if (this.CurrentCard == CurrentCardPlayingEnum.imagecard && NameCardFlipped == false)
                    {
                        message = "Can you find the name of this destination?\r\n";
                    }
                    else if (this.CurrentCard == CurrentCardPlayingEnum.namecard && ImageCardFlipped == false)
                    {
                        message = "Can you find the picture of this destination?\r\n";
                    }
                    else if (ImageCardFlipped == true && NameCardFlipped == true && MatchedSet == true && numberofsetsmatched < 8)
                    {
                        message = lstmatchingsetmessage[(int)MatchingSetNum] + "\r\n Click NEW TURN to discover more!";

                    }
                    else if (ImageCardFlipped == true && NameCardFlipped == true && MatchedSet == false)
                    {
                        message = "Oops!  Click NEW TURN for another chance.\r\n";

                    }
                    else if (this.CurrentCard == CurrentCardPlayingEnum.none && NameCardFlipped == false && ImageCardFlipped == false)
                    {
                        message = "Where will we travel next?\r\n";
                    }
                }
                else if (this.GameStatus == GameStatusEnum.finishedplaying && MatchingSetNum != null)
                {
                    message = lstmatchingsetmessage[(int)MatchingSetNum] + "\r\n Congratulations!  You've matched all the pictures!";
                }
                return message;
            }
        }

        public void StartGame()
        {
            ResetValues();
            ResetButtons();

            StartButton.StartButtonStatus = StartButton.StartButtonStatusEnum.reset;
            NewTurnButton.IsEnabled = true;
            this.GameStatus = GameStatusEnum.playing;
            SetupImages();
        }

        public void SetupImages()
        {
            List<int> usedimagelist = new();
            List<int> usednamelist = new();
            Random rnd = new();

            foreach (Card c in ImageCardList)
            {
                while (c.CardValue == null)
                {
                    Picture newimage = PictureImageCardList[rnd.Next(0, PictureImageCardList.Count())];
                    int picnum = PictureImageCardList.IndexOf(newimage);
                    if (usedimagelist.Where(i => i == picnum).Count() == 0)
                    {
                        usedimagelist.Add(picnum);
                        c.CardValue = picnum;
                    }
                }
            }

            foreach (Card c in NameCardList)
            {
                while (c.CardValue == null)
                {
                    Picture newimage = PictureNameCardList[rnd.Next(0, PictureNameCardList.Count())];
                    int picnum = PictureNameCardList.IndexOf(newimage);
                    if (usednamelist.Where(i => i == picnum).Count() == 0)
                    {
                        usednamelist.Add(picnum);
                        c.CardValue = picnum;
                    }
                }
            }
        }
        public void Turn(int cardspot)
        {
            if (CurrentCard == CurrentCardPlayingEnum.imagecard)
            {
                if (ImageCardFlipped == false)
                {
                    Card card = this.ImageCardList[cardspot];
                    PicImageCard = card.CardValue.Value;
                    ImageCardFlipped = true;
                    RevealImage = true;
                }
            }
            else if (CurrentCard == CurrentCardPlayingEnum.namecard)
            {
                if (NameCardFlipped == false)
                {
                    Card card = this.NameCardList[cardspot];
                    PicNameCard = card.CardValue.Value;
                    NameCardFlipped = true;
                    RevealImage = true;
                }
            }

            if (ImageCardFlipped == true && NameCardFlipped == true)
            {
                DetectMatch();
                UpdateMap();
            }

            if (ImageCardFlipped == true && NameCardFlipped == true && numberofsetsmatched < 8)
            {
                NewTurnButton.BorderColor = NewTurnButton.ButtonHighlightColor;
            }
            if (ImageCardFlipped == true && NameCardFlipped == true && numberofsetsmatched == 8)
            {
                StartButton.BorderColor = StartButton.ButtonHighlightColor;
                NewTurnButton.IsEnabled = false;
            }
        }


        public void DetectMatch()
        {
            if (PicImageCard == PicNameCard)
            {
                numberofsetsmatched++;
                MatchedSet = true;
                MatchingSetNum = PicImageCard;
                if (numberofsetsmatched == 8)
                {
                    GameStatus = GameStatusEnum.finishedplaying;
                    gameswon++;
                }
            }
            else MatchedSet = false;
            ScoreChanged?.Invoke(this, new EventArgs());
        }
        public void UpdateMap()
        {
            if (this.MatchedSet == true)
            {
                if (MatchingSetNum != null)
                {
                    MapPinList[(int)this.MatchingSetNum].IsVisible = true;
                    MapPinLabelList[(int)this.MatchingSetNum].IsVisible = true;
                }
            }
        }
        public void EndTurn()
        {
            if (ImageCardFlipped == true && NameCardFlipped == true)
            {
                if (this.MatchedSet == true)
                {
                    ImageCardList[ButtonImageCard].SetMatched = true;
                    NameCardList[ButtonNameCard].SetMatched = true;
                }
            }
            CurrentCard = CurrentCardPlayingEnum.none;
            MatchedSet = false;
            ImageCardFlipped = false;
            NameCardFlipped = false;
            NewTurnButton.BorderColor = NewTurnButton.ButtonNoHightlight;
        }

        public void NewTurn()
        {
            EndTurn();
        }
        private void ResetValues()
        {
            GameStatus = GameStatusEnum.notplaying;
            ImageCardFlipped = false;
            NameCardFlipped = false;
            CurrentCard = CurrentCardPlayingEnum.none;
            numberofsetsmatched = 0;
            lstallcards.ForEach(lst => lst.ForEach(c =>
            {
                c.SetMatched = false;
                c.CardValue = null;
            }));
            lstpins.ForEach(lst => lst.ForEach(p => p.IsVisible = false));
            StartButton.BorderColor = StartButton.ButtonNoHightlight;
            NewTurnButton.BorderColor = NewTurnButton.ButtonNoHightlight;
        }

        public void ResetButtons()
        {
            lstallcards.ForEach(lst => lst.ForEach(c =>
            {
                c.IsVisible = true;
                
            }));
        }


        public void InvokePropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }

    }
}
