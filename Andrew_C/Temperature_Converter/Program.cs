using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            f:
            Console.WriteLine("Fahrenheit to celsius and celsius to fahrenheit calculator.");
            Console.WriteLine("What are you going to convert from?");
            Console.WriteLine("C   |   F");
            string choice = Console.ReadLine();
            if (choice == "c" || choice == "C")
            {
                Console.WriteLine("Converting celsius to fahrenheit.");
                Console.WriteLine("Please input the temperature you wish to convert.");
                z:
                string temp = Console.ReadLine();
                decimal temp2;
                if (!decimal.TryParse(temp, out temp2))
                {
                    Console.WriteLine("Please only use numbers.");
                    goto z;
                }
                decimal convtemp = ((temp2 * 9) / 5) + 32;
                Console.WriteLine(temp2 + " Celsius is equal to " + convtemp + " Fahrenheit.");
            }
            else if (choice == "f" || choice == "F")
            {
                Console.WriteLine("Converting fahrenheit to celsius.");
                Console.WriteLine("Please input the temperature you wish to convert.");
            x:
                string temp = Console.ReadLine();
                decimal temp2;
                if (!decimal.TryParse(temp, out temp2))
                {
                    Console.WriteLine("Please only use numbers.");
                    goto x;
                }
                decimal convtemp = ((temp2 - 32) * 5) / 9;
                Console.WriteLine(temp2 + " Fahrenheit is equal to " + convtemp + " Celsius.");
            }
            Console.WriteLine("Do you wish to do another conversion?");
            Console.WriteLine("Yes   |   No");
            string cont = Console.ReadLine();
            if (cont == "yes" || cont == "Yes" || cont == "y" || cont == "Y")
            {
                goto f;
            }
        }
    }
}
