using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");

        while (true)
        {
            string input = string.Empty;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                // Break the loop if Enter is pressed
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (char.IsDigit(keyInfo.KeyChar) || (keyInfo.KeyChar == '.' && !input.Contains(".")))
                {
                    input += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar); // Display the key
                }
                else
                {
                    Console.Beep(); // Optional: Give feedback for invalid key
                }
            }

            // Validate if the final input is numeric
            if (IsNumeric(input))
            {
                Console.WriteLine("You entered a valid number: " + input);
                break; // Exit once a valid number is entered
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
                // Clear the input for the next attempt
            }
        }
    }

    static bool IsNumeric(string input)
    {
        // Try to parse the input string to a double.
        return double.TryParse(input, out _);
    }
}