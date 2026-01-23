namespace CSharpFundamentals.Exercises;

public static class Ch06_UserInput
{
    public static void Run()
    {
        // Chapter 6: UserInput
        // when accepting user input, it's of string f data type

        Console.WriteLine("What is your name?");
        String name = Console.ReadLine(); // prompts user to enter data

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine()); // handling exceptions with incorrect type format soon

        Console.WriteLine("Hello, " + name + ".");
        Console.WriteLine("Your age is: " + age + ".");

        Console.ReadKey();
    }
}
