﻿namespace Drones
{
    public partial class Building
    {
        private Color _buidlingColor;                   // La couleur
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private int _width;                             // 
        private int _depth;                             // 

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public Color BuildingColor
        {
            get => _buidlingColor;
            set
            {
                _buidlingColor = value;
                _buildingBrush = new Pen(new SolidBrush(BuildingColor), 3);
            }
        }
        public int Width { get => _width; set => _width = value; }
        public int Depth { get => _depth; set => _depth = value; }
    }

    public class Factory : Building
    {
        private int _PowerConsumption;
    }

    public partial class Store : Building
    {
        private string[] _openingHours;
    }
}