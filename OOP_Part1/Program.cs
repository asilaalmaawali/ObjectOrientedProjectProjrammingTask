using OOP_Part1;

namespace OOP_Part1
{     // Hotel Management System


    public class Room
    {
        // Attributes
        public int roomNumber; // because i just give the number no one can edit
        public string roomType;
        public double pricePerNight;  // if i want to encapsulate later : public double PricePerNight { get; set; }
        public bool isAvailable; // by default the room be available  

        public Room()     // adding construtor because i want by default room be available
        {
            isAvailable = true; // every new room is available by default
        }

        // Method
        public void displayRoom()
        {
            Console.WriteLine("Room Number:      "+roomNumber);
            Console.WriteLine("Room Type:        "+roomType);
            Console.WriteLine("Price Per Night:  "+pricePerNight);
            Console.WriteLine("Room Availability: " + (isAvailable ? "Available" : "Not Available")); // i do check from here to be not duplicate in (add room fuction) in in this method.
        }

    }




    internal class Program
    {

        static List<Room> rooms = new List<Room>();    // create preload list of room 


        public static void AddRoom()
        {

            Room room = new Room(); //  to create a new Room object


            Console.Write("Enter room number: ");
            room.roomNumber = int.Parse(Console.ReadLine());

            if (rooms.Any(r => r.roomNumber == room.roomNumber))   // i use LINQ Any()for the duplicate check to check if a room with the same room number already exists in the rooms list

            {
                Console.WriteLine("Room number already exists");
                return;  // to go back to the main
            }

            if (room.roomNumber <= 0)      // to validate the number should be more than 0 and should be positive
            {
                Console.WriteLine("Room number must be positive and more than 0");
                return;
            }

            Console.Write("Enter room type (single/double/suite): ");   // to avoid adding the room type wrong
            room.roomType = Console.ReadLine().Trim().ToLower();

            if (room.roomType != "single" &&
                room.roomType != "double" &&
                room.roomType != "suite")
            {
                Console.WriteLine("Invalid room type.");
                return;
            }

            Console.Write("Enter price per night: ");
            room.pricePerNight = double.Parse(Console.ReadLine());

            if (room.pricePerNight <= 0)   // to validate the number should be more than 0 and should be positive
            {

                Console.WriteLine("Price must be positive and more than 0");
                return;
            }

            rooms.Add(room);  // here to add room object in rooms list

            Console.WriteLine("Room added successfully");
            room.displayRoom(); //here i call display method to display all room info
            Console.WriteLine("Total Rooms: " + rooms.Count); // room count


        }



        static void Main(string[] args)
        {

           // to add it in rooms list , is available by default true no need to write it here
            rooms.Add(new Room { roomNumber = 101, roomType = "single", pricePerNight = 25 });
            rooms.Add(new Room { roomNumber = 102, roomType = "double", pricePerNight = 50 });
            rooms.Add(new Room { roomNumber = 103, roomType = "single", pricePerNight = 25 });
            rooms.Add(new Room { roomNumber = 104, roomType = "suite", pricePerNight = 100 });
            rooms.Add(new Room { roomNumber = 105, roomType = "single", pricePerNight = 25 });
            rooms.Add(new Room { roomNumber = 106, roomType = "double", pricePerNight = 50 });
            rooms.Add(new Room { roomNumber = 107, roomType = "suite", pricePerNight = 100 });



            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("GRAND VISTA HOTEL — MANAGEMENT SYSTEM");
                Console.WriteLine("================================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room for a Guest");
                Console.WriteLine("4. Search & Filter Rooms");
                Console.WriteLine("5. Guest & Booking Statistics");
                Console.WriteLine("6. Check Out a Guest");
                Console.WriteLine("7. Remove Unavailable Rooms");
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                Console.WriteLine("Enter your choice:   ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        AddRoom();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        exit = true;
                        break;


                }
                Console.WriteLine("press any key to continue...");
                Console.ReadKey();  // to press any key to clear
                Console.Clear(); // clear the console 

            }
        }
    }
}



