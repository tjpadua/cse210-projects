using System;

class Program
{
    static void Main(string[] args)
    {

        // Part 1 & 2 - user specified the magic number
        // Console.Write("What is the magic number? ");
        // int magicnumber = int.Parse(Console.ReadLine());

        // Part 3 - use a random number
       Random randomnumber = new Random();
       int magicnumber = randomnumber.Next(1,101);

        int guess = -1;

         // do-while loop
        while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Good job! You guessed it.");
            }
        }
    }
}