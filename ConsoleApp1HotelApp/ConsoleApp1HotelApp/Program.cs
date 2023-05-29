// HotelBooking application created for practice

//var dict = new Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)>();
//dict.Add(1, ("double", "booked", "jones", 2));
//foreach (var kvp2 in dict)
//    Console.WriteLine($"Room Number:{kvp2.Key}" +
//        $"\r\nRoom Type:{kvp2.Value.RoomType} " +
//        $"\r\nRoom Status:{kvp2.Value.RoomStatus}" +
//        $"\r\nRoom Guest Name:{kvp2.Value.RoomGuestName}" +
//        $"\r\nRoom Party Total:{kvp2.Value.RoomPartyTotal}");


//Welcome user and display menu

using ConsoleApp1HotelApp;

var hotelRooms = BookingLogic.InitialiseHotelRooms();

ConsoleMessages.WelcomeUser(hotelRooms);

//BookingLogic.AskToContinue();
//BookingLogic.BookARoom(hotelRooms);

//ConsoleMessages.ShowAllRoomStatus(hotelRooms);





