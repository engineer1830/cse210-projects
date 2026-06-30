using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Enter the magic number (between 1 & 100): ");

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        // string input = Console.ReadLine();
        // int magic = int.Parse(input);
        int guess = 0;
        string answer;
        int count = 1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            answer = Console.ReadLine();
            guess = int.Parse(answer);

            if (guess == magic)
            {
                Console.WriteLine("You guessed the magic number!");
                Console.WriteLine($"You guessed the magic number in {count} guesses.");
            }

            else if (guess > magic)
            {
                count++;
                Console.WriteLine("Lower");
            }

            else
            {
                count++;
                Console.WriteLine("Higher");
            }
        }


        
    }
}