using Builder.Components;

namespace AbstractFactory.Components.Custom
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room r1, Room r2, string key) : base(r1, r2, key)
        {
        }
    }
}
