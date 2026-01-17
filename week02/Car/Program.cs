using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World Car");
    Car car = new Car();
    car._model = "Focus";
    car._brand = "Ford";
    car._year = 2019;

    Console.WriteLine($"Brand: {car._model}, model: {car._brand}, year: {car._year}");
  }
}