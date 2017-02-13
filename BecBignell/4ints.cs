using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write a console application that obtains 4 int values from the user and calcualtes the product. this my require the use of Convert.Toint32()

            int number1;
            int number2;
            int number3;
            int number4;
            int answer;
            string a;
            string b;
            string c;
            string d;
            string yourname;

            Console.WriteLine("What is your name?");
            yourname = Console.ReadLine();
            Console.WriteLine("hello {0}", yourname);
            Console.WriteLine("Today we will be adding 4 number of your choose together.");

            Start:
            Console.WriteLine("Please enter your 1st number");
            a = Console.ReadLine();
            try
            {
                number1 = Convert.ToInt32(a);
            }
            catch
            {
                Console.WriteLine("please enter valid number");
                goto Start;
            }
        Start2:
            Console.WriteLine("Please enter your 2nd number");
            b = Console.ReadLine();
            try
            {
                number2 = Convert.ToInt32(b);
            }
            catch
            {
                Console.WriteLine("please enter valid number");
                goto Start2;
            }
        Start3:
            Console.WriteLine("Please enter your 3rd number");
            c = Console.ReadLine();
            try
            {
                number3 = Convert.ToInt32(c);
            }
            catch
            {
                Console.WriteLine("please enter valid number");
                goto Start3;
            }
        Start4:
            Console.WriteLine("Please enter your 4th number");
            d = Console.ReadLine();
            try
            {
                number4 = Convert.ToInt32(d);
            }
            catch
            {
                Console.WriteLine("please enter valid number");
                goto Start4;
            }
            answer = number1 + number2 + number3 + number4;
            Console.WriteLine("here is your answer");
            Console.WriteLine($"{number1}+{number2}+{number3}+{number4}={answer}");
            Console.Write("Press and key to continue");
            Console.ReadKey();
        }
    }
}
