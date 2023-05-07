//Common Variables Practice2


//Create a console application that captures a user's age then identify
//how old they will be in 25 years,
//as well as how old they were 25 years ago. Print that information to the Console

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();
bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"The age was {age} and is valid.");
Console.WriteLine($"You will be {age + 25} in 25 years.");
Console.WriteLine($"You were {age -25}, 25 years ago.");
