using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a grade percentage: ");
        int percent = int.Parse(Console.ReadLine());

        if (percent >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("You have an B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("You have an C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("You have an D");
        }
        else if (percent < 60)
        {
            Console.WriteLine("You have an F");
        }
        else
        {
            Console.WriteLine("You entered an invalid percentage");
        }
    }
}