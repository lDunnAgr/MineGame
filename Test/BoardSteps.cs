using Application;
using Domain;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _board = new Board(new Position(0,0));
        }

        private void Moving_Up()
        {
            _board.Move(Direction.Up);
        }

        private void Moving_Down()
        {
            _board.Move(Direction.Down);
        }

        private void Moving_Left()
        {
            _board.Move(Direction.Left);
        }

        private void Moving_Right()
        {
            _board.Move(Direction.Right);
        }

        private void Player_Moves_Up_Once()
        {
            _board.GetPlayerPosition().Vertical.ShouldBe(1);
            _board.GetPlayerPosition().Horizontal.ShouldBe(0);
        }

        private void Player_Moves_Up_Twice()
        {
            _board.GetPlayerPosition().Vertical.ShouldBe(2);
            _board.GetPlayerPosition().Horizontal.ShouldBe(0);
        }

        private void Player_Moves_Left()
        {
            _board.GetPlayerPosition().Horizontal.ShouldBe(0);
            _board.GetPlayerPosition().Vertical.ShouldBe(0);
        }

        private void Player_Moves_Right()
        {
            _board.GetPlayerPosition().Horizontal.ShouldBe(2);
            _board.GetPlayerPosition().Vertical.ShouldBe(0);
        }

        private void A_Board_With_Starting_Position(int horizontal, int vertical)
        {
            _board = new Board(new Position(horizontal, vertical));
        }
    }
}
