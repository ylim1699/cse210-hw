using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number (0 to finish):");

            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            if (userNumber != 0);
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average number is: {average}");

        int largest = numbers[0];

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine($"The largest number is {largest}");
    }
}