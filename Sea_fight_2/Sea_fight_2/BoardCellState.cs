using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_fight_2
{
    public enum BoardCellState
    {
        Normal,
        MissedShot,
        Ship,
        ShotShip,
        ShipDrag,
        ShipDragInvalid,
        ShowDrowned
    }
}
