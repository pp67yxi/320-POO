using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ball
{
    internal class Cube
    {
        private string viewCubePart = "*";

        private const int _CUBE_WIDTH = 20;
        private const int _CUBE_HEIGHT = 10;

        private const int _x = 20;
        private const int _y = 10;

        public static int CUBE_WIDTH => _CUBE_WIDTH;
        public static int CUBE_HEIGHT => _CUBE_HEIGHT;
        public static int X => _x;
        public static int Y => _y;

        public void draw()
        {
            for (int i = 0; i <= CUBE_WIDTH; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write(viewCubePart);
            }
            for (int i = 0; i <= CUBE_WIDTH; i++)
            {
                Console.SetCursorPosition(X + i, Y + CUBE_HEIGHT);
                Console.Write(viewCubePart);
            }
            for (int i = 0; i <= CUBE_HEIGHT; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.Write(viewCubePart);
            }
            for (int i = 0; i <= CUBE_HEIGHT; i++)
            {
                Console.SetCursorPosition(X + CUBE_WIDTH, Y + i);
                Console.Write(viewCubePart);
            }
        }
    }
}
