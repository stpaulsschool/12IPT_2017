using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskloop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int y = 1; y <= 5; y++)
            {
                for (int x = 1; x <= y; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
