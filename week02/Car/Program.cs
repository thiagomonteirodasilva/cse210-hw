using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello World Car");
    Car car = new Car();
    car.model = "Focus";
    car.brand = "Ford";
    car.year = 2019;

    Console.WriteLine($"Brand: {car.brand}, model: {car.model}, year: {car.year}");
  }
}