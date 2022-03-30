using Builder.Builders;
using Builder.Components;

namespace Builder
{
    // this class acts as Director:
    public class MazeGame
    {
        public Maze CreateMaze(MazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();
            mazeBuilder.BuildRoom(1);
            mazeBuilder.BuildRoom(2);
            mazeBuilder.BuildDoor(1, 2);

            return mazeBuilder.GetMaze();
        }
        
        public Maze CreateComplexMaze(MazeBuilder mazeBuilder)
        {
            mazeBuilder.BuildMaze();

            for (int i = 0; i < 100; i++)
            {
                mazeBuilder.BuildRoom(1 + i);
                mazeBuilder.BuildRoom(2 + i);
                mazeBuilder.BuildDoor(1 + i, 2 + i); 
            }
            return mazeBuilder.GetMaze();
        }
    }
}
