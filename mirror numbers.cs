using System;

class MirrorNumbers
{
    static void Main()
    {
        Console.Write("Enter the starting number (m): ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Mirror numbers between {m} and {n} are:");

        for (int number = m; number <= n; number++)
        {
            if (IsMirror(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsMirror(int number)
    {
        string numStr = number.ToString();
        char[] numArray = numStr.ToCharArray();
        Array.Reverse(numArray);
        string reversedStr = new string(numArray);

        return numStr == reversedStr;
    }
}