using FactoryMethod.Components;
using FactoryMethod.Components.Custom;

namespace FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        public override Room MakeRoom(int roomNumber)
        {
            return new EnchantedRoom(roomNumber);
        }

        public override Door MakeDoor(Room r1, Room r2, string key = "key")
        {
            return new DoorNeedingSpell(r1, r2, key);
        }
    }
}
