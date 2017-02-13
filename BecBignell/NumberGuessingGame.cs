using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupTaskNumberGuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourname;
            string a;
            int number = 0;


            Console.WriteLine("What is your name?");
            yourname = Console.ReadLine();
            Console.WriteLine("hello {0}", yourname);
            Console.WriteLine("Today you are playing the Number Guessing Game!");
        Start:

            Random rnd = new Random();
            int Value = rnd.Next(1, 100);

            while (number != Value)
            {
                Console.WriteLine("Take a guess 1 through 100");
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

                if (number > Value)
                {
                    Console.WriteLine("Lower");

                }
                if (number < Value)
                {
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine("You WON! the number was {0}", Value);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
