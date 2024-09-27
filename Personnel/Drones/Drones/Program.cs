using Drones.Helpers;

namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            for (int i = 1; i <= RandomHelpers.alea.Next(1, 10); i++)
            {
                Drone drone = new Drone(RandomHelpers.alea.Next(0, AirSpace.WIDTH), RandomHelpers.alea.Next(0, AirSpace.HEIGHT));
                drone.Name = ("Arthur " + i);
                fleet.Add(drone);
            }

            List<Building> buildings = new List<Building>();
            for (int i = 0; i < RandomHelpers.alea.Next(1, 5); i++)
            {
                Factory building = new Factory();
                building.BuildingColor = Color.Blue;
                building.Width = 10;
                building.Depth = 10;
                building.X = RandomHelpers.alea.Next(0 + building.Width, AirSpace.WIDTH - building.Width);
                building.Y = RandomHelpers.alea.Next(0 + building.Depth, AirSpace.HEIGHT - building.Depth);
                buildings.Add(building);
            }
            for (int i = 0; i < RandomHelpers.alea.Next(1, 5); i++)
            {
                Store building = new Store();
                building.BuildingColor = Color.Red;
                building.Width = 10;
                building.Depth = 10;
                building.X = RandomHelpers.alea.Next(0 + building.Width, AirSpace.WIDTH - building.Width);
                building.Y = RandomHelpers.alea.Next(0 + building.Depth, AirSpace.HEIGHT - building.Depth);
                buildings.Add(building);
            }

            try
            {
                // Démarrage
                Application.Run(new AirSpace(fleet, buildings));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}