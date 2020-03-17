using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_fight_2
{
    public class DraggableShip : Ship
    {
        private DraggableShip(int length)
            : base(length)
        {
        }

        public Ship Source { get; private set; }

        public static DraggableShip From(Ship ship)
        {
            var draggableShip = new DraggableShip(ship.Length)
            {
                X = ship.X,
                Y = ship.Y,
                Orientation = ship.Orientation,
                Source = ship
            };

            return draggableShip;
        }

        public bool IsOrientationModified { get; set; }
    }
}