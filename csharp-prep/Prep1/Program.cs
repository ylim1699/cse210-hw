using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.WriteLine("What is your first name?");
        string FirstName = Console.ReadLine();
        
        Console.WriteLine("What is your last name?");
        string LastName = Console.ReadLine();

        Console.WriteLine($"your name is {LastName}, {FirstName} {LastName}");

    }
}