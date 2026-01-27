namespace CSharpFundamentals.Exercises;

public static class Ch25_MethodOverloading
{
    public static void Run()
    {
        // Chapter 25: MethodOverloading
        // methods share same name, but different parameters
        //name + parameters = signature
        // methods must have a unique signature

        double total;

        total = Multiply(2, 3);

        Console.WriteLine(total);
        Console.ReadLine();
    }

    static double Multiply (double a, double b){
        return a* b;
        }
}
