using Builder.Components;
using Builder.Components.Enums;

namespace Builder.Builders
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _maze = null; 
        
        public override void BuildMaze()
        {
            _maze = new Maze();
        }

        public override void BuildRoom(int roomNumber)
        {
            if (!_maze.Rooms.ContainsKey(roomNumber))
            {
                Room room = new Room(roomNumber);
                
                room.SetSide(Sides.North, new Wall());
                room.SetSide(Sides.East, new Wall());
                room.SetSide(Sides.South, new Wall());
                room.SetSide(Sides.West, new Wall());
                
                _maze.AddRoom(roomNumber, room);
            }
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room rFrom = _maze.Rooms[roomFrom];
            Room rTo = _maze.Rooms[roomTo];

            Door d = new Door(rFrom, rTo, "room-key");
            
            rFrom.SetSide(CommonWall(rFrom, rTo), d);
            rTo.SetSide(CommonWall(rTo, rFrom), d);
        }

        public override Maze GetMaze()
        {
            return _maze;
        }

        // Determine direction of common wall between Rooms
        private Sides CommonWall(Room room1, Room room2)
        {
            if (room1.RoomNumber > room2.RoomNumber)
            {
                return Sides.East;
            }

            return Sides.West;
        }
    }
}
