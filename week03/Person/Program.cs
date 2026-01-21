using System;

class Program
{
    static void Main(string[] args)
    {
      Person person = new Person();
      string fullname = person.FullName("Thiago", "Silva");
      Console.WriteLine($"My name is {fullname}");
    }
}
