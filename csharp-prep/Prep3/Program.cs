using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int userGuess;

        do
        {
            Console.Write("What is your guess? ");
            string userGuessString = Console.ReadLine();
            userGuess = int.Parse(userGuessString);

            if (userGuess != magicNumber)
            {
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (userGuess != magicNumber);
    }
}


