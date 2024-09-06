using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    internal class Ball
    {
        private string viewBall = "☻";

        private int x = Cube.X + 5;
        private int y = Cube.Y + 5;

        private const int speedX = 2;
        private const int speedY = 1;

        private int directionX = speedX;
        private int directionY = -speedY;

        internal void update()
        {
            {
                if (x + 1 >= Cube.X + Cube.CUBE_WIDTH)
                {
                    directionX = -speedX;
                    directionY = speedY;
                }
                else if (x - 1 <= Cube.CUBE_WIDTH)
                {
                    directionX = speedX;
                    directionY = -speedY;
                }
                else if (y + 1 >= Cube.Y + Cube.CUBE_HEIGHT)
                {
                    directionX = -speedX;
                    directionY = -speedY;
                }
                else if (y - 1 <= Cube.CUBE_HEIGHT)
                {
                    directionX = speedX;
                    directionY = speedY;
                }

                x = x + directionX;
                y = y + directionY;
            }
        }

        public void draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(viewBall);
        }
    }
}
