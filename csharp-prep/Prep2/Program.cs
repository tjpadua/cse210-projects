using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine();

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Great job. You passed the course!");
        }

        else
        {
            Console.WriteLine("Thank you for doing your best, but your best wasn't good enough.");
            Console.WriteLine("Good luck next semester!");
        }

    }
}