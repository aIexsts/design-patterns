using System.Collections.Generic;
using AbstractFactory.Components.Enums;

namespace AbstractFactory.Components
{
    public class Room
    {
        private int RoomNumber;
        private Dictionary<Sides, Wall> RoomSides = new();

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public void SetSide(Sides side, Wall wall)
        {
            RoomSides.Add(side, wall);
        }
    }
}
