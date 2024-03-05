using PointToPointSystem;
using System.Data;
using Image = System.Drawing.Image;

namespace PointToPointApp
{
    public partial class frmPointToPoint : Form
    {
        string path = Application.StartupPath + @"\Images\";

        List<Button> lstimagebutton;
        List<Button> lstnamebutton;
        List<Image> lstname;
        List<Image> lstimage;
        List<PictureBox> lstmappic;
        List<Label> lstmaplabel;

        Random rnd = new();

        Button? btnimage = null;
        Button? btnname = null;

        Game game = new();

        public frmPointToPoint()
        {
            InitializeComponent();

            lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
            lstimagebutton.ForEach(b => b.Click += BtnPoint_Click);

            lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
            lstnamebutton.ForEach(b => b.Click += BtnPoint_Click);

            lstimage = new()
            {
                Image.FromFile(path + "Ari Hakadosh.jpg"),
                Image.FromFile(path + "Churva.jpg"),
                Image.FromFile(path + "Kever Rochel.jpg"),
                Image.FromFile(path + "kosel.jpg"),
                Image.FromFile(path + "Mearas Hamechpela.jpg"),
                Image.FromFile(path + "Rabbi Meir Bal Haness.jpg"),
                Image.FromFile(path + "Rabi Shimon Bar Yochai.jpg"),
                Image.FromFile(path + "Yam Hamelech.jpg")
            };

            lstname = new()
            {
                Image.FromFile(path + "Ari Hakadoshwith name.jpg"),
                Image.FromFile(path + "Churvawithname.jpg"),
                Image.FromFile(path + "Kever Rochel with name.jpg"),
                Image.FromFile(path + "Kosel with name.jpg"),
                Image.FromFile(path + "Mearas Hamechpela with name.jpg"),
                Image.FromFile(path + "Rabbi Meir Bal Haness with name.jpg"),
                Image.FromFile(path + "Rabi Shimon Bar Yochai with name.jpg"),
                Image.FromFile(path + "Yam Hamelech with name.jpg")
            };

            btnReset.Click += BtnReset_Click;
            btnNewTurn.Click += BtnNewTurn_Click;

            lstmappic = new()
            {
                picAriHakadosh,
                picChurva,
                picKeverRochel,
                picKosel,
                picMearasHamachpela,
                picRabbiMeir,
                picRabiShimon,
                picYamHamelech,

            };

            lstmaplabel = new()
            {
                lblAriHakadosh,
                lblChurva,
                lblKeverRochel,
                lblKosel,
                lblMearasHamachpela,
                lblRabbiMeirBalHaness,
                lblRabiShimon,
                lblYamHamelech
            };
            lblMessageBar.DataBindings.Add("Text", game, "GameMessageDescription");
            btnReset.DataBindings.Add("Text", game, "StartButtonDescription");
        }



        private void AssignImage()
        {
            List<Image> usedlist = new();
            foreach (Button btn in lstimagebutton)
            {
                while (btn.BackgroundImage == null)
                {
                    Image newimage = lstimage[rnd.Next(0, lstimage.Count())];

                    if (usedlist.Where(i => i == newimage).Count() == 0)
                    {
                        usedlist.Add(newimage);
                        btn.BackgroundImage = newimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;

                    }
                }
            }
            foreach (Button btn in lstnamebutton)
            {
                while (btn.BackgroundImage == null)
                {
                    Image nameimage = lstname[rnd.Next(0, lstname.Count())];

                    if (usedlist.Where(i => i == nameimage).Count() == 0)
                    {
                        usedlist.Add(nameimage);
                        btn.BackgroundImage = nameimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                }
            }
        }

        private void DoTurn(Button btn)
        {
            if (lstimagebutton.Exists(b => b == btn))
            {
                if(game.ImageCard.CardStatus == CardStatusEnum.notflipped)
                {
                    game.CurrentCard = Game.CurrentCardPlayingEnum.imagecard;
                    game.ImageCard.CardStatus = CardStatusEnum.flipped;
                    game.ImageCard.CardValue = lstimage.IndexOf(btn.BackgroundImage);
                    btnimage = btn;
                    btn.Image = null;
                }
                else return;
            }
            else if (lstnamebutton.Exists(b => b == btn))
            {
                if (game.NameCard.CardStatus == CardStatusEnum.notflipped)
                {
                    game.CurrentCard = Game.CurrentCardPlayingEnum.namecard;
                    game.NameCard.CardStatus = CardStatusEnum.flipped;
                    game.NameCard.CardValue = lstname.IndexOf(btn.BackgroundImage);
                    btnname = btn;
                    btn.Image = null;
                }
                else return;
            }
            if(game.ImageCard.CardStatus == CardStatusEnum.flipped && game.NameCard.CardStatus == CardStatusEnum.flipped)
            {
                game.DetectMatch();
                UpdateMap();
            }

        }
        private void UpdateMap()
        {
            if (game.matchedset == true)
            {
                lstmaplabel[game.matchingsetnum].Visible = true;
                lstmappic[game.matchingsetnum].Visible = true;
            }
        }
        private void HidePictures()
        {

            if (btnimage != null && btnname != null)
            {
                btnimage.Image = Image.FromFile(path + "blankpoint.jpg");
                btnname.Image = Image.FromFile(path + "Blankname.jpg");

                if (game.matchedset == true)
                {
                    btnimage.Visible = false;
                    btnname.Visible = false;
                }

            }
        }

        private void SetupButtonsAndImages()
        {
            lstimagebutton.ForEach(btn =>
            {
                btn.Image = Image.FromFile(path + "blankpoint.jpg");
                btn.Visible = true;
                btn.BackgroundImage = null;
            });

            lstnamebutton.ForEach(b =>
            {
                b.Image = Image.FromFile(path + "Blankname.jpg");
                b.Visible = true;
                b.BackgroundImage = null;
            });

            lstmappic.ForEach(i => i.Visible = false);
            lstmaplabel.ForEach(i => i.Visible = false);
            AssignImage();
        }
        private void StartResetGame()
        {
            game.StartGame();
            ResetButtons();
            SetupButtonsAndImages();
        }
        private void ResetButtons()
        {
            btnimage = null;
            btnname = null;
        }
        private void NewTurn()
        {
            HidePictures();
            ResetButtons();
            game.NewTurn();
        }
        private void BtnPoint_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (game.GameStatus == Game.GameStatusEnum.playing)
                {
                    DoTurn(btn);
                }
            }
        }
        private void BtnReset_Click(object? sender, EventArgs e)
        {
            StartResetGame();
        }

        private void BtnNewTurn_Click(object? sender, EventArgs e)
        {
            NewTurn();
        }


    }
}
