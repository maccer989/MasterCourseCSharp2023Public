using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1HotelApp
{
    public static class ConsoleMessages
    {
        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome user to Hotel Booking Application");
            Console.WriteLine("========================================");
            Console.WriteLine("Main Menu, please choose a number:");
            Console.WriteLine("1. Book a room.");
            Console.WriteLine("2. Check in.");
            Console.WriteLine("3. Check out.");
            Console.WriteLine("4. Admin.");
            
            MainMenuChoice(GetMainMenuChoice());

        }
        public static int GetMainMenuChoice()
        {
            bool isValidNumber;
            int output;
            do
            {
                Console.Write("Please choose a number from the menu:");
                string menuChoiceText = Console.ReadLine();
                isValidNumber = int.TryParse(menuChoiceText, out output);

            } while ((isValidNumber == false) || (output > 4) || (output < 1));

            return output;
        }       

        public static int MainMenuChoice(int menuChoice)
        {
            int output = 0;

            // Menu selection
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You have selected 1 - Book a room");
                    output = 1;
                    break;
                case 2:
                    Console.WriteLine("You have selected 2 - Check in");
                    output = 2;
                    break;
                case 3:
                    Console.WriteLine("You have selected 3 - Check out");
                    output = 3;
                    break;
                case 4:
                    Console.WriteLine("You have selected 4 - Admin");
                    output = 4;
                    break;
                default:
                    // code block
                    break;
            }
            return output;

        }

        public static void ShowRoomStatus(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)> hotelRooms)
        {
            //show room status
            foreach (var room in hotelRooms)
                Console.WriteLine($"Room Number:{room.Key}" +
                    $"\r\nRoom Type:{room.Value.RoomType} " +
                    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                    $"\r\nRoom Party Total:{room.Value.RoomPartyTotal}");
        }
    }
}
