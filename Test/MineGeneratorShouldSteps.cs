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
    public partial class MineGeneratorShould : Specification
    {
        private MineGenerator _mineGenerator;
        private List<Landmine> _generatedLandmines;

        protected override void before_each()
        {
            base.before_each();
            _mineGenerator = null;
            _generatedLandmines = null;
        }

        private void A_Mine_Generator()
        {
            _mineGenerator = new MineGenerator();
        }

        private void Generating_Mines()
        {
            _generatedLandmines = _mineGenerator.GenerateLandMines();
        }

        private void At_Least_Three_Landmines_Are_Generated()
        {
            _generatedLandmines.Count().ShouldBe(3);
        }

        private void No_Landmines_Share_The_Same_Position()
        {
            var positions = new List<Position>();

            foreach (var mine in _generatedLandmines)
            {
                Position position = mine.GetPosition();
                positions.Add(position);
            }

            var uniquePositons = positions.Distinct().ToList();

            uniquePositons.Count().ShouldBe(_generatedLandmines.Count());
        }

        private void No_Landmines_Are_In_The_Starting_Position()
        {
            Position startingPosition = new Position(0, 0);
            foreach (var mine in _generatedLandmines)
            {
                Position position = mine.GetPosition();
                position.ShouldNotBe(startingPosition);
            }
        }
    }
}
