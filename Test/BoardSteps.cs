using Application;
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
            _board = new Board();
        }

        private void Moving_Up()
        {
            _board.MovePlayerUp();
        }

        private void Player_Moves_Up()
        {
            _board.GetPlayerPosition().ShouldBe(1);
        }

        private void Player_Moves_Up_Twice()
        {
            _board.GetPlayerPosition().ShouldBe(2);
        }
    }
}
