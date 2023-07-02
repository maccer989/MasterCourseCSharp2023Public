// created from ChaptGPT out put

using DataAccess;
using DataAccess.Models;


string connectionString = "Data Source=DESKTOP-CG6J7DD\\SQLEXPRESS;Initial Catalog=UserManagementSystem;Integrated Security=True;Connect Timeout=60;Encrypt=False"; // Replace with your SQL Server connection string

UserManager userManager = new UserManager(connectionString);

// Create a new user
int newUserID = userManager.CreateUser("John", "Doe", "johndoe@example.com");
Console.WriteLine("New user ID: " + newUserID);

// Update the user's information
bool isUpdated = userManager.UpdateUser(newUserID, "John", "Smith", "johnsmith@example.com");
Console.WriteLine("User updated: " + isUpdated);

// Retrieve the user's information
User user = userManager.GetUserByID(newUserID);
if (user != null)
{
    Console.WriteLine("User ID: " + user.ID);
    Console.WriteLine("First Name: " + user.FirstName);
    Console.WriteLine("Last Name: " + user.LastName);
    Console.WriteLine("Email: " + user.Email);
}
else
{
    Console.WriteLine("User not found.");
}


