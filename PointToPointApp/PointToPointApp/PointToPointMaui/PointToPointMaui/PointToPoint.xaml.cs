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


    Game GameNorth = new();
    Game GameSouth = new();
    Game GameEast = new();
    Game GameWest = new();

    List<Game> lstgame = new();
    


    Game activegame;
    public PointToPoint()
    {
        InitializeComponent();

        lstgame = new () {GameNorth, GameSouth, GameEast, GameWest };
        lstgame.ForEach(g => g.ScoreChanged += G_ScoreChanged);
        

        GameNorthRb.BindingContext = GameNorth;
        GameSouthRb.BindingContext = GameSouth;
        GameEastRb.BindingContext = GameEast;
        GameWestRb.BindingContext = GameWest;
        activegame = GameNorth;
        this.BindingContext = activegame;

        lstimagebutton = new() { btnImage1, btnImage2, btnImage3, btnImage4, btnImage5, btnImage6, btnImage7, btnImage8 };
        lstnamebutton = new() { btnName9, btnName10, btnName11, btnName12, btnName13, btnName14, btnName15, btnName16 };
        lstimage = new() { arihakadosh, churva, keverrochel, kosel, mearashamechpela, rabbimeirbalhaness, rabishimonbaryochai, yamhamelech };
        lstname = new() { arihakadoshwithname, churvawithname, keverrochelwithname, koselwithname, mearashamechpelawithname, rabbimeirbalhanesswithname, rabishimonbaryochaiwithname, yamhamelechwithname };
        lstallbuttons = new() { lstimagebutton, lstnamebutton };
    }

    private void G_ScoreChanged(object sender, EventArgs e)
    {
        ScoreLbl.Text = Game.gameswon.ToString();
    }

    private void DoTurn(Button btn)
    {
        if (activegame.GameStatus == Game.GameStatusEnum.playing)
        {
            if (lstimagebutton.Exists(b => b == btn))
            {
                if (activegame.ImageCardFlipped == false)
                {
                    activegame.ButtonImageCard = lstimagebutton.IndexOf(btn);
                    activegame.CurrentCard = Game.CurrentCardPlayingEnum.imagecard;
                    activegame.Turn(lstimagebutton.IndexOf(btn));

                    if (activegame.RevealImage == true)
                    {
                        Image newimage = lstimage[activegame.PicImageCard];
                        btn.ImageSource = newimage.Source;
                        btnimage = btn;
                        activegame.RevealImage = false;
                    }
                }
            }
            else if (lstnamebutton.Exists(b => b == btn))
            {
                if (activegame.NameCardFlipped == false)
                {
                    activegame.ButtonNameCard = lstnamebutton.IndexOf(btn);
                    activegame.CurrentCard = Game.CurrentCardPlayingEnum.namecard;
                    activegame.Turn(lstnamebutton.IndexOf(btn));

                    if (activegame.RevealImage == true)
                    {
                        Image newimage = lstname[activegame.PicNameCard];
                        btn.ImageSource = newimage.Source;
                        btnname = btn;
                        activegame.RevealImage = false;
                    }
                }
            }
        }
    }

    private void NewTurn()
    {
        if ((activegame.ImageCardFlipped == true && activegame.NameCardFlipped == true && activegame.MatchedSet == false) || activegame.MatchedSet == true)
        {
            if (activegame.MatchedSet == false)
            {
                btnname.ImageSource = "blankpoint.jpg";
                btnimage.ImageSource = "blankpoint.jpg";
            }
            activegame.NewTurn();
        }
    }

    private void StartGame()
    {
        lstallbuttons.ForEach(lst => lst.ForEach(crd => crd.ImageSource = null));
        activegame.StartGame();
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

    private void Game_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton rb = (RadioButton)sender;
        if (rb.IsChecked && rb.BindingContext != null)
        {
            activegame = (Game)rb.BindingContext;
            this.BindingContext = activegame;
            if (activegame.NewGame == true)
            {
                lstimagebutton.ForEach(btn => btn.ImageSource = null);
                lstnamebutton.ForEach(btn => btn.ImageSource = null);
                activegame.NewGame = false;
            }
        }
    }
}
    
