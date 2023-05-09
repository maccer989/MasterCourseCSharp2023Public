//Conditionals Practice4
//Using a switch case create calculator covering functions +, - , x, /
//Ask the user for 2 integers test each is a valid number it can be a double
//Ask the user for a choice using a menu 1. +, 2. -, 3. x, 4. /
//or enetr in the text add, subtract, multiply, divide
//Print answer to Console

bool isNumber = false;

Console.Write("Please enter an integer1:");
string userIntText1 = Console.ReadLine();
bool isValidInt1 = double.TryParse(userIntText1, out double userInt1);

Console.Write("Please enter an integer2:");
string userIntText2 = Console.ReadLine();
bool isValidInt2 = double.TryParse(userIntText2, out double userInt2);


Console.Write("Please enter calc function from ADD, SUBTRACT, MULTIPLY or DIVIDE:");
string calcTextIn = Console.ReadLine();

if ((isValidInt1) && (isValidInt2))
{
    switch (calcTextIn.ToLower())
    {

        case "add":

            Console.Write($"Result of addition:{userInt1 + userInt2}");
            break;

        case "subtract":
            Console.Write($"Result of subtraction:{userInt1 - userInt2}");
            break;

        case "divide":
            Console.Write($"Result of division:{userInt1 / userInt2}");
            break;

        case "multiply":
            Console.Write($"Result of multiplication:{userInt1 * userInt2}");
            break;

        default:
            Console.WriteLine("You have not entered a valid calculation operator");
            break;
    }
}

else { Console.WriteLine("You did not enter a valid integer"); }
