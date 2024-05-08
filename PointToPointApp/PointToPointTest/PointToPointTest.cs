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

        public void TestTurn()
        {
            Game game = new();
            game.StartGame();
            game.SetupImages();
            game.CurrentCard = CurrentCardPlayingEnum.imagecard;
            game.Turn(1);
            string msg = $"ImageName = {game.ImageCard.ImageName}";
            Assert.IsTrue(game.ImageCard.ImageName != "", msg);
            TestContext.WriteLine(msg);
        }

        [TestCase ]
        public void TestMatch()
        {
            Game game = new();
            game.StartGame();
            game.ImageCard.CardValue = 1;
            game.NameCard.CardValue = 1;
            game.DetectMatch();
            string msg = $"value of set matched = {game.matchingsetnum}";
            Assert.IsTrue(game.matchingsetnum == game.ImageCard.CardValue, msg) ;
            TestContext.WriteLine(msg);
        }
        
        [Test]
        public void TestUpdateMap() {
            Game game = new();
            game.matchingsetnum = 1;
            Assert.IsTrue(game.MapPinList[1].IsVisible = true);
        }

    }
}