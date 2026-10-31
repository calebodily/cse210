using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random Generator = new Random();
        int number = Generator.Next(1, 100);

        while (guess != number)
        {
            Console.WriteLine("What is the magic number?");
            guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == number)
            {
                Console.WriteLine("You Guessed the number!");
            }
            else
            {
                Console.WriteLine("You entered something the program could not understand");
            }
        }
    }
}