﻿using Drones.Helpers;
using System.Drawing;

namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x ;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        private Rectangle _zone;
        private EvacuationState _evacuationState;

        public int Charge { get => _charge; set => _charge = value; }
        public string Name { get => _name; set => _name = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public Drone (int x, int y)
        {
            _x = x;
            _y = y;
            _evacuationState = EvacuationState.Free;
        }

        public bool Evacuate(Rectangle zone)
        {
            if (zone.IntersectsWith(new Rectangle(X - 4, Y - 2, 8, 8)))
            {
                _evacuationState = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                _evacuationState = EvacuationState.Evacuated;
                return true;
            }
        }

        public void FreeFlight()
        {
            _evacuationState = EvacuationState.Free;
        }

        public EvacuationState GetEvacuationState()
        {
            return _evacuationState;
        }


        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update()
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += RandomHelpers.alea.Next(-2, 3);       // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            Charge--;                                  // Il a dépensé de l'énergie
        }
    }
}