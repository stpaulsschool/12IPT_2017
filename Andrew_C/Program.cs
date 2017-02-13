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
            int var1, var2 = 5, var3 = 6;
            var1 = var2++ * --var3;
            Console.WriteLine(var1);
            Console.ReadLine();
        }
    }
}
