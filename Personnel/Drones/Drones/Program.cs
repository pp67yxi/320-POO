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
            for (int i = 0; i < RandomHelpers.alea.Next(1, 10); i++)
            {
                Drone drone = new Drone();
                drone.X = RandomHelpers.alea.Next(0, AirSpace.WIDTH);
                drone.Y = RandomHelpers.alea.Next(0, AirSpace.HEIGHT);
                drone.Name = "Arthur";
                fleet.Add(drone);
            }

            List<Building> buildings = new List<Building>();
            for (int i = 0; i < RandomHelpers.alea.Next(1, 10); i++)
            {
                Building building = new Building();
                building.BuildingColor = Color.Black;
                building.Width = 10;
                building.Depth = 10;
                building.X = RandomHelpers.alea.Next(0 + building.Width, AirSpace.WIDTH - building.Width);
                building.Y = RandomHelpers.alea.Next(0 + building.Depth, AirSpace.HEIGHT - building.Depth);
                buildings.Add(building);
            }

            // Démarrage
            Application.Run(new AirSpace(fleet, buildings));
        }
    }
}