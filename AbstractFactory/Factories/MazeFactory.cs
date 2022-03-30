using AbstractFactory.Components;

namespace AbstractFactory.Factories
{
    public class MazeFactory
    {
        public Maze MakeMaze()
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
