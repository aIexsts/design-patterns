using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            MazeFactory mazeFactory = new MazeFactory();
            
            MazeGame mazeGame = new MazeGame();
            
            // Create Default maze using abstract factory:
            var maze1 = mazeGame.CreateMaze(mazeFactory);
            
            // Create using concrete custom factories
            var maze2 = mazeGame.CreateMaze(new BoombedMazeFactory());
            var maze3 = mazeGame.CreateMaze(new EnchantedMazeFactory());
            
            Console.WriteLine("Mazes created");
        }
    }
}
