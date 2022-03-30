using System;
using Builder.Builders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeBuilder standardMazeBuilder = new StandardMazeBuilder();
            MazeGame mazeGame = new MazeGame();

            mazeGame.CreateMaze(standardMazeBuilder);
            mazeGame.CreateComplexMaze(standardMazeBuilder);

            // This is optional and considered as a bad example!
            CountingMazeBuilder countingMazeBuilder = new CountingMazeBuilder();
            mazeGame.CreateMaze(countingMazeBuilder);
            countingMazeBuilder.GetCounts();
            
            CountingMazeBuilder countingMazeBuilder2 = new CountingMazeBuilder();
            mazeGame.CreateComplexMaze(countingMazeBuilder2);
            countingMazeBuilder2.GetCounts();
            
            // c# functional way:
            var person = new PersonBuilder()
                .Called("Lucas")
                .WorkAs("Developer")
                .Build();
        }
    }
}
