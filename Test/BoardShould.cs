﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    internal partial class BoardShould
    {
        [Test]
        public void AllowPlayerToMoveUp()
        {
            Given(A_Board);
            When(Moving_Up);
            Then(Player_Moves_Up_Once);
        }

        [Test]
        public void AllowPlayerToMoveUpTwice()
        {
            Given(A_Board);
            When(Moving_Up);
            And(Moving_Up);
            Then(Player_Moves_Up_Twice);
        }

        [Test]
        public void AllowPlayerToMoveDown()
        {
            Given(A_Board);
            When(Moving_Up);
            And(Moving_Up);
            And(Moving_Down);
            Then(Player_Moves_Up_Once);
        }
    }
}
