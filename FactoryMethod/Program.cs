using System;

namespace FactoryMethod
{
    class Program
    { 
        static void Main(string[] args)
        {
            MazeGame mazeGame = new MazeGame(); 
            
            // Creational pattern delegates creation to subclasses of MazeGame
            mazeGame = new BombedMazeGame();
            mazeGame = new EnchantedMazeGame();
        }
    }
}
