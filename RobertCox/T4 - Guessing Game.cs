using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4GuessingGame {
	class Program {
		static Random numGen = new Random();
		static string name;
		static bool proceed = true;
		const int minVal = 1;
		const int maxVal = 101;
		const int attemptTotal = 6;

		static string greet() {
			Console.Write("Welcome to the random number guesser!\nWhat's your name? ");
			return Console.ReadLine();
		}

		static void gameLoop() {
			Console.Clear();
			int number = numGen.Next(minVal, maxVal);
			int guessNum = 0;
			int attempts = attemptTotal;

			// Introduce to player.

			Console.WriteLine($"I'm thinking of a number between {minVal} and {(maxVal-1)}.");

			// Begin game loop.

			do {
				Console.Write($"\nYou have {attempts} attempts left.\nSee if you can guess the number: ");
				while (!int.TryParse(Console.ReadLine(), out guessNum)) {
					Console.Write("Are you sure that's a number? Please type it again: ");
				}
				attempts--;
				if (guessNum == number) break;
				Console.WriteLine($"Not quite! You need to guess {((number < guessNum) ? ("lower") : ("higher"))}.");
			} while (guessNum != number && attempts != 0);

			// Check if they won or lost.

			Console.Clear();
			if (guessNum == number) {
				Console.WriteLine($"Congratulations! You guessed the correct number of {number}!");
			} else {
				Console.WriteLine($"Better luck next time. The correct answer was {number}.");
			}
			Console.Write("Would you like to try again? (y/n): ");
			proceed = (Console.ReadLine() == "y" ? true : false);
		}

		static void Main(string[] args) {
			name = greet();
			Console.WriteLine($"Have fun, {name}! Press enter to continue.");
			Console.ReadKey();
			do {
				gameLoop();
			} while (proceed);
		}
	}
}
