namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int life = 50;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            while (life != 0)
            {
                Console.SetCursorPosition(x+1, 3);
                Console.Write(life);

                Console.SetCursorPosition(x, 5);
                Console.Write("_@_ö");
                x++;
                life--;
                Thread.Sleep(100);
                Console.Clear();
            }
            Console.SetCursorPosition(x, 5);
            Console.Write("____");
            Console.ReadKey();
        }
    }
}