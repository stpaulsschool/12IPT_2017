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
            Console.WriteLine("Welcome to the Celsius (°C) / Fahrenheit (°F) Converter.");
        x:
            {
                Console.WriteLine("Would you like to convert Celsius to Fahrenheit (write c-f)");
                Console.WriteLine("or Fahrenheit to Celcius ? (write f - c)");
                string convert = Console.ReadLine();

                if (convert == "f-c" || convert == "f - c" || convert == "F-C" || convert == "F - C")
                {
                    Console.WriteLine("Write down the temperature in Fahrenheit.");
                    int firstValue = Convert.ToInt32(Console.ReadLine());
                    int completeValue = firstValue - 32 * 5 / 9;
                    Console.WriteLine("{0}-32*5/9 = {1}", firstValue, completeValue);
                }

                else if (convert == "c-f" || convert == "c - f" || convert == "C-F" || convert == "C - F")
                {
                    Console.WriteLine("Write down the temperature in Celsius.");
                    int thirdValue = Convert.ToInt32(Console.ReadLine());
                    int othercompleteValue = thirdValue * 9 / 5 + 32;
                    Console.WriteLine("{0}*9/5+32 = {1}", thirdValue, othercompleteValue);
                }

                Console.WriteLine("Would you like to convert something else?");
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
