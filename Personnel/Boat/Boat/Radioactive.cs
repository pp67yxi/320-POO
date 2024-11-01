using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Radioactive : Container
    {
        private int _randMax;

        public Radioactive(int randMax, int id, int weight) : base(id, weight)
        {
            _randMax = randMax;
        }
    }
}
