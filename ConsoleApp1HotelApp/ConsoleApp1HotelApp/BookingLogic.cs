using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1HotelApp
{

    public static class BookingLogic
    {
        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> InitialiseHotelRooms()
        {
            var hotelRooms = new Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)>();


            hotelRooms.Add(1, ("single", "booked", "", 0));
            hotelRooms.Add(2, ("single", "booked", "", 0));
            hotelRooms.Add(3, ("single", "full", "", 0));
            hotelRooms.Add(4, ("single", "booked", "", 0));
            hotelRooms.Add(5, ("single", "empty", "", 0));
            hotelRooms.Add(6, ("double", "booked", "", 0));
            hotelRooms.Add(7, ("double", "booked", "", 0));
            hotelRooms.Add(8, ("double", "booked", "", 0));
            hotelRooms.Add(9, ("double", "empty", "", 0));
            hotelRooms.Add(10, ("double", "full", "", 0));

            return hotelRooms;
        }

        public static int GetGuestTotal()
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("How many guests in your party:");
                string guestTotalText = Console.ReadLine();
                isValidNumber = int.TryParse(guestTotalText, out output);

            } while (isValidNumber == false);

            return output;
        }

        public static string GetGuestName()
        {
            Console.Write("What is your surname:");
            string guestName = Console.ReadLine();
            return guestName;
        }

        public static string GetRoomType()
        {
            bool isValidRoom = false;
            string roomTypeText = "";

            do
            {
                Console.Write("Would you like a single or double room? Enter single or double:");
                roomTypeText = Console.ReadLine();
                isValidRoom = (roomTypeText.ToLower() != "double") || (roomTypeText.ToLower() != "single");
            } while (isValidRoom == false);

            return roomTypeText;
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there more guest coming (yes/no): ");
            string continueLooping = Console.ReadLine();

            bool output = (continueLooping.ToLower() == "yes"); //read like if equates to true or false
            return output;
        }

        public static (List<int> roomSingleIds, List<int> roomDoubleIds, Dictionary  <int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)>) GetRoomsAvailable(string roomType, Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            List<int> roomSingleIds = new List<int>(4);
            List<int> roomDoubleIds = new List<int>(4);

   
                foreach (var room in hotelRooms)
                {
                    if (room.Value.RoomStatus == ("empty") && room.Value.RoomType.ToLower() == "single")
                    {
                        Console.WriteLine($"{room.Key}, {room.Value.RoomType} ");
                        roomSingleIds.Add(room.Key);
                    }
                }

                foreach (var room in hotelRooms)
                {

                    if (room.Value.RoomStatus == ("empty") && room.Value.RoomType.ToLower() == "double")
                    {
                        Console.WriteLine($"{room.Key}, {room.Value.RoomType} ");
                        roomDoubleIds.Add(room.Key);
                    }

                }

            //    //check if single rooms count is empty
            //    if (roomSingleIds.Count == 0)
            //    {
            //        //bool isSingleRoomsAvailable = false;
            //        bool isDoubleRoomsAvailable = false;
            //        do
            //        {
            //            Console.WriteLine($"There are no single rooms available please try again");
            //            roomType = GetRoomType();
            //            if (roomType == "double" && roomDoubleIds.Count > 0)
            //            {
            //                isDoubleRoomsAvailable = true;
            //            }
            //        } while (isDoubleRoomsAvailable == false);
            //    }




            ////check if single rooms count is empty
            //if (roomDoubleIds.Count == 0)
            //{
            //    bool isSingleRoomsAvailable = false;
            //    do
            //    {
            //        Console.WriteLine($"There are no double rooms available please try again");
            //        roomType = GetRoomType();
            //        if (roomType == "single" && roomSingleIds.Count > 0)
            //        {
            //            isSingleRoomsAvailable = true;
            //        }
                    
            //    } while (isSingleRoomsAvailable == false);
            //}
            return (roomSingleIds, roomDoubleIds, hotelRooms);



        }

        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> BookARoom(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms )
        {
            //Check which rooms are available

            //book a room
            int guestTotal = GetGuestTotal();

 

            string guestName = GetGuestName();

            string roomType = GetRoomType();

           var (singleRooms, doubleRooms, hotelRooms) isRoomAvailable = GetRoomsAvailable(roomType, hotelRooms);

           
            //this needs to be in its own method check if room available
            //get first free room that is of type requested
            
            List<int> singleRoomsCount = singleRooms.Count();

            bool roomNumberExists = false;
            int roomNumber = 0;
            do
            {
                Console.Write("Enter a room number:");
                string roomNumberText = Console.ReadLine();
                bool isValidRoomNumber = int.TryParse(roomNumberText, out roomNumber);
                roomNumberExists = hotelRooms.ContainsKey(roomNumber);

            } while (roomNumberExists == false);

            //Confirm Booking
            Console.Clear();
                hotelRooms[roomNumber] = (roomType, "booked", guestName, guestTotal);
                Console.WriteLine($"You have booked Room Number:{roomNumber}" +
                    $"\r\nRoom Type:{hotelRooms[roomNumber].RoomType}," +
                    $"\r\nRoom Status:{hotelRooms[roomNumber].RoomStatus}" +
                    $"\r\nRoom Guest Name:{hotelRooms[roomNumber].RoomGuestName}" +
                    $"\r\nRoom Guest Total:{hotelRooms[roomNumber].GuestTotal}");

                //show ALL room status
                //foreach (var room in hotelRooms)
                //{
                //    Console.WriteLine("*****************");
                //    Console.WriteLine($"Room Number:{room.Key}" +
                //    $"\r\nRoom Type:{room.Value.RoomType} " +
                //    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                //    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                //    $"\r\nRoom Guest Total:{room.Value.GuestTotal}");
                //    Console.WriteLine("*****************");
                //}
            
                return hotelRooms;
            
        }

        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> OccupyARoom(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //book a room
            Console.WriteLine("What is your surname:");
            string userSurname = Console.ReadLine();

            Console.WriteLine("How many in your party:");
            string partyNumberText = Console.ReadLine();

            //put in TCorey check
            bool isValidNumber = int.TryParse(partyNumberText, out int partyNumber);
            if (!isValidNumber)
            {
                Console.WriteLine("Please enter a valid number:");
                isValidNumber = int.TryParse(partyNumberText, out partyNumber);
            }

            //put in a check double or single
            Console.WriteLine("Would you like a double or single:");
            string roomType = Console.ReadLine();

            string roomStatus = "booked";
            //check room  available before booking
            foreach (var room in hotelRooms)
                if (room.Value.RoomStatus == ("empty"))
                {
                    Console.WriteLine($"Room Number:{room.Key} is available");
                }

            //allocate room as booked to guest name
            hotelRooms.Add(1, (roomType, "booked", userSurname, partyNumber));

            return hotelRooms;
        }

        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> EmptyARoom(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //book a room
            Console.WriteLine("What is your surname:");
            string userSurname = Console.ReadLine();

            Console.WriteLine("How many in your party:");
            string partyNumberText = Console.ReadLine();

            //put in TCorey check
            bool isValidNumber = int.TryParse(partyNumberText, out int partyNumber);
            if (!isValidNumber)
            {
                Console.WriteLine("Please enter a valid number:");
                isValidNumber = int.TryParse(partyNumberText, out partyNumber);
            }

            //put in a check double or single
            Console.WriteLine("Would you like a double or single:");
            string roomType = Console.ReadLine();

            string roomStatus = "booked";
            hotelRooms.Add(1, (roomType, "booked", userSurname, partyNumber));

            return hotelRooms;
        }


        //ADMIN FUNCTIONS
        public static void CheckGuestRoomName(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {

            Console.WriteLine("Enter guest name:");
            string guestName = Console.ReadLine();
            //show room status
            foreach (var room in hotelRooms)
            {
                if (room.Value.RoomGuestName == guestName.ToLower())
                {
                    Console.WriteLine("*************");
                    Console.WriteLine($"Room Number:{room.Key}" +
                    $"\r\nRoom Type:{room.Value.RoomType} " +
                    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                    $"\r\nRoom Party Total:{room.Value.GuestTotal}");
                    Console.WriteLine("*************");
                }
                else
                {
                    Console.WriteLine($"There is no guest called {guestName.ToLower()} in this room. ");
                }
            }
            

        }

        public static void CheckAllBookedRoomStatus(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //show room status
            foreach (var room in hotelRooms)
                if (room.Value.RoomStatus.ToLower() == "booked")
                {
                        Console.WriteLine("*************");
                        Console.WriteLine($"Room Number:{room.Key}" +
                        $"\r\nRoom Type:{room.Value.RoomType} " +
                        $"\r\nRoom Status:{room.Value.RoomStatus}" +
                        $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                        $"\r\nRoom Party Total:{room.Value.GuestTotal}");
                        Console.WriteLine("*************");
                }
        }

        public static void CheckAllOccupiedRoomStatus(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //show room status
            foreach (var room in hotelRooms)
                if (room.Value.RoomStatus.ToLower() == "full")
                {
                    Console.WriteLine("*************");
                    Console.WriteLine($"Room Number:{room.Key}" +
                    $"\r\nRoom Type:{room.Value.RoomType} " +
                    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                    $"\r\nRoom Party Total:{room.Value.GuestTotal}");
                    Console.WriteLine("*************");
                }
        }

        public static void CheckAllEmptyRoomStatus(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //show room status
            foreach (var room in hotelRooms)
                if (room.Value.RoomStatus.ToLower() == "empty")
                {
                    Console.WriteLine("*************");
                    Console.WriteLine($"Room Number:{room.Key}" +
                    $"\r\nRoom Type:{room.Value.RoomType} " +
                    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                    $"\r\nRoom Party Total:{room.Value.GuestTotal}");
                    Console.WriteLine("*************");
                }
        }



    }
}
