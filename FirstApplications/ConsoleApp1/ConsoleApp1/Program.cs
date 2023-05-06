namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my App");
            Console.Write("Enter your name:");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Hello {userInput}");
        }
    }
}