using System.Collections.Generic;
using FactoryMethod.Components.Enums;

namespace FactoryMethod.Components
{
    public class Room
    {
        public int RoomNumber { get; set; }
        private Dictionary<Sides, Wall> RoomSides = new();

        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
        }

        public void SetSide(Sides side, Wall wall)
        {
            if (RoomSides.ContainsKey(side))
            {
                RoomSides[side] = wall;
            }
            else
            {
                RoomSides.Add(side, wall);
            }
        }
    }
}
