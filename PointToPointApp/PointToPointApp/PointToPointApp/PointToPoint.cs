using PointToPointSystem;
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
            StartButton startbutton = game.StartButton;
            NewTurnButton newturnbutton = game.NewTurnButton;

            lblMessageBar.DataBindings.Add("Text", game, "GameMessageDescription");
            btnReset.DataBindings.Add("Text", startbutton, "StartButtonDescription");
            btnNewTurn.DataBindings.Add("Enabled", newturnbutton, "IsEnabled");


            lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
            lstimagebutton.ForEach(b =>
            {
                b.Click += BtnPoint_Click;
                Card card = game.ImageCardList[lstimagebutton.IndexOf(b)];
                b.DataBindings.Add("Visible", card, "IsVisible");
            });

            lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
            lstnamebutton.ForEach(b =>
            {
                b.Click += BtnPoint_Click;
                Card card = game.NameCardList[lstnamebutton.IndexOf(b)];
                b.DataBindings.Add("Visible", card, "IsVisible");
            });

            lstimage = new()
            {
                Image.FromFile(path + "arihakadosh.jpg"),
                Image.FromFile(path + "churva.jpg"),
                Image.FromFile(path + "keverrochel.jpg"),
                Image.FromFile(path + "kosel.jpg"),
                Image.FromFile(path + "mearashamechpela.jpg"),
                Image.FromFile(path + "rabbimeirbalhaness.jpg"),
                Image.FromFile(path + "rabishimonbaryochai.jpg"),
                Image.FromFile(path + "yamhamelech.jpg")
            };

            lstname = new()
            {
                Image.FromFile(path + "arihakadoshwithname.jpg"),
                Image.FromFile(path + "churvawithname.jpg"),
                Image.FromFile(path + "keverrochelwithname.jpg"),
                Image.FromFile(path + "koselwithname.jpg"),
                Image.FromFile(path + "mearashamechpelawithname.jpg"),
                Image.FromFile(path + "rabbimeirbalhanesswithname.jpg"),
                Image.FromFile(path + "rabishimonbaryochaiwithname.jpg"),
                Image.FromFile(path + "yamhamelechwithname.jpg")
            };

            btnReset.Click += BtnReset_Click;
            btnNewTurn.Click += BtnNewTurn_Click;

            lstmappic = new()
            {
                picAriHakadosh, picChurva, picKeverRochel, picKosel, picMearasHamachpela, picRabbiMeir,picRabiShimon, picYamHamelech};
            lstmappic.ForEach(m =>
            {
                MapPin mappin = game.MapPinList[lstmappic.IndexOf(m)];
                m.DataBindings.Add("Visible", mappin, "IsVisible");
            });

            lstmaplabel = new()
            {
                lblAriHakadosh,lblChurva, lblKeverRochel, lblKosel, lblMearasHamachpela, lblRabbiMeirBalHaness, lblRabiShimon, lblYamHamelech};
            lstmaplabel.ForEach(l =>
            {
                MapPin maplabel = game.MapPinLabelList[lstmaplabel.IndexOf(l)];
                l.DataBindings.Add("Visible", maplabel, "IsVisible");
            });
        }

        private void DoTurn(Button btn)
        {
            if (game.GameStatus == Game.GameStatusEnum.playing)
            {
                if (lstimagebutton.Exists(b => b == btn))
                {
                    game.CurrentCard = Game.CurrentCardPlayingEnum.imagecard;
                    game.Turn(lstimagebutton.IndexOf(btn));
                    if (game.revealimage == true)
                    {
                        Image newimage = lstimage[game.ImageCard.CardValue];
                        btn.BackgroundImage = newimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                        btn.Image = null;
                        game.revealimage = false;
                        btnimage = btn;
                    }
                }
                else if (lstnamebutton.Exists(b => b == btn))
                {
                    game.CurrentCard = Game.CurrentCardPlayingEnum.namecard;
                    game.Turn(lstnamebutton.IndexOf(btn));
                    if (game.revealimage == true)
                    {
                        Image newimage = lstname[game.NameCard.CardValue];
                        btn.BackgroundImage = newimage;
                        btn.BackgroundImageLayout = ImageLayout.Zoom;
                        btn.Image = null;
                        game.revealimage = false;
                        btnname = btn;
                    }
                }
            }
        }
        private void NewTurn()
        {
            if (game.imagecardflipped == true && game.namecardflipped == true)
            {
                if (game.matchedset == false)
                {
                    btnimage.Image = Image.FromFile(path + "blankpoint.jpg");
                    btnname.Image = Image.FromFile(path + "Blankname.jpg");
                }
                else
                {
                    btnimage.Visible = false;
                    btnname.Visible = false;
                }

                btnimage = null;
                btnname = null;

                game.NewTurn();
            }
        }

        private void StartResetGame()
        {
            btnimage = null;
            btnname = null;

            lstimagebutton.ForEach(btn => btn.Image = Image.FromFile(path + "blankpoint.jpg"));
            lstnamebutton.ForEach(b => b.Image = Image.FromFile(path + "Blankname.jpg"));

            game.StartGame();
        }
        private void BtnPoint_Click(object? sender, EventArgs e)
        {
            DoTurn((Button)sender);
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
