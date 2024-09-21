using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // do-while loop
        int usernumber = -1;
        while (usernumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userresponse = Console.ReadLine();
            usernumber = int.Parse(userresponse);

            // if it is not 0, add the numbers of user responses to the list
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }

        // Part 1 - Compute the SUM
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Part 2 - Compute the AVERAGE
        // use float to get the decimal value
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3 - Find the LARGEST NUMBER (maximum)
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

    }
}