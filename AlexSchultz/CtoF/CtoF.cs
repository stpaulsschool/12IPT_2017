using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!");
            Console.Write("What is your name? ");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, nice to meet you!");
            Console.WriteLine("This program is designed to allow someone to easily convert temperatures between Celsius and Fahrenheit");
            string programRepeat = "y";
            while (programRepeat == "y" || programRepeat == "yes")
            {
                Console.Write("Select the starting value, either C (Celsius) or F (Fahrenheit): ");
                string tempChoice = (Convert.ToString(Console.ReadLine())).ToLower();
                if (tempChoice == "c" || tempChoice == "celsius")
                {
                    Console.Write("Enter the temperature in Celsius: ");
                    double tempValue = Convert.ToDouble(Console.ReadLine());
                    tempValue = (((tempValue * 9) / 5) + 32);
                    Console.WriteLine($"The temperature in Fahrenheit is {tempValue}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }
                else if (tempChoice == "f" || tempChoice == "fahrenheit")
                {
                    Console.Write("Enter the temperature in Fahrenheit: ");
                    double tempValue = Convert.ToDouble(Console.ReadLine());
                    tempValue = (((tempValue - 32) * 5) / 9);
                    Console.WriteLine($"The temperature in Celsius is {tempValue}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = (Console.ReadLine()).ToLower();
                }
                else
                {
                    Console.WriteLine("The value you entered is neither C, Celsius, F, or Fahrenheit.");
                    Console.WriteLine("Is it really that hard?");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }

            }
        }
    }
}
