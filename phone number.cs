using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true) // Infinite loop to repeatedly prompt until a valid input is provided
        {
            Console.WriteLine("Please enter your number:");

            string input = Console.ReadLine();

            // Check that input is exactly 10 characters long and contains only digits
            if (input.Length == 10 && input.All(char.IsDigit))
            {
                // Check that input starts with '0'
                if (input.StartsWith('0'))
                {
                    // Check that input contains at least two different digits
                    if (input.Distinct().Count() >= 2)
                    {
                        Console.WriteLine("The number is valid.");
                        break; // Exit the loop if the number is valid
                    }
                    else
                    {
                        Console.WriteLine("The number must contain at least two different digits.");
                    }
                }
                else
                {
                    Console.WriteLine("The number must start with a zero.");
                }
            }
            else
            {
                Console.WriteLine("The input must be exactly 10 digits long and contain only numbers.");
            }
        }
    }
}