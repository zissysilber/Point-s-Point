using PointToPointSystem;
using Image = Microsoft.Maui.Controls.Image;
namespace PointToPointMaui;

public partial class PointToPoint : ContentPage
{
    List<Button> lstimagebutton;
    List<Button> lstnamebutton;
    List<Image> lstimage;
    List<Image> lstname;
    List<List<Button>> lstallbuttons;

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
        lstimage = new() { arihakadosh, churva, keverrochel, kosel, mearashamechpela, rabbimeirbalhaness, rabishimonbaryochai, yamhamelech };
        lstname = new() { arihakadoshwithname, churvawithname, keverrochelwithname, koselwithname, mearashamechpelawithname, rabbimeirbalhanesswithname, rabishimonbaryochaiwithname, yamhamelechwithname };
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
                    btnimage = btn;
                    btnimage.BindingContext = game.ImageCard;
                    Image newimage = lstimage[game.ImageCard.CardValue];
                    btnimage.ImageSource = newimage.Source;
                    game.revealimage = false;
                }
            }
            else if (lstnamebutton.Exists(b => b == btn))
            {
                game.CurrentCard = Game.CurrentCardPlayingEnum.namecard;
                game.Turn(lstnamebutton.IndexOf(btn));

                if (game.revealimage == true)
                {
                    btnname = btn;
                    btnname.BindingContext = game.NameCard;
                    Image newimage = lstname[game.NameCard.CardValue];
                    btn.ImageSource = newimage.Source;
                    game.revealimage = false;
                }
            }
        }
    }

    private void NewTurn()
    {
        if ((game.imagecardflipped == true && game.namecardflipped == true && game.matchedset == false) || game.matchedset == true)
        {
            if (game.matchedset == false)
            {
                btnname.ImageSource = null;
                btnimage.ImageSource = null;
            }
            game.NewTurn();
        }
    }

    private void StartGame()
    {
        lstallbuttons.ForEach(lst => lst.ForEach(crd => crd.ImageSource = null));
        game.StartGame();
    }

    private void BtnPoint_Click(object? sender, EventArgs e)
    {
        DoTurn((Button)sender);
    }

    private void btnStart_Clicked(object sender, EventArgs e)
    {
        StartGame();
    }

    private void btnNewTurn_Clicked(object sender, EventArgs e)
    {
        NewTurn();
    }


}