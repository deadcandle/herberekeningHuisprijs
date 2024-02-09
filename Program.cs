
using Kansloos_v2;

class Program
{
    static string name = "";
    static void Main(string[] args)
    {
        generateHouses();
    }
    static void generateHouses()
    {
        // Create house
        House tcr = new House();

        // Create rooms for the house
        Room kantine = new Room(16, 16, 6);
        Room ingang = new Room(8, 4, 6);
        Room aula = new Room(20, 20, 8);

        // Add rooms to the house
        tcr.AddRoom(kantine);
        tcr.AddRoom(ingang);
        tcr.AddRoom(aula);

        // Print info of the house
        Console.WriteLine("Inhoud kamers: ");
        foreach (var room in tcr.GetRooms())
        {
            Console.WriteLine("Length: " + room.getLength() + ", breedte: " + room.getWidth() + ", hoogte: " + room.getHeight());
        }
        Console.WriteLine("Volume totaal: " + tcr.getTotalVolume() + " m2");
        Console.WriteLine("Prijs van het huis is: $" + tcr.getPrice() + ".00");
    }
}