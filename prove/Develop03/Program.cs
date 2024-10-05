using System;

class Program
{
    // List<Scripture> scriptures = 

    //     new List<Scripture>
    // {    
    //     new Scripture(new Reference("Proverbs", 3, 5, 6) , "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
    //     new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
    // };

    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("\nThank you. Good bye!\n");
                break;
            }

            else
            {
                scripture.HideRandomWords(3); 
 
            }
        } 

    }
}
