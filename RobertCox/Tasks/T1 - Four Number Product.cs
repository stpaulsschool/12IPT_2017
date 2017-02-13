using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1FourNumbers {
	class Program {
		static string name;
		static bool cont = true;

		static string greet() {
			Console.Write("Welcome to 4 Number Product. What's your name? ");
			return Console.ReadLine();
		}

		static bool calcLoop() {
			Console.Clear();
			int[] nums = new int[4];

			// Get the numbers

			for (int index = 0; index < nums.Length; index++) {
				Console.Write("Please enter a number: ");
				while (!int.TryParse(Console.ReadLine(), out nums[index])) {
					Console.Write("Please enter a valid integer. No decimals: ");
				}
			}

			// Perform the calculation

			Console.Clear();
			int prod = 1;
			foreach (int i in nums) { prod *= i; };
			Console.WriteLine($"Your numbers multiplied together are: {prod}!\nPress enter to continue.");
			Console.ReadKey();

			// Check if the user wants to continue.

			Console.Write("Would you like to continue? (y/n): ");
			return (Console.ReadLine() == "y");
		}

		static void Main(string[] args) {
			name = greet();
			Console.WriteLine($"Nice to meet you, {name}!");
			Console.ReadLine();
			do {
				cont = calcLoop();
			} while (cont);
		}
	}
}
