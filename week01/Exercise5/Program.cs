using System;

class Program
{
    static void Main(string[] args)
    {
        static void message()
        {
            Console.WriteLine("Hello world!");
        }

        message();

        static string hello()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            return name;
        }

        string name = hello();

        static int number()
        {
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        int userNumber = number();

        static int squared(int userNumber)
        {
            int squared = userNumber * userNumber;

            return squared;
        }

        int userSquared = squared( userNumber);

        static void statement(string name, int userSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {userSquared}");
        }

        statement(name, userSquared);
    }
}