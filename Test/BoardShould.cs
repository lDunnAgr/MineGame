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

        [TestCase(Direction.Up, 0, 7)]
        [TestCase(Direction.Down, 0, 0)]
        [TestCase(Direction.Right, 7, 0)]
        [TestCase(Direction.Left, 0, 0)]
        public void PlayerCannotMoveOffBoard(Direction direction, int horizontalStart, int verticalStart)
        {
            Given(() => A_Board_With_Starting_Position(horizontalStart, verticalStart));
            When(() => Moving_In(direction));
            Then(() => Player_Doesnt_Move(horizontalStart, verticalStart));
        }

        [Test]
        public void AllowPlayerToStepOnLandMine()
        {
            Given(A_Board_With_A_Landmine);
            When(Player_Steps_On_Landmine);
            Then(Player_Loses_A_Life);
        }

        [Test]
        public void LandMineDoesNotDetonateTwice()
        {
            Given(A_Board_With_A_Landmine);
            And(Player_Steps_On_Landmine);
            And(() => Moving_In(Direction.Down));
            When(() => Moving_In(Direction.Up));
            Then(Player_Has_Only_Lost_One_Life);
        }

        [Test]
        public void BoardShouldNotAllowDeadPlayerToMove()
        {
            Given(A_Board_Has_Three_Landmines);
            And(A_Player_Has_Stepped_On_All_Landmines);
            When(Moving_Up);
            Then(Do_Not_Move);
        }
    }
}
