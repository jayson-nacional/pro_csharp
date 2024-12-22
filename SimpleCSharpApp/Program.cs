﻿namespace SimpleCSharpApp;

public class Program
{
    public static void Main(string[] args)
    {
		ShowEnvironmentDetails();
    }

    static void ShowEnvironmentDetails()
    {
        foreach (string drive in Environment.GetLogicalDrives())
        {
            Console.WriteLine("Drive: {0}", drive);
        }

        Console.WriteLine("OS: {0}", Environment.OSVersion);
        Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
        Console.WriteLine(".NET Core Version: {0}", Environment.Version);
    }
}
