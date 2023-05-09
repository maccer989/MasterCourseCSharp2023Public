//Positive or Negative? 
//When you’re multiplying two numbers together, if the two numbers have the same sign (both positive
//or both negative) the result is positive. If they have different signs, the result is negative.
//Write a program that asks the user for two numbers and then, using the rule above, prints out
//whether the result should be positive or negative. Also if the number is 0 that the ouptut is. 
//Test both integers are valid numbers clsoe the program if either are detected as invalid


bool isNumber = false;

Console.Write("Please enter an integer1:");
string userIntText1 = Console.ReadLine();
bool isValidInt1 = int.TryParse(userIntText1, out int userInt1);

Console.Write("Please enter an integer2:");
string userIntText2 = Console.ReadLine();
bool isValidInt2 = int.TryParse(userIntText2, out int userInt2);

if ((isValidInt1 ) && (isValidInt2))
{

    //negative number
    if ((userInt1 < 0 && userInt2 < 0) || (userInt1 > 0 && userInt2 > 0))
    {
        Console.WriteLine("Multiplying these two numbers will be positive");
        int result = userInt1 * userInt2;
        Console.WriteLine($"The result of multiplying integer 1 and integer2 is:{result}");
    }

    //negative number
    else if ((userInt1 < 0 && userInt2 > 0) || (userInt1 > 0 && userInt2 < 0))
    {
        Console.WriteLine("Multiplying these two numbers will be negative");
        int result = userInt1 * userInt2;
        Console.WriteLine($"The result of multiplying integer 1 and integer2 is:{result}");
    }

    //negative number
    else if (((userInt1 == 0 && (userInt2 > 0 || userInt2 < 0)) || ((userInt1 > 0 || userInt1 < 0) && userInt2 == 0)))
    {
        Console.WriteLine("Multiplying these two numbers will be zero");
        int result = userInt1 * userInt2;
        Console.WriteLine($"The result of multiplying integer 1 and integer2 is:{result}");
    }

}

else { Console.WriteLine("You have entered a an ivaild integer progream will end"); }

