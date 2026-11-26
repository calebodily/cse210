using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine("");

        MathAssignment mathAssignment = new MathAssignment("Tom Bakery", "Addition", "29", "4");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine("");

        WritingAssignment writingAssignment = new WritingAssignment("Jeffery Thompson", "English", "How to make a dessert");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}