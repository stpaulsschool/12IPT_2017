using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int attempts = 6;
            x:
            {
                attempts = 6;
            Random r = new Random();

            int val = r.Next(1, 101);
            int guess = 0;
//Introduction
            Console.WriteLine("Hello. Welcome to the Random Number Guessing System Undergoing Surveillance AKA the RNGSUS. I have generated a number between 1 and 100. Can you figure it out  in 6 guesses?");
//Guess
                while (attempts != 0)
                {
                    Console.Write("Guess: ");
                    string input = Console.ReadLine();
//Word Guesses aren't allowed
                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("That's not a number. Stupid. I wont remove an attempt however.");
                        continue;
                    }
//Low Guess
                    if (guess < val)
                    {
                        Console.WriteLine("No, the number I'm thinking is higher than that number. Guess again.");
                        attempts = --attempts;
                        string ALeft = "You have " + attempts + " attempts left.";
                        Console.WriteLine(ALeft);
                        continue;
                    }
//High Guess
                    else if (guess > val)
                    {
                        Console.WriteLine("No, the number I'm thinking is lower than that number. Guess again.");
                        attempts = --attempts;
                        string ALeft = "You have " + attempts + " attempts left.";
                        Console.WriteLine(ALeft);
                        continue;
                    }
//Correct Guess
                    else
                    {
                        Console.WriteLine("You guessed right!");
                        Console.WriteLine("If you would like to play again, restart the RNGSUS.");
                        goto y; 
                    }
                }
            }
//Out of Guesses
            if (Convert.ToString(attempts) == "0")
            {
                Console.WriteLine("You have run out of attempts. Restart RNGSUS?");
                Console.WriteLine("Yes    |    No");
                string restart = Console.ReadLine();
                if (restart == "yes" || restart == "Yes")
//Reset Code
                {
                    goto x;
                }
                else if (restart == "no" || restart == "No")
                {
                    goto y;
                }
            }
            y:
            {
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}
//Tausend Danks to Andrew for the Goto/Reset code.