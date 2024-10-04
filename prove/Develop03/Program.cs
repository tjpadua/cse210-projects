using System;

class Program
{
    List<Scripture> scriptures = 

        new List<Scripture>
    {    
        new Scripture(new Reference("Proverbs", 3, 5, 6) , "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
    };


    static void Main(string[] args)
    {
        //Scripture scripture = new Scripture();       
        //Word word = new Word();
        //Reference reference = new Reference();
        bool running = true;

        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6) , "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        Console.Write(scripture.GetDisplayText());

        while (running)
        {
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");


            switch (Console.ReadLine())
            {
                
                case "quit":
                    running = false;
                    Console.WriteLine("Thank you. Good bye!");
                    break;
                
                default:
                    scripture.HideRandomWords(3);
                    Console.Write(scripture.GetDisplayText());
                    
                    if (scripture.IsCompletelyHidden())
                    {
                        running = false;
                    }

                    break;
            }
        } 


    }
}