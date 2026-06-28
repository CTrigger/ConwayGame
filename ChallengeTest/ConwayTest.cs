using Rules;

namespace RulesTest
{
    [TestFixture]
    public class ConwayTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCaseSource(typeof(MatrixMockup), nameof(MatrixMockup.Matrix3x3_0_1))]
        public void NextTest(bool[,] scenario, bool[,] result)
        {
            ConwayGame game = new ConwayGame(scenario);
            game.Next();

            Assert.That(game.table,
                Is.EqualTo(result));
        }
        [Test]
        public void LivingNeighboorsTest()
        {
            ConwayGame game = new ConwayGame(MatrixMockup.Matrix_3x3_B0);
            Assert.That(game.LivingNeighboors(0, 0),
                Is.EqualTo(1));
            Assert.That(game.LivingNeighboors(0, 1),
                Is.EqualTo(3));
            Assert.That(game.LivingNeighboors(0, 2),
                Is.EqualTo(1));

            Assert.That(game.LivingNeighboors(1, 0),
                Is.EqualTo(2));
            Assert.That(game.LivingNeighboors(1, 1),
                Is.EqualTo(2));
            Assert.That(game.LivingNeighboors(1, 2),
                Is.EqualTo(2));

            Assert.That(game.LivingNeighboors(2, 0),
                Is.EqualTo(1));
            Assert.That(game.LivingNeighboors(2, 1),
                Is.EqualTo(1));
            Assert.That(game.LivingNeighboors(2, 2),
                Is.EqualTo(1));


        }
    }
}