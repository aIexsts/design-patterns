using Builder.Components;

namespace Builder.Builders
{
    public abstract class MazeBuilder
    {
        public abstract void BuildMaze();
        public abstract void BuildRoom(int roomNumber);
        public abstract void BuildDoor(int roomFrom, int roomTo);
        
        // only one final method returns complex Object:
        public abstract Maze GetMaze();
    }
}
