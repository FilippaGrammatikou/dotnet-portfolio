namespace CSharpFundamentals.Exercises;

public static class Ch08_MathClass
{
    public static void Run()
    {
        // Chapter 8: MathClass

        double x = 3.99;
        double y = 5;

        double a = Math.Pow(x, 3); // raises a value to a certain power
        double b = Math.Sqrt(x); // square root of x
        double c = Math.Abs(x); // absolute value of x
        double d = Math.Round(x); //rounds x 
        double e = Math.Ceiling(x); // rounds x upwards, 3.14 => 4
        double f = Math.Floor(x); // rounds x downwards, 3,99 => 3
        double g = Math.Max(x, y); // maximum value of x and y
        double h = Math.Min(x,y); // minimum value of x and y

        // Console.WriteLine(a/b/c/d/e/f/g/h);
        Console.ReadKey();
    }
}
