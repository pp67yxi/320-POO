using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Fridge : Container
    {
        private int _temperature;

        public Fridge(int temperature, int id, int weight) : base(id, weight)
        {
            _temperature = temperature;
        }
    }
}
