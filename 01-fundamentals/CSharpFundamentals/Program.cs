using System;
using CSharpFundamentals.Exercises;
using CSharpFundamentals.LINQ;

Console.Write("Chapter number (1–59): ");
var input = Console.ReadLine();

if (int.TryParse(input, out var id))
{
    if (id >= 1 && id <= 50)
    {
        Topics.Run(id);          // Exercises (Bro Code 1–50)
    }
    else if (id >= 51 && id <= 59)
    {
        LinqTopics.Run(id);      // LINQ (51–59)
    }
    else
    {
        Console.WriteLine("Out of range. Use 1–50 (Exercises) or 51–59 (LINQ).");
    }
}
else
{
    Console.WriteLine("Invalid input. Enter a number like 2, 12, 57.");
}
