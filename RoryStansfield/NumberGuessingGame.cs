using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.Write("What is your name? ");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, nice to meet you!");
            Console.WriteLine("This a number guessing game.");
            Console.WriteLine($"A random number will be picked and you, {userName}, will have to try an guess it.");
            Console.WriteLine("The program will tell you if you are too high or too low.");
            Console.WriteLine("Lets begin!!");
            string programRepeat = "Y";
            while (programRepeat == "Y" || programRepeat == "Yes" || programRepeat == "y")
            {
                Random rnd = new Random();
                Console.WriteLine("A number in between 0 and 100 has been chosen.");
                int valnum = rnd.Next(100);
                Console.WriteLine("     Please guess: ");
                int valguess = Convert.ToInt32(Console.ReadLine());
                while (valguess > valnum)
                {
                    Console.WriteLine("     Your guess was too high: ");
                    Console.WriteLine("     Please guess again: ");
                    valguess = Convert.ToInt32(Console.ReadLine());
                }

                while (valguess < valnum)
                {
                    Console.WriteLine("     Your guess was too low: ");
                    Console.WriteLine("     Please guess again: ");
                    valguess = Convert.ToInt32(Console.ReadLine());
                }
                while (valguess == valnum)
                {
                    Console.WriteLine($"Congratulations {userName}, you guessed it.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                    valnum = rnd.Next(100);
                }
    }
}
