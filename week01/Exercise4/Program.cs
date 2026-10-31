using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int max = -999999999;
        int min = 999999999;
        int entry = -1;
        List<int> numbers = new List<int>();

        while (entry != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            entry = int.Parse(Console.ReadLine());

            if (entry != 0)
            {
                numbers.Add(entry);
            }
        }

        foreach (int number in numbers)
        {
            sum = sum + number;

            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        float avg = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");
    }
}