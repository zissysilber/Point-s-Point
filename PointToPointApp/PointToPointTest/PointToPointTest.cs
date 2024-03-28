using PointToPointSystem;
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
            string msg = $"game message {game.GameMessageDescription}";
            //Assert.IsTrue(game.GameStatus == Game.GameStatusEnum.playing && game.StartButton.StartButtonStatusEnum == StartButton.StartButtonStatusEnum.reset, msg);
            TestContext.WriteLine(msg);
        }
    }
}