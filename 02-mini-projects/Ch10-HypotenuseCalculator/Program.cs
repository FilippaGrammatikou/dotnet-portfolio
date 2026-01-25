/* Mini Project — Ch10: Hypotenuse Calculator (Right Triangle)
    -Computes hypotenuse length from legs a and b using:
        c = √(a² + b²)
    -Requirements:
       a and b are numeric (double) and non-negative.

    Example:
      a = 3, b = 4  =>  c = 5 */

namespace Ch10_HypotenuseCalculator;

public static class Prorgam
{
    public static void Main()
    {

        Console.WriteLine("Please Enter Side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please Enter Side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt((a * a) + (b * b));
        Console.WriteLine(" The Hypotenuse is: " + c);

        Console.ReadKey();
    }
}