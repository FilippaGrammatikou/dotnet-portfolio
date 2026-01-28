namespace CSharpFundamentals.Exercises;

public static class Ch28_ConditionalOperator
{
    public static void Run()
    {
        // Chapter 28: ConditionalOperator
        // used in conditional assignment if a condition is true/false
        // (condition) ? x : y

        double temp = 20;
        // String message;

        /* if (temp >= 15) {
            message = "It's warm outside";
        }
        else {
            message = "It's cold outside";
        } */

        // message = (temp >= 15) ? "It's warm outside!" : "It's cold outside!"; // mesage not needed if we do the following:
        Console.WriteLine((temp >= 15) ? "It's warm outside!" : "It's cold outside!");

        Console.ReadKey();
    }
}
