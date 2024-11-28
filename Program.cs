using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("Enter your name: ");
            string? inputName = Console.ReadLine();
            string userName = inputName ?? "Unknown";

            Console.Write("Enter your age: ");
            string? inputAge = Console.ReadLine();
            int userAge = string.IsNullOrEmpty(inputAge) ? 0 : int.Parse(inputAge);

            GreetUser(userName);
            Console.WriteLine($"You are {userAge} years old.");

            if (userAge >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are a minor.");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }
        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}