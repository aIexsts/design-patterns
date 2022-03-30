using System.Collections.Generic;

namespace AbstractFactory.Components
{
    public class Maze
    {
        public readonly List<Room> Rooms = new();

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }
    }
}
