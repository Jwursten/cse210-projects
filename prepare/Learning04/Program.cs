using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Steve Irwin", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Billy Joel", "PreCal", "4.2", "12 - 42");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomework());

        EnglishAssignments a3 = new EnglishAssignments("Anakin Skywalker", "Galactic History", "Causes of the Clone Wars");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetSummary());
    }
}