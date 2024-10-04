namespace Drones
{
    public partial class Box
    {
        private Color[] _boxColor;                       // La couleur
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                // Position en Y depuis le haut de l'espace aérien
        private int _width;                            // 
        private int _depth;                            // 
        private int _maxKg = 10;
        private int _minKg = 5;

        private enum SmartiesColor
        {
            Red,
            Yellow,
            Blue,
            Brown,
            Orange
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public int Width { get => _width; set => _width = value; }
        public int Depth { get => _depth; set => _depth = value; }

        public Box(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }
}