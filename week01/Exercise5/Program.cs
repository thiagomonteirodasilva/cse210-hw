using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squareResult = SquareNumber(favoriteNumber); 
        
        DisplayResult(name, squareResult);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}