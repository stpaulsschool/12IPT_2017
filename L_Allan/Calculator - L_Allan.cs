using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator Unit Numerator Codified");
        x:
            Console.WriteLine("Please enter two numbers you would like to add, subtract, multiply or divide");
            Console.WriteLine("(In the order that they will be calculated)");
        firstval:
            string firstValue = Console.ReadLine();
            int firstValue1;
            if (!int.TryParse(firstValue, out firstValue1))
            {
                Console.WriteLine("That's not a number. Please enter a number.");
                goto firstval;
            }
        secval:
            string secondValue = Console.ReadLine();
            int secondValue1;
            if (!int.TryParse(secondValue, out secondValue1))
            {
                Console.WriteLine("That's not a number. Please enter a number.");
                goto secval;
            }

            Console.WriteLine("Would you like to add, subtract, multiply or divide?");
            string num = Console.ReadLine();
            if (num == "add" || num == "Add" || num == "addition" || num == "Addition" || num == "+" || num == "A" || num == "a")
            {
                int completeValue = firstValue1 + secondValue1;
                Console.WriteLine("{0}+{1}={2}", firstValue1, secondValue1, completeValue);
            }
            else if (num == "sub" || num == "Sub" || num == "subtract" || num == "Subtract" || num == "-" || num == "s" || num == "S" || num == "subtraction" || num == "Subtraction")
            {
                int completeValue = firstValue1 - secondValue1;
                Console.WriteLine("{0}-{1}={2}", firstValue1, secondValue1, completeValue);
            }

            else if (num == "div" || num == "Div" || num == "divide" || num == "Divide" || num == "/" || num == "D" || num == "d" || num == "divison" || num == "Division")
            {
                int completeValue = firstValue1 / secondValue1;
                Console.WriteLine("{0}/{1}={2}", firstValue1, secondValue1, completeValue);
            }
            else if (num == "multiply" || num == "Multiply" || num == "mul" || num == "Mul" || num == "*" || num == "M" || num == "m")
            {
                int completeValue = firstValue1 * secondValue1;
                Console.WriteLine("{0}*{1}={2}", secondValue1, secondValue1, completeValue);
            }
            Console.WriteLine("Would you like to calculate something else?");
            Console.WriteLine("Yes    |    No");
            string restart = Console.ReadLine();
            if (restart == "yes" || restart == "Yes" || restart == "y" || restart == "Y")
            {
                goto x;
            }
            else if (restart == "no" || restart == "No" || restart == "n" || restart == "N")
            {
                Console.WriteLine("Press any key to exit");
            }
            Console.ReadKey();
        }
    }
}
 