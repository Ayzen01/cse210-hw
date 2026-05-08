using System;

namespace MyNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Welcome to the number game! I have a secret number between 1 and 100.");
            Console.WriteLine("Enter the secret number: ");
            int secretNumber = int.Parse(Console.ReadLine());

             Console.WriteLine("Enter your guess: ");
             int guess = int.Parse(Console.ReadLine());

            string playAgain = "yes";

  //Main loop that allows the user to play the game multiple times            
            while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y")


            {
                Random rand = new Random();
                int secretNumber = rand.Next(1, 101);

                int guess;
                int attempts = 0;
                bool isCorrect = false;

                





                
                Console.WriteLine("""I have a secret number between 1 and 100. Can you guess it?""");
                C

                string input = Console.ReadLine();

                if (int.TryParse(input, out guess))
               {
                        Console.WriteLine("Please enter a valid number.");
                        continue; // Skip to the next iteration without counting as an attempt
                    }
            }
        }
    }
}


