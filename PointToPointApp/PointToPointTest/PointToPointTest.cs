using PointToPointSystem;
using static PointToPointSystem.Game;
namespace PointToPointTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStartGame()
        {
            Game game = new();
            game.StartGame();
            string msg = $"game message: {game.GameMessageDescription}";
            Assert.IsTrue(msg == "game message: Click a Button!");
            Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.playing && game.StartButton.StartButtonStatus == StartButton.StartButtonStatusEnum.reset && game.NewTurnButton.IsEnabled == true && game.GameStatus == GameStatusEnum.playing,
            msg = msg + $", GameStatus = {game.GameStatus} " +
            $"StartButtonStatus  = {game.StartButton.StartButtonStatus} " +
            $"NewTurnButtonEnabled = {game.NewTurnButton.IsEnabled}", msg);
            TestContext.WriteLine(msg);
        }

        [Test]

        public void TestEachCardHasDifferentImage()
        {
            Game game = new();
            game.StartGame();
            game.SetupImages();
            game.CurrentCard = CurrentCardPlayingEnum.imagecard;
            game.Turn(0);
            game.Turn(1);
            game.Turn(2);
            game.Turn(3);
            string msg = $"Image number for card 0 = {game.ImageCardList[0].CardValue}, " +
                $"Image number for card 1 = {game.ImageCardList[1].CardValue}, " +
                $"Image number for card 2 = {game.ImageCardList[2].CardValue}, " +
                $"Image number for card 3 = {game.ImageCardList[3].CardValue}, ";
            Assert.IsTrue(game.ImageCardList[1].CardValue != game.ImageCardList[2].CardValue, msg);
            TestContext.WriteLine(msg);
        }

        [TestCase ]
        public void TestMatch()
        {
            Game game = new();
            game.StartGame();
            game.PicImageCard = 1;
            game.PicNameCard = 1;
            game.DetectMatch();
            string msg = $"value of set matched = {game.MatchingSetNum}";
            Assert.IsTrue(game.MatchingSetNum == game.PicImageCard, msg) ;
            TestContext.WriteLine(msg);
        }
        
        [Test]
        public void TestUpdateMap() {
            Game game = new();
            game.MatchingSetNum = 1;
            Assert.IsTrue(game.MapPinList[1].IsVisible = true);
        }

    }
}