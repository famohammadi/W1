using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a word:");

        while (true)
        {
            string input = string.Empty;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                // Exit the loop if Enter is pressed
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                // Allow only alphabetic characters (and optionally spaces)
                if (char.IsLetter(keyInfo.KeyChar) || keyInfo.KeyChar == ' ')
                {
                    input += keyInfo.KeyChar;
                    Console.Write(keyInfo.KeyChar);
                }
                else
                {
                    Console.Beep(); // Optional sound for invalid input
                }
            }

            if (IsWord(input))
            {
                Console.WriteLine("You entered a valid word: " + input);
                break; // Exit once a valid word is entered
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a word:");
            }
        }
    }

    static bool IsWord(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c) && c != ' ')
            {
                return false;
            }
        }
        return !string.IsNullOrWhiteSpace(input); // Ensure there's at least one character
    }
}