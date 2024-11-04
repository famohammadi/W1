using System;

class FibonacciCheck
{
    static void Main()
    {
        Console.Write("Enter a number (m): ");
        int m = int.Parse(Console.ReadLine());

        if (IsFibonacci(m))
        {
            Console.WriteLine($"{m} is in the Fibonacci series.");
        }
        else
        {
            Console.WriteLine($"{m} is not in the Fibonacci series.");
        }
    }

    static bool IsFibonacci(int m)
    {
        if (m < 0) return false;

        int a = 0;
        int b = 1;
        
        while (a <= m)
        {
            if (a == m)
            {
                return true;
            }
            int temp = a + b;
            a = b;
            b = temp;
        }

        return false;
    }
}