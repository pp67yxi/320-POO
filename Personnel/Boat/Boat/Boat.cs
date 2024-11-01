using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Boat
    {
        private int _year;
        private int _tonnage;
        private string _country;
        private List<Container> containers;

        public Boat(int year, int tonnage, string country)
        {
            _year = year;
            _tonnage = tonnage;
            _country = country;
            containers = new List<Container>();
        }

        public bool Load(Container newContainer)
        {
            bool canLoad;
            int boatWeight = 0;
            foreach (Container container in containers)
                boatWeight += container.Weight;

            if (newContainer.Weight + boatWeight <= _tonnage)
            {
                containers.Add(newContainer);
                canLoad = true;
            }
            else
                canLoad = false;
            return canLoad;
        }

        public bool Unload(int id)
        {
            bool canUnload;
            if (containers.Find(c => c.Id == id) != null)
            {
                containers.Remove(containers.Find(c => c.Id == id));
                canUnload = true;
            }
            else
                canUnload = false;
            return canUnload;
        }
    }
}