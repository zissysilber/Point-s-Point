using PointToPointSystem;
using Image = Microsoft.Maui.Controls.Image;
using System.Text.RegularExpressions;
namespace PointToPointMaui;

public partial class PointToPoint : ContentPage
{


    List<Button> lstimagebutton;
    List<Button> lstnamebutton;
    List<Button> lstgameimage;
    List<Button> lstgamename;
    List<Image> lstimage;
    List<Image> lstname;

    List<Image> lstmappic;
    List<Label> lstmaplabel;

    Random rnd = new();

    Button? btnimage = null;
    Button? btnname = null;
    Button? btngameimage = null;
    Button? btngamename = null;

    Game game = new();
    public PointToPoint()
    {
        InitializeComponent();
        this.BindingContext = game;
        lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
        lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
        lstgameimage = new() { btnGameImage1, btnGameImage2, btnGameImage3, btnGameImage4, btnGameImage5, btnGameImage6, btnGameImage7, btnGameImage8 };
        lstgamename = new() { btnGameName9, btnGameName10, btnGameName11, btnGameName12, btnGameName13, btnGameName14, btnGameName15, btnGameName16 };
        lstimage = new()
        {
            arihakadosh,
            churva,
            keverrochel,
            kosel,
            mearashamechpela,
            rabbimeirbalhaness,
            rabishimonbaryochai,
            yamhamelech
        };
        lstname = new() { arihakadoshwithname, churvawithname, keverrochelwithname, koselwithname, mearashamechpelawithname, rabbimeirbalhanesswithname, rabishimonbaryochaiwithname, yamhamelechwithname };
        lstmappic = new() { picarihakadosh, picchurva, pickeverrochel, pickosel, picmearashamechpela, picrabbimeirbalhaness, picrabishimonbaryochai, picyamhamelech };
        lstmaplabel = new() { lblarihakadosh, lblchurva, lblkeverrochel, lblkosel, lblmearashamechpela, lblrabbimeirbalhaness, lblrabishimonbaryochai, lblyamhamelech };

    }
    private void StartResetGame()
    {

        ResetButtons();
        game.StartGame();
        SetupImages();
    }

    private void SetupImages()
    {
        List<Image> usedlist = new();
        foreach (Button b in lstgameimage)
        {
            while (b.ImageSource == null)
            {
                Image newimage = lstimage[rnd.Next(0, lstimage.Count())];
                string imagename = newimage.Source.ToString();
                string removefile = "File : ";
                imagename = imagename.Substring(imagename.IndexOf(removefile) + removefile.Length);

                if (usedlist.Where(i => i == newimage).Count() == 0)
                {
                    usedlist.Add(newimage);
                    b.ImageSource = imagename;
                }
            }
        }
        foreach (Button b in lstgamename)
        {
            while (b.ImageSource == null)
            {
                Image newimage = lstname[rnd.Next(0, lstname.Count())];
                string imagename = newimage.Source.ToString();
                string removefile = "File : ";
                imagename = imagename.Substring(imagename.IndexOf(removefile) + removefile.Length);

                if (usedlist.Where(i => i == newimage).Count() == 0)
                {
                    usedlist.Add(newimage);
                    b.ImageSource = imagename;
                }
            }
        }
    }

    private int FindImageValue(Button btn)
    {
        //ZS: Is there a cleaner way to do this code?

        //Find button underneath clicked button
        string btnclickedname = btn.StyleId;
        string value = Regex.Match(btnclickedname, @"\d+").Value;
        string gamenamebtn = game.CurrentCard == Game.CurrentCardPlayingEnum.imagecard ? "btnGameImage" + value : gamenamebtn = "btnGameName" + value;
        Button imagebtn = game.CurrentCard == Game.CurrentCardPlayingEnum.imagecard ? lstgameimage.First(b => b.StyleId == gamenamebtn) : lstgamename.First(b => b.StyleId == gamenamebtn);
        if (gamenamebtn.Contains("Image"))
        {
            btngameimage = imagebtn;
        }
        else
        {
            btngamename = imagebtn;
        }

        //Find image assigned to button underneath
        string imagename = imagebtn.ImageSource.ToString();
        string removefile = "File : ";
        string jpg = ".jpg";
        string parsedimagename = imagename.Substring(imagename.IndexOf(removefile) + removefile.Length);
        parsedimagename = parsedimagename.Substring(0, parsedimagename.Length - jpg.Length);
        Image gameimage = game.CurrentCard == Game.CurrentCardPlayingEnum.imagecard ? lstimage.First(b => b.StyleId.ToString() == parsedimagename) : lstname.First(b => b.StyleId.ToString() == parsedimagename);
        int index = game.CurrentCard == Game.CurrentCardPlayingEnum.imagecard ? lstimage.IndexOf(gameimage) : lstname.IndexOf(gameimage);
        return index;
    }
    private void DoTurn(Button btn)
    {
        if (lstimagebutton.Exists(b => b == btn))
        {
            if (game.ImageCardStatus == Game.ImageCardStatusEnum.notflipped)
            {
                game.CurrentCard = Game.CurrentCardPlayingEnum.imagecard;
                game.ImageCardStatus = Game.ImageCardStatusEnum.flipped;
                game.ImageCard.CardValue = FindImageValue(btn);
                btnimage = btn;
                btn.IsVisible = false;
            }
            else return;
        }
        else if (lstnamebutton.Exists(b => b == btn))
        {
            if (game.NameCardStatus == Game.NameCardStatusEnum.notflipped)
            {
                game.CurrentCard = Game.CurrentCardPlayingEnum.namecard;
                game.NameCardStatus = Game.NameCardStatusEnum.flipped;
                game.NameCard.CardValue = FindImageValue(btn);
                btnname = btn;
                btn.IsVisible = false;

            }
            else return;
        }

        if (game.ImageCardStatus == Game.ImageCardStatusEnum.flipped && game.NameCardStatus == Game.NameCardStatusEnum.flipped)
        {
            game.DetectMatch();

            //Format Button NewTurn
            if (game.ImageCardStatus == Game.ImageCardStatusEnum.flipped && game.NameCardStatus == Game.NameCardStatusEnum.flipped && game.numberofsetsmatched < 8)
            {
                btnNewTurn.BorderColor = Colors.Crimson;
                btnNewTurn.BorderWidth = 5;
                btnNewTurn.TextColor = Colors.LightSkyBlue;
            }
            if (game.ImageCardStatus == Game.ImageCardStatusEnum.flipped && game.NameCardStatus == Game.NameCardStatusEnum.flipped && game.numberofsetsmatched == 8)
            {
                btnStart.BorderColor = Colors.Crimson;
                btnStart.BorderWidth = 5;
                btnStart.TextColor = Colors.LightSkyBlue;
            }

            UpdateMap();
        }


    }

    private void UpdateMap()
    {
        if (game.matchedset == true)
        {
            lstmaplabel[game.matchingset].IsVisible = true;
            lstmappic[game.matchingset].IsVisible = true;
        }
    }

    private void ResetNewTurnButton()
    {
        btnNewTurn.BorderWidth = 0;
        btnNewTurn.TextColor = Colors.White;
    }
    private void NewTurn()
    {

        if ((game.ImageCardStatus == Game.ImageCardStatusEnum.flipped && game.NameCardStatus == Game.NameCardStatusEnum.flipped && game.matchedset == false) || game.matchedset == true)
        {
            ResetNewTurnButton();
            HidePictures();
            game.NewTurn();
        }
    }

    private void HidePictures()
    {

        if (btnimage != null && btnname != null)
        {
            if (game.matchedset == true)
            {
                btngameimage.IsVisible = false;
                btngamename.IsVisible = false;
            }
            else
            {
                btnname.IsVisible = true;
                btnimage.IsVisible = true;
            }
        }
    }



    private void ResetButtons()
    {
        lstimagebutton.ForEach(btn => btn.IsVisible = true);
        lstgameimage.ForEach(btn => btn.ImageSource = null);
        lstgameimage.ForEach(btn => btn.IsVisible = true);
        lstnamebutton.ForEach(btn => btn.IsVisible = true);
        lstgamename.ForEach(btn => btn.ImageSource = null);
        lstgamename.ForEach(btn => btn.IsVisible = true);
        btnimage = null;
        btnname = null;
        game.newturn = false;
        btnNewTurn.TextColor = Colors.White;
        btnNewTurn.BorderWidth = 0;
        lstmaplabel.ForEach(lbl => lbl.IsVisible = false);
        lstmappic.ForEach(pic => pic.IsVisible = false);
        ResetNewTurnButton();
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



    private void btnStart_Clicked(object sender, EventArgs e)
    {
        StartResetGame();
    }

    private void btnNewTurn_Clicked(object sender, EventArgs e)
    {
        NewTurn();
    }


}