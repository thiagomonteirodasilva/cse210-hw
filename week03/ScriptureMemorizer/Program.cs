using System;

class Program
{
    // Exceeding requirement: new variable scriptureName on the Reference Class
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Old Testament", "Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(
            reference1, 
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        );
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string entry = Console.ReadLine();

            if (entry == "quit")
            {
                break;
            }
            Console.Clear();

            scripture.HideRandomWords(2);

            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}