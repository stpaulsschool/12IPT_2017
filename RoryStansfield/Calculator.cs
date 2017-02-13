using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.Write("What is your name? ");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, nice to meet you!");
            Console.WriteLine("This program is designed to work like a calculator.");
            string programRepeat = "Y";
            while (programRepeat == "Y" || programRepeat == "Yes" || programRepeat == "y")
            {
                Console.Write("Select the an operator, + , - , X , % : ");
                string opChoice = Convert.ToString(Console.ReadLine());
                if (opChoice == "+")
                {
                    Console.Write("     Integer One: ");
                    int valOne = Convert.ToInt32(Console.ReadLine());
                    Console.Write("     Integer Two: ");
                    int valTwo = Convert.ToInt32(Console.ReadLine());
                    int valProduct = valOne + valTwo;
                    Console.WriteLine($"{valOne} + {valTwo} = {valProduct}");
                    Console.WriteLine($"The answer is {valProduct}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }
                else if (opChoice == "-")
                {
                    Console.Write("     Integer One: ");
                    int valOne = Convert.ToInt32(Console.ReadLine());
                    Console.Write("     Integer Two: ");
                    int valTwo = Convert.ToInt32(Console.ReadLine());
                    int valProduct = valOne - valTwo;
                    Console.WriteLine($"{valOne} - {valTwo} = {valProduct}");
                    Console.WriteLine($"The answer is {valProduct}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }
                else if (opChoice == "X" || opChoice == "x")
                {
                    Console.Write("     Integer One: ");
                    int valOne = Convert.ToInt32(Console.ReadLine());
                    Console.Write("     Integer Two: ");
                    int valTwo = Convert.ToInt32(Console.ReadLine());
                    int valProduct = valOne * valTwo;
                    Console.WriteLine($"{valOne} X {valTwo} = {valProduct}");
                    Console.WriteLine($"The answer is {valProduct}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }
                else if (opChoice == "/" || opChoice == "%")
                {
                    Console.Write("     Integer One: ");
                    int valOne = Convert.ToInt32(Console.ReadLine());
                    Console.Write("     Integer Two: ");
                    int valTwo = Convert.ToInt32(Console.ReadLine());
                    int valProduct = valOne / valTwo;
                    Console.WriteLine($"{valOne} / {valTwo} = {valProduct}");
                    Console.WriteLine($"The answer is {valProduct}.");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("The value you have entered cannot be calculated");
                    Console.WriteLine("Apologies");
                    Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                    programRepeat = Console.ReadLine();

                }
            }
    }
}
