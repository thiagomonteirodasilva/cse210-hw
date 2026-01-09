using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numberList = new List<int>();
        int number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();
            number = int.Parse(numberInput);

            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        int sum = 0;

        foreach (int num in numberList)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        double average = numberList.Average();

        Console.WriteLine($"The average is: {average}");

        int highestNumber = -1;
        foreach (int num in numberList)
        {
            if (num > highestNumber)
            {
                highestNumber = num;
            }
        }
        Console.WriteLine($"The highest number is: {highestNumber}");
    }
}