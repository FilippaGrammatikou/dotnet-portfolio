namespace CSharpFundamentals.Exercises;

public static class Ch29_StringInterpolation
{
    public static void Run()
    {
        // Bro Code chapter 29: StringInterpolation
        // allows us to insert variables into a string literal
        // precede a string literal with $
        // {} are placeholders

        String firstName = "Random";
        String lastName = "Person";
        int age = 21;

        /* Console.WriteLine("Hello, " + firstName + " " + lastName ".");
        Console.WriteLine("You are " + age + " years old."); */

        // BETTER practice:

        Console.WriteLine($"Hello, {firstName} {lastName}.");
        Console.WriteLine($"You are {age} years old.");
        // Console.WriteLine($"You are {age, 10} years old."); //creates a gap of 10 spaces by the age including the digits of the int
        

        Console.ReadKey();
    }
}
