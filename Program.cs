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

        // Create a new array to store strings with length <= 3
        string[] newArray = new string[originalArray.Length];

        // For Each Item
        foreach (string item in originalArray)
        {
            // Length <= 3? (Decision)
            if (item.Length <= 3)
            {
                // Add Row
                newArray[newIndex] = item;
                newIndex++;
            }

            // Increase Indexes
            iterationCounter++;
        }

        // Array Output
        Console.WriteLine("\nOriginal Array:");
        PrintArray(originalArray);

        Console.WriteLine("\nNew Array (Length <= 3):");
        PrintArray(newArray);

        // End of Program
        Console.WriteLine("\nEnd of program.");
    }
    

