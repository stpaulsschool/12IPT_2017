using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            if (x == 5 && y == 7)
            {
                Console.WriteLine("This is true.");
            }

            if (x == 5 || y == 9)
            {
                Console.WriteLine("This is also true.");
            }
            Console.ReadKey();

        }
    }
}
