using parachutes;

Console.Clear();
Console.CursorVisible = false;
Console.WindowHeight = Config.SCREEN_HEIGHT;
Console.WindowWidth = Config.SCREEN_WIDTH;

ConsoleKeyInfo keyPressed;

List<Parachutiste> paraInAir = new List<Parachutiste>();

Plane plane = new Plane();
for (int i = 0; i < 8; i++)
{
    plane.board(new Parachutiste("Bobby" + i.ToString()));
}

while (true)
{
    Console.Clear();
    if (Console.KeyAvailable)
    {
        keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
            case ConsoleKey.Spacebar:
                Parachutiste jumper = plane.dropParachutist();
                paraInAir.Add(jumper);  
                break;
            default:
                break;
        }
    }

    plane.update();
    foreach (Parachutiste parachutiste in paraInAir)
    {

    }
}