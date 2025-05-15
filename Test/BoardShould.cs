using Domain;

namespace Test
{
    [TestFixture]
    internal partial class BoardShould
    {
        [TestCase(Direction.Up, 0, 0)]
        [TestCase(Direction.Down, 0, 1)]
        [TestCase(Direction.Left, 1, 0)]
        [TestCase(Direction.Right, 0, 0)]
        public void AllowPlayerToMove(Direction direction, int horizontalStart, int verticalStart)
        {
            Given(() => A_Board_With_Starting_Position(horizontalStart, verticalStart));
            When(() => Moving_In(direction));
            Then(() => Player_Is_At_Position(direction, horizontalStart, verticalStart));
        }

        [Test]
        public void AllowPlayerToMoveUpTwice()
        {
            Given(A_Board);
            When(Moving_Up);
            And(Moving_Up);
            Then(Player_Moves_Up_Twice);
        }
    }
}
