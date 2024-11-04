using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter the starting number (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime numbers between {m} and {n} are:");
        
        for (int number = m; number <= n; number++)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}