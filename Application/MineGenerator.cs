using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MineGenerator
    {
        private Random _random = new Random();

        public List<Landmine> GenerateLandMines()
        {
            int defaultCountOfLandMines = 3;
            List<Landmine> landmines = new List<Landmine>();
            List<Position> allPositions = new List<Position>();

            for (int x = 1; x <= 7; x++)
            {
                for (int y = 1; y <= 7; y++)
                {
                    allPositions.Add(new Position(x, y));
                }
            }

            allPositions = allPositions.OrderBy(p => _random.Next()).ToList();


            for (int i = 0; i < defaultCountOfLandMines; i++)
            {
                landmines.Add(new Landmine(allPositions[i]));
            }

            return landmines;
        }
    }
}
