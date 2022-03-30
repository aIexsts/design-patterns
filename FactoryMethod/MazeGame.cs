using FactoryMethod.Components;
using FactoryMethod.Components.Enums;

namespace FactoryMethod
{
    public class MazeGame
    {
        public Maze createMaze()
        {
            var maze = MakeMaze();
            var room1 = MakeRoom(1);
            var room2 = MakeRoom(2);
            var door = MakeDoor(room1, room2, "secret-key");

            // room 1
            room1.SetSide(Sides.North, MakeWall());
            room1.SetSide(Sides.East, door);
            room1.SetSide(Sides.South, MakeWall());
            room1.SetSide(Sides.West, MakeWall());
            maze.AddRoom(1, room1);

            // room 2
            room2.SetSide(Sides.North, MakeWall());
            room2.SetSide(Sides.East, MakeWall());
            room2.SetSide(Sides.South, MakeWall());
            room2.SetSide(Sides.West, door);
            maze.AddRoom(2, room2);

            return maze;
        }


        // Factory methods:
        public virtual Maze MakeMaze()
        {
            return new Maze();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }

        public virtual Room MakeRoom(int roomNumber)
        {
            return new Room(roomNumber);
        }

        public virtual Door MakeDoor(Room r1, Room r2, string key = "key")
        {
            return new Door(r1, r2, key);
        }
    }
}
