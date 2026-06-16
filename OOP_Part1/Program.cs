using OOP_Part1;
using System.Xml.Linq;

namespace OOP_Part1
{     // Hotel Management System


    public class Room
    {
        // Attributes
        public int roomNumber; // because i just give the number no one can edit
        public string roomType;
        public double pricePerNight;  // if i want to encapsulate later : public double PricePerNight { get; set; }
        public bool isAvailable; // by default the room be available  

       
        public Room(int room , string type , double price )// adding construtor because i want by default room be available
        {
            roomNumber = room ;
            roomType = type ;
            pricePerNight = price ;
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


    public class Guest
    {
        //Attributes
        public string guestId { get; }
        public string guestName;
        public int roomNumber;
        public string checkInDate;
        public int totalNights;

        // should be inside guest class the construtor
        public Guest(string Id, string Name , string check_InDate, int total_Nights) // adding construtor // roomNumber as default zero

        {

            guestId = Id; 
            guestName = Name;  // save the guest name that entered by the user into the guestName attribute
            checkInDate = check_InDate;
            totalNights = total_Nights;

            roomNumber = 0; // no room assigned yet , will book in case 03 , here just as default i do it 0

        }


        //Methods
        public void displayGuest()
        {
            Console.WriteLine("Guest ID:      " + guestId);
            Console.WriteLine("Guest name:    " + guestName);
            Console.WriteLine("Room Number:   " + roomNumber);
            Console.WriteLine("check-In Date: " + checkInDate);
            Console.WriteLine("totalNights:   " + totalNights);

        }




        //    public void calculateTotalCost()
        //    {




        //    }



    }



    internal class Program
    {

        // here the defined function
        public static void AddRoom(List<Room> rooms)
        {



            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());


            if (rooms.Any(r => r.roomNumber == roomNumber))   // i use LINQ Any()for the duplicate check to check if a room with the same room number already exists in the rooms list

            {
                Console.WriteLine("Room number already exists");
                return;  // to go back to the main
            }

            if (roomNumber <= 0)      // to validate the number should be more than 0 and should be positive
            {
                Console.WriteLine("Room number must be positive and more than 0");
                return;
            }

            Console.Write("Enter room type (single/double/suite): ");   // to avoid adding the room type wrong
            string roomType = Console.ReadLine().Trim().ToLower();


            if (roomType != "single" &&
                roomType != "double" &&
                roomType != "suite")
            {
                Console.WriteLine("Invalid room type.");
                return;
            }

            Console.Write("Enter price per night: ");
            double pricePerNight = double.Parse(Console.ReadLine());


            if (pricePerNight <= 0)   // to validate the number should be more than 0 and should be positive
            {

                Console.WriteLine("Price must be positive and more than 0");
                return;
            }


            
            rooms.Add(new Room(roomNumber, roomType, pricePerNight)); // here to add room object in rooms list


            Console.WriteLine("Room added successfully");

            Console.WriteLine("--- All Rooms ---");
            foreach (Room r in rooms) // 
            {
                r.displayRoom();  // display one room at a time
            }
            Console.WriteLine("Total Rooms: " + rooms.Count); // room count



        }
        public static void RegGuest(List<Guest> guests)
        {


            Console.Write("Enter Guest name:   ");
            string guestName = Console.ReadLine().Trim().ToLower();


            Console.Write("Enter Check-In Date (DD/MM/YYYY):   ");
            string checkInDate = Console.ReadLine();


            Console.Write("number of nights:   ");
            int totalNights = int.Parse(Console.ReadLine());

            string guestId;
            guestId = "G" + (guests.Count + 1).ToString("D3"); // here to generate the ID + converted to string with at least 3 digits.   // Auto-generate the guest ID from the current size of the guests list.

           guests.Add(new Guest(guestId, guestName, checkInDate, totalNights));   // add guest object in guests list

        }


        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>() {         // to add it in rooms list , is available by default true no need to write it here  // create preload list of room 
            new Room (101, "single", 25 ),
            new Room (102, "double", 50),
            new Room (103, "single", 25),
            new Room (104, "suite", 100),
            new Room (105, "double", 50 ),
            new Room (106, "suite", 100 ),
           };

            List<Guest> guests = new List<Guest>();


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

                    case 1:      // Case 01: Add New Room
                        AddRoom(rooms);  // here to call function with list
                        break;

                    case 2:    // Case 02 Register New Guest
                        RegGuest(guests);
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



