using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int listEnter = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (listEnter != 0)
        {
            Console.Write("Enter number: ");
            string userAnswer = Console.ReadLine();
            listEnter = int.Parse(userAnswer);

            if (listEnter!=0)
            {
                numbers.Add(listEnter);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float avg = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {avg}");

        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }
}