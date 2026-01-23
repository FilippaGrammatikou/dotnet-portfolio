namespace CSharpFundamentals.Exercises;

public static class Ch07_ArithmeticOperators
{
    public static void Run()
    {
        // Chapter 7: ArithmeticOperators

        int x = 5;
        x = x + 1; //or x += 1;
        x++; // increments by 1

        int y = 5;
        y = y - 1; // or y-=1;
        y--; // subtracts by 1

        int z = 5;
        z = z * 2; // or  z *= 2;

        int d = 5;
        d = d / 2; // only whole numbers are stored in int, therefore this is integer division so no decimal portions
        // or d /= 2;

        int s = 10;
        int remainder = s % 3; // % modules is the remainder operator

        Console.WriteLine(x);
        Console.ReadKey();
    }
}
