using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // intial setup
            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("In this game you will have 10 guesses to guess the number.");
            Console.WriteLine("You will recieve small hints along the way such as 'higher' and 'lower'.");
            Console.WriteLine("Enjoy!");
            int randNum = 0;
            Random rnd = new Random();
            string cont = "yes";
            string error = "random";
            int attempts = 0;
            int range = 100;
        // difficulty selection
        x: {
                b:
                Console.WriteLine("Select difficulty.");
                Console.WriteLine("Easy | Medium | Hard | Insane");
                string difficulty = Console.ReadLine();
                if (difficulty == "Easy" || difficulty == "easy" || difficulty == "e" || difficulty == "E" || difficulty == "Medium" || difficulty == "medium" || difficulty == "m"|| difficulty == "M" || difficulty == "Hard" || difficulty == "hard" || difficulty == "h" || difficulty == "H")
                {
                    randNum = rnd.Next(0, 101);
                    if (difficulty == "Easy" || difficulty == "easy" || difficulty == "e" || difficulty == "E")
                    {
                        attempts = 6;
                    }
                    else if (difficulty == "Medium" || difficulty == "medium" || difficulty == "m" || difficulty == "M")
                    {
                        attempts = 5;
                    }
                    else if (difficulty == "Hard" || difficulty == "hard" || difficulty == "h" || difficulty == "H")
                    {
                        attempts = 3;
                    }
                    else
                    {
                        Console.WriteLine("Please select one of the options fom above");
                        goto b;
                    }
                }
                else if (difficulty == "Insane" || difficulty == "insane" || difficulty == "i" || difficulty == "I")
                {
                    randNum = rnd.Next(0, 1001);
                    attempts = 5;
                    range = 1000;

                }
                else
                {
                    Console.WriteLine("Please select one of the options fom above");
                    goto b;
                }
                    // the actual game begins here
                    while (cont == "yes")
                    {
                        // initialisation
                        Console.WriteLine("The number range is 0-" + range);
                        Console.WriteLine("Type your guess into the console window");
                        // the game runs from here
                        while (attempts != 0)
                        {
                            // prints how many guesses you have left
                            string txt1 = "You have " + attempts + " attempts left";
                            Console.WriteLine(txt1);
                            string guess = Console.ReadLine();
                            int guess2;
                            // checks to see if the number is correct
                            if (!int.TryParse(guess, out guess2))
                            {
                                if (error == "yes")
                                {
                                    Console.WriteLine("Dont say i didnt warn you!");
                                    goto y;
                                }
                                if (error != "no")
                                {
                                    Console.WriteLine("Dont try break my program! HOW DARE YOU!!");
                                    Console.WriteLine("Do that again and I will end your game.");
                                    error = "yes";
                                }
                            }
                            else if (Convert.ToInt32(guess) == Convert.ToInt32(randNum))
                            {
                                // user feedback
                                Console.WriteLine("You correctly guessed the number! Great work!");
                                Console.WriteLine("Do you want to play again?");
                                Console.WriteLine("Yes    |    No");
                                string cont2 = Console.ReadLine();
                                // if you do not wish to contiue
                                if (cont2 == "no" || cont2 == "No")
                                {
                                    cont = "no";
                                }
                                // if you wish to play again
                                else if (cont2 == "yes" || cont2 == "Yes")
                                {
                                    cont = "yes";
                                    goto x;
                                }
                                // if you type something other than "yes" or "no"
                                else
                                {
                                    Console.WriteLine("Interpreting answer as no.");
                                    cont = "no";
                                    goto y;
                                }
                            }
                            // checks to see if guess is lower than random number and takes away an attempt
                            else if (guess2 > Convert.ToInt32(randNum))
                            {
                                Console.WriteLine("Lower");
                                attempts = --attempts;
                            }
                            // checks to see if guess is higher than random number and takes away and attempt
                            else if (guess2 < Convert.ToInt32(randNum))
                            {
                                Console.WriteLine("Higher");
                                attempts = --attempts;
                            }
                            // just in case a freak error happens
                            else
                            {
                                Console.WriteLine("Error");
                                attempts = 0;
                            }
                        }
                        // if you run out of attempts it asks if you want to restart as well as telling you what the correct number was
                        if (Convert.ToString(attempts) == "0")
                        {
                            Console.WriteLine("The correct number was: " + randNum);
                            Console.WriteLine("You ran out of guesses, restart?");
                            Console.WriteLine("Yes   |    No");
                            string cont2 = Console.ReadLine();
                            if (cont2 == "no" || cont2 == "No" || cont2 == "n" || cont2 == "N")
                            {
                                cont = "no";
                            }
                            else if (cont2 == "yes" || cont2 == "Yes" || cont2 == "y" || cont2 == "Y")
                            {
                                cont = "yes";
                                goto x;
                            }
                            // incase someone puts something other than no/yes/n/y in the restart box
                            else
                            {
                                Console.WriteLine("Interpreting answer as no.");
                                cont = "no";
                                goto y;
                            }
                        }
                    }
                    // the exit code, waits for a keypress
                y:
                {
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
            }
        }
    }
}