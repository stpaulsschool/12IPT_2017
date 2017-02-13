using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            int numfin;
            Console.WriteLine("Simple calculator.");
            Console.WriteLine("Please input 2 numbers");
            Console.WriteLine("Number 1");
            z:
            string num11 = Console.ReadLine();
            int num12;
            if (!int.TryParse(num11, out num12))
            {
                Console.WriteLine("please only use numbers");
                goto z;
            }
            Console.WriteLine("Number 2");
            y:
            string num21 = Console.ReadLine();
            int num22;
            if (!int.TryParse(num21, out num22))
            {
                Console.WriteLine("please only use numbers");
                goto y;
            }
            Console.WriteLine("Please choose your operation");
            x:
            Console.WriteLine("+   |   -   |   *   |   /");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                numfin = num12 + num22;
            }
            else if (operation == "-")
            {
                numfin = num12 - num22;
            }
            else if (operation == "*")
            {
                numfin = num12 * num22;
            }
            else if (operation == "/")
            {
                numfin = num12 / num22;
            }
            else
            {
                Console.WriteLine("Please use one of the operations listed");
                goto x;
            }
            Console.WriteLine(num12 + operation + num22 + " = " + numfin);
            Console.WriteLine("Do another calculation?");
            Console.WriteLine("Yes   |   No");
            string may = Console.ReadLine();
            if (may == "yes" || may == "Yes" || may == "y" || may == "Y")
            {
                goto start;
            }
        }
    }
}
