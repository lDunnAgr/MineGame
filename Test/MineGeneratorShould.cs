using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestFixture]
    public partial class MineGeneratorShould
    {
        [Test]
        public void MineGeneratorShouldCreateRandomMines()
        {
            Given(A_Mine_Generator);
            When(Generating_Mines);
            Then(At_Least_Three_Landmines_Are_Generated);
            And(No_Landmines_Share_The_Same_Position);
            And(No_Landmines_Are_In_The_Starting_Position);
        }
    }
}
