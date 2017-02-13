using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Temperature {
	class Program {
		public static string command;

		public static void greet() {
			Console.Write("Hi, welcome to temperature converter.\nWhat\'s your name? ");
			Console.WriteLine($"Nice to meet you, {Console.ReadLine()}! [Enter to continue].");
			Console.ReadKey();
		}

		public static double celsiusToFahrenheit(double celsius) {
			return ((celsius * 9) / 5) + 32;
		}

		public static double fahrenheitToCelsius(double fahrenheit) {
			return ((fahrenheit - 32) * 5) / 9;
		}

		public static void calcLoop() {
			double num;
			string type;
			Console.Clear();

			// Getting conversion type.

			Console.WriteLine("Would you like to convert to celsius or to fahrenheit?\nC = Celsius\nF = Fahrenheit");
			type = Console.ReadLine().ToLower();
			if (type != "c" && type != "f") {
				Console.Clear();
				Console.WriteLine("Please pick either 'C' or 'F'.");
				Console.ReadKey();
				return;
			}

			// Getting number.

			Console.WriteLine($"What temperature would you like to convert to {(type == "c" ? "Celsius" : "Fahrenheit")}?");
			try {
				num = Double.Parse(Console.ReadLine());
			} catch {
				Console.Clear();
				Console.WriteLine("Please enter a proper temperature.");
				Console.ReadKey();
				return;
			}

			// Converting.

			Console.WriteLine($"{num.ToString()} {(type == "c" ? "F" : "C")} converted to {(type == "c" ? "Celsius" : "Fahrenheit")} is {(type == "c" ? fahrenheitToCelsius(num).ToString() : celsiusToFahrenheit(num).ToString())}.");
			Console.ReadKey();

			// Checking to continue

			Console.Clear();
			Console.Write("Would you like to continue? (y/n): ");
			command = Console.ReadLine().ToLower();
			if (command != "y") {
				return;
			}
			Console.Clear();
		}

		static void Main(string[] args) {
			greet();
			do {
				calcLoop();
			} while (command == "y");
		}
	}
}
