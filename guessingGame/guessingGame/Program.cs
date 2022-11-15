using System;
using System.Linq.Expressions;

namespace guessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 

            Random random = new Random();

            bool playAgain = true;
            int minimum = 1;
            int maximum = 10;
            int guess;
            int tries;
            int number;
            string responses;

            while (playAgain)
            {
                guess = 0;
                tries = 0;
                responses = "";
                number = random.Next(minimum, maximum+1);

                Console.WriteLine("Welcome! This is an online Guessing game platform!");
                Console.WriteLine("You have to guess a secret number. If you guess correctly, you win!");

                while (guess != number)
                {

                    Console.WriteLine("Guess a number between " + minimum + "-" + maximum + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The number you guessed is: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too large!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too small!");
                    }
                    tries++;
                }
                Console.WriteLine("Number:" + number);
                Console.WriteLine("CONGRATULATIONS! YOU WIN!");
                Console.WriteLine("Number of tries is: " + tries);

                Console.WriteLine("Would you like to play again? (Y/N)");
                responses = Console.ReadLine();
                responses = responses.ToUpper();

                if (responses == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }

            }

            Console.WriteLine("Thank You!");
            Console.ReadKey();
        }
        catch(Exception e)
                {
                Console.WriteLine(e.Message);
            }
        }
    }
        
       
    
}