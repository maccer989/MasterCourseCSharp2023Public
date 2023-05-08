//Conditionals Practice2
//Write a program that finds the biggest of three integers, using nested
//if statements. First check if the integer is valid and ask the user to enter another value.
//if the user enters in a second invalid integer end the program.


int userInt1 = 0;
int userInt2 = 0;
int userInt3 = 0;

string userIntText1 = "";
string userIntText2 = "";
string userIntText3 = "";

bool isValidInt1 = false;
bool isValidInt2 = false;
bool isValidInt3 = false;

int storedInt1 = 0;
int storedInt2 = 0;
int storedInt3 = 0;
int biggestInt = 0;



Console.Write("Please enter an integer1:");
userIntText1 = Console.ReadLine();
isValidInt1 = int.TryParse(userIntText1, out  userInt1);

    if (isValidInt1)
    {
        Console.WriteLine("You have entered a valid integer1");
        storedInt1 = userInt1;
        Console.Write("Please enter an integer2:");
        userIntText2 = Console.ReadLine();
        isValidInt2 = int.TryParse(userIntText2, out userInt2);
        if (isValidInt2)
        {
            Console.WriteLine("You have entered a valid integer2");
            storedInt2 = userInt2;
        }
        else
        {
            Console.WriteLine("You have entered an invalid integer2");
            Console.WriteLine("Please try again or the progam will end");
            Console.Write("Please enter an integer2:");

            userIntText2 = Console.ReadLine();
            isValidInt2 = int.TryParse(userIntText2, out userInt2);
            if (isValidInt2)
            {
             Console.WriteLine("You have entered a valid integer2");
                storedInt2 = userInt2;
            }
            else { return; }
        }

        Console.Write("Please enter an integer3:");
        userIntText3 = Console.ReadLine();
        isValidInt3 = int.TryParse(userIntText3, out userInt3);
        if (isValidInt3)
        {
            Console.WriteLine("You have entered a valid integer3");
            storedInt3 = userInt3;
        }

        else
        {
            Console.WriteLine("You have entered an invalid integer3");
            Console.WriteLine("Please try again or the progam will end");
            Console.Write("Please enter an integer3:");

            userIntText3 = Console.ReadLine();
            isValidInt3 = int.TryParse(userIntText3, out userInt3);
            if (isValidInt3)
            {
                Console.WriteLine("You have entered a valid integer3");
                storedInt3 = userInt3;
            }
            else { return; }
        }
    }
    else
    {
        Console.WriteLine("You have entered an invalid integer1");
        Console.WriteLine("Please try again or the progam will end");
        Console.Write("Please enter an integer1:");

        userIntText1 = Console.ReadLine();
        isValidInt1 = int.TryParse(userIntText1, out  userInt1);
        if (isValidInt1)
        {
            Console.WriteLine("You have entered a valid integer1");
            storedInt1 = userInt1;
        }
        else { return; }

        Console.Write("Please enter an integer2:");
        userIntText2 = Console.ReadLine();
        isValidInt2 = int.TryParse(userIntText2, out  userInt2);
        if (isValidInt2)
        {
            Console.WriteLine("You have entered a valid integer2");
            storedInt2 = userInt2;
        }
        else
        {
            Console.WriteLine("You have entered an invalid integer2");
            Console.WriteLine("Please try again or the progam will end");
            Console.Write("Please enter an integer2:");

            userIntText2 = Console.ReadLine();
            isValidInt2 = int.TryParse(userIntText2, out userInt2);
            if (isValidInt2)
            {
                Console.WriteLine("You have entered a valid integer2");
                storedInt2 = userInt2;
            }
            else { return; }
        }

        Console.Write("Please enter an integer3:");
        userIntText3 = Console.ReadLine();
        isValidInt3 = int.TryParse(userIntText3, out  userInt3);
        if (isValidInt3)
        {
            Console.WriteLine("You have entered a valid integer3");
            storedInt3 = userInt3;
        }

        else
        {
            Console.WriteLine("You have entered an invalid integer3");
            Console.WriteLine("Please try again or the progam will end");
            Console.Write("Please enter an integer3:");

            userIntText3 = Console.ReadLine();
            isValidInt3 = int.TryParse(userIntText3, out userInt3);
            if (isValidInt3)
            {
                Console.WriteLine("You have entered a valid integer3");
                storedInt3 = userInt3;
            }
            else { return; }
        }
    }

Console.WriteLine($"You have entered three valid integers. integer1:{userInt1}, integer2:{userInt2}, integer3:{userInt3}");


if (userInt1 > userInt2)
{
    biggestInt = userInt1;
}
else
{
    biggestInt = userInt2;
}

if (userInt2 < userInt3)
{
    biggestInt = userInt3;
}

Console.WriteLine($"The biggest of the three integers is {biggestInt}");







    
