using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
            
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 101);
        int inputNumber = -1;
        int guesses = 0;

        while (inputNumber != randomNumber) {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);
            guesses++;

            if (inputNumber < randomNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (inputNumber > randomNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        Console.WriteLine($"It took {guesses} guess(es)");
    }
}