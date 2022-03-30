using AbstractFactory.Components;

namespace Builder.Components
{
    public class Door : Wall
    {
        // Connects two Rooms
        private Room Room1;
        private Room Room2;
        private string Key;

        public Door(Room r1, Room r2, string key)
        {
            this.Room1 = r1;
            this.Room2 = r2;
            this.Key = key;
        }

        public bool Open(string key)
        {
            return key == Key;
        }
    }
}
