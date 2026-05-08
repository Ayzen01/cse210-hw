using System;

namespace MyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to the number game!.");
            string playAgain = "yes"; 
            while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y")
            
            {
                Random rand = new Random();
                int secretNumber = rand.Next(1, 101);
                int attempts = 0;
                bool isCorrect = false;

                Console.WriteLine("I have a secret number between 1 and 100.");
                while (!isCorrect)
                {
                   Console.Write("Enter your guess:");
                   string input = Console.ReadLine();

                   if (!int.TryParse(input, out int guess))
                   {
                        Console.WriteLine("Please enter a valid number.");
                        continue; // Skip to the next iteration without counting as an attempt
                    }

                    attempts++;

                    if (guess == secretNumber)
                    {
                        Console.WriteLine($"Congratulations! You've guessed the number in {attempts} attempts.");
                        isCorrect = true;
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                }

                Console.Write("Do you want to play again? (yes/no): ");
                playAgain = Console.ReadLine();
            }
    

         
                       
            Console.WriteLine("Thanks for playing! Goodbye.");

         
       }
    }
}