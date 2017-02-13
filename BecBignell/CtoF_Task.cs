using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTaskCtoF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a console that can turn the tempurter from C to F of F to C
            int number;
            double CFnumber;
            double FCnumber;
            string a;
            string yourname;

            Console.WriteLine("What is your name?");
            yourname = Console.ReadLine();
            Console.WriteLine("hello {0}", yourname);

        Start:
            Console.WriteLine("would you like to convert from celsius to fahrenheit is so press 1, or do you want to convert fahrenheit to Celsius press 2");
            a = Console.ReadLine();
            try
            {
                number = Convert.ToInt32(a);
            }
            catch
            {
                Console.WriteLine("please enter valid number");
                goto Start;
            }


            if (number == 1)
            {
                Console.WriteLine("You are converting from celsius to fahrenheit");
                Console.WriteLine("Please enter a number you would like to convert");
                CFnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} Fahrenheit", (CFnumber * 1.8) + 32);
            }
            if (number == 2)
            {
                Console.WriteLine("You are converting from fahrenheit to celsius");
                Console.WriteLine("Please enter a number you would like to convert");
                FCnumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0} Celsius", (FCnumber-32)*5/9);
            }
            else if (number != 1 || number != 2)
            {
                Console.WriteLine("You did not pick number 1 or 2");
                goto Start;
            }
            Console.ReadKey();
        }
    }
}
