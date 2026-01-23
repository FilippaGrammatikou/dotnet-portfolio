namespace CSharpFundamentals.Exercises;

public static class Ch04_Constants
{
    public static void Run()
    {
        // Chapter 4: Constants
        // Immutable values which are known at compile time and do not change for the life of the program

        const double pi = 3.14159; //const keyword to forbid value changes
        //provides security to programs so that other users may not change the predetermined constant values
        Console.WriteLine(pi);

        const double PiLiteral = 3.14159;
        double radius = 2;

        double areaUsingConst = PiLiteral * radius * radius;
        double areaUsingMathPi = Math.PI * radius * radius; // Math.PI is not const; it's a static readonly double, so it can't be assigned to a const.

        Console.WriteLine($"areaUsingConst: {areaUsingConst}");
        Console.WriteLine($"areaUsingMathPi: {areaUsingMathPi}");

        Console.ReadKey();
    }
}
