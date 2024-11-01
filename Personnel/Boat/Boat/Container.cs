using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Container
    {
        private int _id;
        private int _weight;

        public Container(int id, int weight)
        {
            _id = id;
            _weight = weight;
        }

        public int Id { get => _id; }
        public int Weight { get => _weight; }
    }
}
