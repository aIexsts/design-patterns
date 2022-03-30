using System.Collections.Generic;
using AbstractFactory.Components;

namespace Builder.Components
{
    public class Maze
    {
        public readonly Dictionary<int, Room> Rooms = new();

        public void AddRoom(int roomNumber, Room room)
        {
            Rooms.Add(roomNumber, room);
        }
    }
}
