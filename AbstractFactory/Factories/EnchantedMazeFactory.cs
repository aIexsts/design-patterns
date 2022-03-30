using AbstractFactory.Components;
using AbstractFactory.Components.Custom;

namespace AbstractFactory.Factories
{
    public class EnchantedMazeFactory: MazeFactory
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
