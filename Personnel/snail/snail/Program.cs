namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Snail> snails = new List<Snail>();

            Snail bobby = new Snail();
            Snail isabelle = new Snail();

            snails.Add(bobby);
            snails.Add(isabelle);

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (Snail snail in snails)
            {
                while (snail.hp != 0)
                {
                    Console.SetCursorPosition(snail.x + 1, 3);
                    Console.Write(snail.hp);

                    Console.SetCursorPosition(snail.x, 5);
                    Console.Write(snail.alive);
                    snail.x++;
                    snail.hp--;
                    Thread.Sleep(100);
                    Console.Clear();
                }
                Console.SetCursorPosition(snail.x, 5);
                Console.Write(snail.dead);
            }
            Console.ReadKey();
        }
    }
}