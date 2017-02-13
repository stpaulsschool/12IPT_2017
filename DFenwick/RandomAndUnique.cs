using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAndUnique
{
    class Program
    {
        static Random obj = new Random(); //seeding CPU clock
        static void Main(string[] args)
        {
            Console.WriteLine(GetPseudoRandom());
            Console.WriteLine(GetPseudoRandom());
            Console.WriteLine(GetPseudoRandom());
            Console.WriteLine(GetPseudoRandom());
            Console.ReadKey();
        }
        private static string GetPseudoRandom()
        {
            //Random obj = new Random();
            return obj.Next(1, 50).ToString();
        }
    }
}
