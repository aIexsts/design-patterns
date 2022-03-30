using AbstractFactory.Components;
using AbstractFactory.Components.Enums;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class MazeGame
    {
        public Maze CreateMaze(MazeFactory mazeFactory)
        {
            var maze = mazeFactory.MakeMaze();
            var room1 = mazeFactory.MakeRoom(1);
            var room2 = mazeFactory.MakeRoom(2);
            var door = mazeFactory.MakeDoor(room1, room2, "secret-key");
            
            // room 1
            room1.SetSide(Sides.North, mazeFactory.MakeWall());
            room1.SetSide(Sides.East, door);
            room1.SetSide(Sides.South, mazeFactory.MakeWall());
            room1.SetSide(Sides.West, mazeFactory.MakeWall());
            maze.AddRoom(room1);

            // room 2
            room2.SetSide(Sides.North, mazeFactory.MakeWall());
            room2.SetSide(Sides.East, mazeFactory.MakeWall());
            room2.SetSide(Sides.South, mazeFactory.MakeWall());
            room2.SetSide(Sides.West, door);
            maze.AddRoom(room2);

            return maze;
        }
    }
}
