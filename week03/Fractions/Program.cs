using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.WriteLine("Enter a value for the top of the fraction: ");
        int top = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value for the bottom of the fraction: ");
        int bottom = int.Parse(Console.ReadLine());

        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(top);
        Fraction fraction3 = new Fraction(top, bottom);

        Console.WriteLine(fraction.GetToString());
        Console.WriteLine(fraction.GetToDecimal());
        Console.WriteLine(fraction2.GetToString());
        Console.WriteLine(fraction2.GetToDecimal());
        Console.WriteLine(fraction3.GetToString());
        Console.WriteLine(fraction3.GetToDecimal());
    }
}