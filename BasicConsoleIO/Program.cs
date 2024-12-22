﻿namespace BasicConsoleIO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Basic Console I/O *****");
		GetUserData();
    }

	static void GetUserData()
	{
		// Get name and age
		Console.Write("Please enter your name: ");
		string? userName = Console.ReadLine();
		Console.Write("Please enter your age: ");
		string? userAge = Console.ReadLine();

		// Change color
		ConsoleColor prevColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Yellow;

		// Echo
		Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

		// Restore previous color
		Console.ForegroundColor = prevColor;
	}
}
