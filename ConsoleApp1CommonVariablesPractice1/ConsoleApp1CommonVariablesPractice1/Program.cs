//Common variables practice1

string firstName = string.Empty;
string lastName = string.Empty;
bool isAlive = false;
string telNumber = string.Empty;

Console.Write("Enter your first name:");
firstName = Console.ReadLine();
Console.Write("Enter your last name:");
lastName = Console.ReadLine();
Console.Write("Are you alive enter yes/no:");
isAlive= Console.ReadLine() == "yes";
Console.Write("Enter your telephone number:");
telNumber = Console.ReadLine();

Console.WriteLine($"Hello {firstName} {lastName}, you are alive:{isAlive}, your telephone number is:{telNumber}");

