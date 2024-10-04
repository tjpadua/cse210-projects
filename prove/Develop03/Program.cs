using System;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("Proverbs 3:5-6 Trust in the LORD with all thine heart; and lean not unto thine own understanding. 
       //6 In all thy ways acknowledge him, and he shall direct thy paths.");

        // Journal journal = new Journal();
        // Scripture scripture = new Scripture();       
        // Word word = new Word();
        // Reference reference = new Reference();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Proverbs 3:5-6 Trust in the Lrd with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        
            switch (Console.ReadLine())
            {
                
                
                case "quit":
                    running = false;
                    Console.WriteLine("Thank you. Bye!");
                    break;
                
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        } 


    }
}