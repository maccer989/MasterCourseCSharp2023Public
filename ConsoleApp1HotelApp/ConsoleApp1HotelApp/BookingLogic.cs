using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1HotelApp
{

    public static class BookingLogic
    {
        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)> InitialiseHotelRooms()
        {
            var hotelRooms = new Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)>();
            return hotelRooms;
        }

        public static int GetPartySize()
        {

            bool isValidNumber;
            int output;
            do
            {
                Console.WriteLine("How many people in your party");
                string partySizeText = Console.ReadLine();
                isValidNumber = int.TryParse(partySizeText, out output);

            } while (isValidNumber == false);


            return output;
        }

        public static bool AskToContinue()
        {
            Console.Write("Are there more guest coming (yes/no): ");
            string continueLooping = Console.ReadLine();

            bool output = (continueLooping.ToLower() == "yes"); //read like if equates to true or false
            return output;
        }

        public static Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)> BookARoom(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)> BookedHotelRooms )
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
            BookedHotelRooms.Add(1, (roomType, "booked", userSurname, partyNumber));

            return BookedHotelRooms;
        }


        
    }
}
