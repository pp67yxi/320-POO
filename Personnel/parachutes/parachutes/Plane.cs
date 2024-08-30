using parachutes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parachutes
{
    class Plane
    {
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        public int x;
        public int altitude;
        public List<Parachutiste> parachutistes;

        public Plane()
        {
            x = 0;
            altitude = Config.SCREEN_HEIGHT;
            parachutistes = new List<Parachutiste>();
        }

        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(view[i]);
            }
        }

        public void update()
        {
            if (x >= Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            else
            {
                x++;
            }
        }

        public void board(Parachutiste para)
        {
            this.parachutistes.Add(para);
        }

        internal Parachutiste dropParachutist()
        {
            Parachutiste parachutist = parachutistes.First();
            parachutistes.Remove(parachutist);
            parachutist.x = x;
            parachutist.altitude = this.altitude;
            return parachutist;
        }
    }
}