using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1HotelApp
{
    public static class ConsoleMessages
    {
        public static void WelcomeUser(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            Console.WriteLine("\r\nWelcome user to Hotel Booking Application");
            Console.WriteLine("========================================");
            Console.WriteLine("Main Menu, please choose a number:");
            Console.WriteLine("1. Book a room.");
            Console.WriteLine("2. Check in.");
            Console.WriteLine("3. Check out.");
            Console.WriteLine("4. Admin.");
            Console.WriteLine("5. Exit.");


            MainMenuChoice(GetMainMenuChoice(), hotelRooms);

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

            } while ((isValidNumber == false) || (output > 5) || (output < 1));

            return output;
        }       

        public static int MainMenuChoice(int menuChoice, Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            int output = 0;

            // Menu selection
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You have selected 1 - Book a room");
                    BookingLogic.BookARoom(hotelRooms);
                    WelcomeUser(hotelRooms);
                    break;
                case 2:
                    Console.WriteLine("You have selected 2 - Check in");
                    BookingLogic.OccupyARoom(hotelRooms);
                    WelcomeUser(hotelRooms);
                    break;
                case 3:
                    Console.WriteLine("You have selected 3 - Check out");
                    BookingLogic.EmptyARoom(hotelRooms);
                    WelcomeUser(hotelRooms);
                    break;
                case 4:
                    Console.WriteLine("You have selected 4 - Admin");
                    AdminUser(hotelRooms);
                    WelcomeUser(hotelRooms);
                    break;
                default:
                    Console.WriteLine("You have selected 5 - Exit");
                    break;
            }
            return output;

        }

        public static void ShowAllRoomStatus(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            //show room status
            foreach (var room in hotelRooms)
                Console.WriteLine($"Room Number:{room.Key}" +
                    $"\r\nRoom Type:{room.Value.RoomType} " +
                    $"\r\nRoom Status:{room.Value.RoomStatus}" +
                    $"\r\nRoom Guest Name:{room.Value.RoomGuestName}" +
                    $"\r\nRoom Party Total:{room.Value.GuestTotal}");
        }

        public static void AdminUser(Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            Console.WriteLine("\r\nWelcome Admin to Hotel Booking Application");
            Console.WriteLine("========================================");
            Console.WriteLine("Admin Menu, please choose a number:");
            Console.WriteLine("1. Check how many guests.");
            Console.WriteLine("2. Return booked rooms.");
            Console.WriteLine("3. Return empty rooms.");
            Console.WriteLine("4. Return occupied rooms.");
            Console.WriteLine("5. Return to Main Menu.");
            AdminMenuChoice(GetMainMenuChoice(),  hotelRooms);

        }

        public static int AdminMenuChoice(int menuChoice, Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int GuestTotal)> hotelRooms)
        {
            int output = 0;

            // Menu selection
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("You have selected 1 - return guest and room name");
                    BookingLogic.CheckGuestRoomName(hotelRooms);
                    AdminUser(hotelRooms);
                    break;
                case 2:
                    Console.WriteLine("You have selected 2 - return total booked rooms");
                    BookingLogic.CheckAllBookedRoomStatus(hotelRooms);
                    AdminUser(hotelRooms);
                    break;
                case 3:
                    Console.WriteLine("You have selected 3 - return total empty rooms");
                    BookingLogic.CheckAllEmptyRoomStatus(hotelRooms);
                    AdminUser(hotelRooms);
                    break;
                case 4:
                    Console.WriteLine("You have selected 4 - return total occupied rooms");
                    BookingLogic.CheckAllOccupiedRoomStatus(hotelRooms);
                    AdminUser(hotelRooms);
                    break;
                default:
                    Console.WriteLine("You have selected 5 - return to Main Menu");
                    WelcomeUser(hotelRooms);
                    break;
            }
            return output;

        }
    }
}
