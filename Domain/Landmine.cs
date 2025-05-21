using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Landmine(Position Position)
    {
        private bool _hasDetonated = false;

        public Position GetPosition()
        {
            return Position;
        }

        public bool HasDetonated()
        {
            return _hasDetonated;
        }

        public void Detonate()
        {
            _hasDetonated = true;
        }
    }
}
