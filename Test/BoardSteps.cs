using Application;
using Domain;
using Shouldly;

namespace Test
{
    internal partial class BoardShould : Specification
    {
        private Board _board;

        protected override void before_each()
        {
            base.before_each();
            _board = null;
        }

        private void A_Board()
        {
            _board = new Board(new Position(0, 0), new BoardDimensions(8, 8));
        }

        private void Moving_Up()
        {
            _board.Move(Direction.Up);
        }

        private void Moving_In(Direction direction)
        {
            _board.Move(direction);
        }

        private void Player_Moves_Up_Twice()
        {
            _board.GetPlayerPosition().Vertical.ShouldBe(2);
            _board.GetPlayerPosition().Horizontal.ShouldBe(0);
        }

        private void A_Board_With_Starting_Position(int horizontal, int vertical)
        {
            _board = new Board(new Position(horizontal, vertical), new BoardDimensions(8, 8));
        }

        private void Player_Is_At_Position(Direction direction, int horizontal, int vertical)
        {
            var horizantalEnd = horizontal;
            var verticalEnd = vertical;

            switch (direction)
            {
                case Direction.Up:
                    verticalEnd++;
                    break;
                case Direction.Down:
                    verticalEnd--;
                    break;
                case Direction.Left:
                    horizantalEnd--;
                    break;
                case Direction.Right:
                    horizantalEnd++;
                    break;
            }

            _board.GetPlayerPosition().Horizontal.ShouldBe(horizantalEnd);
            _board.GetPlayerPosition().Vertical.ShouldBe(verticalEnd);
        }

        private void Player_Doesnt_Move(int horizontal, int vertical)
        {
            _board.GetPlayerPosition().Vertical.ShouldBe(vertical);
            _board.GetPlayerPosition().Horizontal.ShouldBe(horizontal);
        }
    }
}
