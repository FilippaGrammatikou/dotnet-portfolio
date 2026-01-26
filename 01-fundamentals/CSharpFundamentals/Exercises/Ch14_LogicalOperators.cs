namespace CSharpFundamentals.Exercises;

public static class Ch14_LogicalOperators
{
    public static void Run()
    {
        // Chapter 14: LogicalOperators
        // logical operators = can be used to check if more than one condition is true/false

        // && (AND)
        // || (OR)

        Console.WriteLine("What's the temperature outside: (C)");
        double temp = Convert.ToDouble(Console.ReadLine()); // converts the user input into a double since user input is always a string

        if (temp >= 0 && temp <=25){ // with && both conditions must be true
            Console.WriteLine("It's warm outside");
        }
        else if (temp <=-50 || temp>=50){ // with || only one condition needs to be true
            Console.WriteLine("Do not go outside!");
        }
            Console.ReadKey();
    }
}
