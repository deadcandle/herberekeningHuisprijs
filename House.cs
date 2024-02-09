
namespace Kansloos_v2
{
    public class House
    {
        private int volume;
        private List<Room> rooms =new List<Room>();
        public void AddRoom(Room room)
        {
            rooms.Add(room);   
        }
        public List<Room> GetRooms()
        {
            return rooms;
        }
        public int getTotalVolume()
        {
            int total = 0;
            foreach (Room room in rooms)
            {
                total += room.getVolume();
            }
            return total;
        }
        public float getPrice()
        {
            return (float) getTotalVolume() * .25f;
        }
    }
}
