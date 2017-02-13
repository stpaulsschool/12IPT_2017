using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Four Unit Calculator.");
        x:
            {
                Console.WriteLine("Write down four numbers and the FUC will add them together");
                int firstValue = Convert.ToInt32(Console.ReadLine());
                int secondValue = Convert.ToInt32(Console.ReadLine());
                int thirdValue = Convert.ToInt32(Console.ReadLine());
                int fourthValue = Convert.ToInt32(Console.ReadLine());
                int completeValue = firstValue + secondValue + thirdValue + fourthValue;
                Console.WriteLine("{0}+{1}+{2}+{3}={4}", firstValue, secondValue, thirdValue, fourthValue, completeValue);

                Console.WriteLine("Would you like to calculate something else?");
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
               
     