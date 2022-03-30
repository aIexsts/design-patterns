using System;

namespace Builder.Builders
{
    public class CountingMazeBuilder : StandardMazeBuilder
    {
        private int rooms = 0;
        private int doors = 0;

        public override void BuildRoom(int roomNumber)
        {
            base.BuildRoom(roomNumber);
            rooms++;
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            base.BuildDoor(roomFrom, roomTo);
            doors++;
        }

        public void GetCounts()
        {
            Console.WriteLine($"Maze build using: {rooms} rooms and {doors} doors");
        }
    }
}
