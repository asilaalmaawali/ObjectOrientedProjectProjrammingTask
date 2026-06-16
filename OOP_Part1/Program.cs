using OOP_Part1;

namespace OOP_Part1
{     // Hotel Management System


    public class Room
    {
        // Attributes
        public int roomNumber;
        public string roomType;
        public double pricePerNight;
        public bool isAvailable;


        // Method
        public void displayRoom()
        {
            Console.WriteLine("Room Number:      "+roomNumber);
            Console.WriteLine("Room Type:        "+roomType);
            Console.WriteLine("Price Per Night:  "+pricePerNight);
            Console.WriteLine("Room Availabilty: "+isAvailable);
        }






    }


}





    internal class Program
    {
        static void Main(string[] args)
        {

            List<Room> rooms = new List<Room>();


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
                Console.WriteLine("0. Exit");
                Console.WriteLine("================================================");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
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



