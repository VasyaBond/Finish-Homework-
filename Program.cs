using System;

class Program
{
    static void Main()
    {
        // String Array Input
        Console.WriteLine("Enter strings separated by commas:");
        string[] originalArray = Console.ReadLine().Split(',');

        // Initializing Iteration Counter
        int iterationCounter = 0;
        int newIndex = 0;