using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int squaredNumber = SquaredNumber(userNumber);
            DisplayResult(userName, squaredNumber);
        }
        Main();
       
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number:");
            string number1 = Console.ReadLine();
            int number = int.Parse(number1);
            return number;
        }

        static int SquaredNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        } 
    }
}