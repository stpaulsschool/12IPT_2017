using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Calculator {
	class Program {
		public static string name;

		public static void greet() {
			Console.Write("Hello! Welcome to the Basic Calculator.\nWhat\'s your name? ");
			name = Console.ReadLine();
			Console.WriteLine($"Nice to meet you, {name}. [Enter to continue].");
			Console.ReadKey();
		}

		public static void calcLoop() {
			double n1,n2,fin;
			string calc;
			string[] allowed = {"+", "-", "/", "*"};
			Console.Clear();

			// Acquiring numbers to do calculations on.

			Console.WriteLine("Please type a number.");
			try {
				n1 = Double.Parse(Console.ReadLine());
				Console.WriteLine("Please type a second number.");
				n2 = Double.Parse(Console.ReadLine());
			} catch {
				Console.Clear();
				Console.WriteLine("There has been an error while entering numbers. Are you sure it\'s a real number?");
				Console.ReadKey();
				return;
			}

			// Acquiring the type of calculation - +, -, *, /.

			Console.WriteLine("Please enter the type of calculation.\nMultiply = *\nDivide = /\nSubtract = -\nAdd = +");
			calc = Console.ReadLine();
			if (!allowed.Contains(calc)) {
				Console.Clear();
				Console.WriteLine("That isn\'t a valid type of calculation.");
				Console.ReadKey();
				return;
			}
			
			// Performing calculation.

			if (calc == "*") {
				fin = n1 * n2;
			} else if (calc == "/") {
				fin = n1 / n2;
			} else if (calc == "+") {
				fin = n1 + n2;
			} else if (calc == "-") {
				fin = n1 - n2;
			} else {
				Console.Clear();
				Console.WriteLine("An error has occurred.");
				Console.ReadKey();
				return;
			}

			// Return number.

			Console.WriteLine($"The result of {n1.ToString()} {calc} {n2.ToString()} is {fin.ToString()}.");
			Console.ReadKey();
		}

		// Main program loop.

		static void Main(string[] args) {
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.White;
			Console.Clear();
			greet();
			while(true) {
				calcLoop();
			}
		}
	}
}
