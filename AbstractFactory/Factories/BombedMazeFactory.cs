using AbstractFactory.Components;
using AbstractFactory.Components.Custom;

namespace AbstractFactory.Factories
{
    public class BoombedMazeFactory: MazeFactory
    { 
        public override Wall MakeWall()
        {
            return new BombedWall();
        }

        public override Room MakeRoom(int roomNumber)
        {
            return new RoomWithABomb(roomNumber);
        }
    }
}
