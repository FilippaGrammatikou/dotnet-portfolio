using System.Numerics;

namespace CSharpFundamentals.Exercises;

public static class Ch24_ReturnKeyword
{
    public static void Run()
    {
        // Chapter 24: ReturnKeyword
        // returns data back to the place where a method is invoked
        double x;
        double y;
        double result;

        Console.WriteLine("Enter in number 1: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter in number 2: ");
        y= Convert.ToDouble(Console.ReadLine());

        result = Multiply(x, y);
        Console.WriteLine(result);

        Console.ReadKey();
        }

    static double Multiply(double x, double y)
    {
        double z = x * y;
        return z;
    }
}
