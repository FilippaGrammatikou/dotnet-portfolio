using CSharpFundamentals.Exercises;

Console.Write("Bro Code chapter number (1–50): ");
var input = Console.ReadLine();

if (int.TryParse(input, out var id))
{
    Topics.Run(id);
}
else
{
    Console.WriteLine("Invalid input. Enter a number like 2, 12, 37...");
}
