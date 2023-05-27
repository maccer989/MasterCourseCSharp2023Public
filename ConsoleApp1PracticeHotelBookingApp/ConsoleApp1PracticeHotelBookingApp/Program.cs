// HotelBookingApp
using System.Collections.Generic;


//single array
using System;

int[] guestArray = new int[] { 1, 2, 3 };

Console.WriteLine(guestArray[0]);
Console.WriteLine(guestArray[1]);
Console.WriteLine(guestArray[2]);


//2d array
string[,] guestArray2d = new string[3, 2]
{
    {"one", "two"},
    {"three", "four"},
    {"five", "six"},

};

Console.WriteLine(guestArray2d[0,0]);//returns one
Console.WriteLine(guestArray2d[1,1]);//returns four
Console.WriteLine(guestArray2d[2,1]);//six
Console.ReadLine();


string[,] hotelRooms = new string[3, 5]
{
    {"one", "single", "allocated", "Smith", "one"},
    {"two", "double", "occupied", "Jones", "two"},
    {"three", "single", "empty", "", ""},

};

Console.WriteLine(hotelRooms[0, 4]);//returns one
Console.WriteLine(hotelRooms[1, 1]);//returns double
Console.WriteLine(hotelRooms[2, 2]);//returns empty
Console.ReadLine();

Dictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");

foreach (var kvp in numberNames)
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


//var dict = new Dictionary<int, Tuple<string, string, bool, int>>();
//var dict = new Dictionary<(int PersonId, int LocationId, int SubjectId), string>();
//dict.Add((3, 6, 9), "ABC");
//dict.Add((PersonId: 4, LocationId: 9, SubjectId: 10), "XYZ");
//var personIds = dict.Keys.Select(k => k.PersonId).Distinct().ToList();

var dict = new Dictionary<int, (string RoomType, string RoomStatus, string RoomGuestName, int RoomPartyTotal)>();
dict.Add(1, ("double", "booked", "jones", 2));
foreach (var kvp2 in dict)
    Console.WriteLine($"Room Number:{kvp2.Key}" +
        $"\r\nRoom Type:{kvp2.Value.RoomType} " +
        $"\r\nRoom Status:{kvp2.Value.RoomStatus}" +
        $"\r\nRoom Guest Name:{kvp2.Value.RoomGuestName}" +
        $"\r\nRoom Party Total:{kvp2.Value.RoomPartyTotal}");