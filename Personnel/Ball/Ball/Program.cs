using System.Numerics;

namespace Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Cube cube = new Cube();
            Ball ball = new Ball();

            while (true)
            {
                Console.Clear();

                ball.update();
                
                ball.draw();
                cube.draw();

                Thread.Sleep(100);
            }
        }
    }
}