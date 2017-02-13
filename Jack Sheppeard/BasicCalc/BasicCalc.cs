/*BASIC CALCULATOR*/
	Console.WriteLine("Hello!");
	Console.Write("What is your name? ");
	string userName = Convert.ToString(Console.ReadLine());
	Console.WriteLine($"Hello {userName}, nice to meet you!");
	Console.WriteLine("This program is designed to allow someone to do basic calculations");
	string programRepeat = "y";
	while (programRepeat == "y" || programRepeat == "yes")
	{
		Console.Write("Enter your first number: ");
		double numberOne = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter your second number: ");
		double numberTwo = Convert.ToDouble(Console.ReadLine());
		Console.Write("Select an Operator: (+), (-), (*), (/): ");
		string chosenOperator = Convert.ToString(Console.ReadLine());
		if (chosenOperator == "+")
		{
			numberOne += numberTwo;
		}
		else if (chosenOperator == "-")
		{
			numberOne -= numberTwo;
		}
		else if (chosenOperator == "*")
		{
			numberOne *= numberTwo;
		}
		else if (chosenOperator == "/")
		{
			numberOne /= numberTwo;
		}
		else
		{
			Console.WriteLine("Try again with a correct operator this time.");
		}
		Console.WriteLine($"The annswer is: {numberOne}");
		Console.WriteLine($"Would you like to continue {userName}? Enter Y if yes.");
		programRepeat = (Console.ReadLine()).ToLower();
	}
