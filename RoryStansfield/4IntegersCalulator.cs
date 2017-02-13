using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4IntegersCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program for collecting 4 integers and finding the product
            Console.WriteLine("Hello!");
            Console.Write("What is your name? ");
            string userName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Hello {userName}, nice to meet you!");
            Console.WriteLine("This program is designed to find the product of 4 integers the user, you, enters.");
            string programRepeat = "Y";
            while (programRepeat == "Y")
            {
                Console.WriteLine("Enter your 4 integers:");
                Console.Write("     Integer One: ");
                int valOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("     Integer Two: ");
                int valTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("     Integer Three: ");
                int valThree = Convert.ToInt32(Console.ReadLine());
                Console.Write("     Integer Four: ");
                int valFour = Convert.ToInt32(Console.ReadLine());
                int valProduct = valOne * valTwo * valThree * valFour;
                Console.WriteLine($"The product of the integers you entered is: {valProduct}");
                Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
                programRepeat = Console.ReadLine();
            }
        }
    }
}
