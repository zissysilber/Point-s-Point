using PointToPointSystem;
using Image = Microsoft.Maui.Controls.Image;
using System.Text.RegularExpressions;
namespace PointToPointMaui;

public partial class PointToPoint : ContentPage
{
    List<Button> lstimagebutton;
    List<Button> lstnamebutton;
    List<Image> lstimage;
    List<Image> lstname;
    List<List<Button>> lstallbuttons;
    List<Image> lstmappic;
    List<Label> lstmaplabel;

    Random rnd = new();

    Button? btnimage = null;
    Button? btnname = null;


    Game game = new();

    public PointToPoint()
    {
        InitializeComponent();
        this.BindingContext = game;
        lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
        lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
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
        lstallbuttons = new() { lstimagebutton, lstnamebutton };
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
                    btn.ImageSource = newimage.Source;
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
                    btn.ImageSource = newimage.Source;
                    game.revealimage = false;
                    btnname = btn;
                }
            if (game.GameStatus == Game.GameStatusEnum.finishedplaying)
                {
                    btnNewTurn.IsEnabled = false;
                }
            }
        }

        //Format Button NewTurn
        if (game.imagecardflipped == true && game.namecardflipped == true && game.numberofsetsmatched < 8)
        {
            btnNewTurn.BorderColor = Colors.Crimson;
            btnNewTurn.BorderWidth = 5;
        }
        if (game.imagecardflipped == true && game.namecardflipped == true && game.numberofsetsmatched == 8)
        {
            //btnStart.BorderColor = Colors.Crimson;
            btnStart.BorderWidth = 5;
        }

        if (game.matchedset == true)
        {
            UpdateMap();
        }
    }    
    private void StartResetGame()
    {
        ResetButtons();
        game.StartGame();
    }

    private void UpdateMap()
    {
        if (game.matchedset == true)
        {
            lstmaplabel[game.matchingsetnum].IsVisible = true;
            lstmappic[game.matchingsetnum].IsVisible = true;
        }
    }

    private void ResetNewTurnButton()
    {
        btnNewTurn.IsEnabled = true;
        btnNewTurn.BorderWidth = 0;
        btnNewTurn.TextColor = Colors.White;
    }
    private void NewTurn()
    {
        if ((game.imagecardflipped == true && game.namecardflipped == true && game.matchedset == false) || game.matchedset == true)
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
                btnimage.IsVisible = false;
                btnname.IsVisible = false;
            }
            else
            {
                btnname.ImageSource = null;
                btnimage.ImageSource = null;
            }
        }
    }
    private void ResetButtons()
    {
        foreach (var lst in lstallbuttons)
        {
           foreach(Button btn in lst)
            {
                btn.ImageSource = null;
                btn.IsVisible = true;
            }
        }

        lstmaplabel.ForEach(lbl => lbl.IsVisible = false);
        lstmappic.ForEach(pic => pic.IsVisible = false);
        btnStart.BorderWidth = 0;
        

        ResetNewTurnButton();
    }


    private void BtnPoint_Click(object? sender, EventArgs e)
    {
        DoTurn((Button)sender);
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