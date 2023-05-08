// Conditionals Practice1

//Create a console application that asks the suer for theri name .Welcome yourself (insert name e.g. david) as Professor
//anyone else is student. Make sure that capitalised version of your name 'DAVID' is also welcomed as Professor

Console.Write("Please enter your name:");
string? firstName = Console.ReadLine();

if(firstName.ToLower() == "david")
{
    Console.WriteLine("Welcome Professor");
}

else
{
    Console.WriteLine("Welcome Student");
}


Console.Write("End of program");
