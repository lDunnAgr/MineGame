using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Landmine(Position Position)
    {
        public Position GetPosition()
        {
            return Position;
        }
    }
}
