using System;

namespace Project_3_ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName = "John",
                lastName = "Doe";

            Console.WriteLine($"Name: {firstName} {lastName}");

            Console.WriteLine("Please enter a new first name: ");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter a new last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"New name: {firstName} {lastName}");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
