using System;

class Program
{
    // Exceeding requirement: a prompt asking the name of the user
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!");

        Console.Write("What is your name? ");
        string nameEntry = Console.ReadLine();

        if (string.IsNullOrEmpty(nameEntry))
        {
            Console.WriteLine("Sorry, you have to say your name to continue");
            return;
        }

        int option = 0;
        
        Journal journal = new Journal();

        while (option != 5)
        {
            Console.WriteLine($"{nameEntry}, please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userPrompt = Console.ReadLine();
            option = int.Parse(userPrompt);
            PromptGenerator promptGenerator = new PromptGenerator();

            if (option == 1) // Write
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write(prompt);
                string entryText = Console.ReadLine();
                
                Entry entry = new Entry();

                DateTime currentDate = DateTime.Now;
                string dateText = currentDate.ToShortDateString();

                entry._date = dateText;
                entry._promptText = prompt;
                entry._entryText = entryText;
                journal.AddEntry(entry);

                option = 0;
            } 
            else if (option == 2) // Display
            {
                journal.DisplayAll();
            } 
            else if (option == 3) // Load
            {
                journal = new Journal();
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (option == 4) // Save
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (option == 5) // Quit
            {
                Console.WriteLine("Thank you for using the program!");
            }
        }
    }
}