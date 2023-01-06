using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        string letterGrade = "";

        if (gradeNumber >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeNumber >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeNumber >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeNumber >= 60)
        {
            letterGrade = "D";
        }
        else if (gradeNumber < 60)
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Do better next time. You failed.");
        }
    }
}