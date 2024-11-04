using System;

class DecisionTree
{
    static void Main()
    {
        // Start the decision tree
        Decide();
    }

    static void Decide()
    {
        // First question
        Console.WriteLine("Are you a fan of movies and series? (yes/no)");
        string input = Console.ReadLine().ToLower();

        if (input == "yes")
        {
            // Movies hobby branch
            Console.WriteLine("Is watching movies and series one of your main hobbies? (yes/no)");
            input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                Console.WriteLine("Do you like science fiction movie genre? (yes/no)");
                input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    Console.WriteLine("Have you seen the movie Interstellar? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You have seen Interstellar.");
                    }
                    else
                    {
                        Console.WriteLine("You have not seen Interstellar.");
                    }
                }
                else
                {
                    Console.WriteLine("Do you prefer the rom-com genre? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You prefer the rom-com genre.");
                    }
                    else
                    {
                        Console.WriteLine("You do not prefer the rom-com genre.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Do you prefer going camping with your friends instead of staying at home and watching movies? (yes/no)");
                input = Console.ReadLine().ToLower();

                if (input == "no")
                {
                    Console.WriteLine("Have you ever gone camping? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You have gone camping.");
                    }
                    else
                    {
                        Console.WriteLine("You have never gone camping.");
                    }
                }
                else
                {
                    Console.WriteLine("You prefer going camping.");
                }
            }
        }
        else
        {
            // Book fan branch
            Console.WriteLine("Are you a book fan? (yes/no)");
            input = Console.ReadLine().ToLower();

            if (input == "yes")
            {
                Console.WriteLine("Do you prefer novels to psychological books? (yes/no)");
                input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    Console.WriteLine("Have you read Harry Potter? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You have read Harry Potter.");
                    }
                    else
                    {
                        Console.WriteLine("You have not read Harry Potter.");
                    }
                }
                else
                {
                    Console.WriteLine("Have you read many psychology books? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You have read many psychology books.");
                    }
                    else
                    {
                        Console.WriteLine("You have not read many psychology books.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Do you listen to music a lot? (yes/no)");
                input = Console.ReadLine().ToLower();

                if (input == "yes")
                {
                    Console.WriteLine("Do you like pop music? (yes/no)");
                    input = Console.ReadLine().ToLower();

                    if (input == "yes")
                    {
                        Console.WriteLine("You like pop music.");
                    }
                    else
                    {
                        Console.WriteLine("You do not like pop music.");
                    }
                }
                else
                {
                    Console.WriteLine("You do not listen to music a lot.");
                }
            }
        }
    }
}
