using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for convert celisus to fareinheight
            Console.WriteLine("Hello!");
            Console.Write("What is your name? ");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, nice to meet you!");
            Console.WriteLine("This program is designed to allow someone to easily convert temperatures between Celsius and Fahrenheit");
            string programRepeat = "Y";
            while (programRepeat == "Y" || programRepeat == "Yes")
            {
                Console.Write("Select the starting value, either C (Celsius) or F (Fahrenheit): ");
                string tempChoice = Convert.ToString(Console.ReadLine());
                if (tempChoice == "C" || tempChoice == "Celsius" || tempChoice == "c")
                {
                    Console.Write("Please enter the temperature in Celsius: ");
                    decimal tempValue = Convert.ToDecimal(Console.ReadLine());
                    tempValue = (Decimal.Multiply(tempValue, (9 / 5)) + 32);
                    Console.WriteLine($"The temperature in Fahrenheit is {tempValue}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }
                else if (tempChoice == "F" || tempChoice == "Fahrenheit" || tempChoice == "f")
                {
                    Console.Write("Please enter the temperature in Fahrenheit: ");
                    decimal tempValue = Convert.ToDecimal(Console.ReadLine());
                    tempValue = ((tempValue - 32) / (9 / 5));
                    Console.WriteLine($"The temperature in Celsius is {tempValue}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
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
