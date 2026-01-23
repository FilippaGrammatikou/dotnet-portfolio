namespace CSharpFundamentals.Exercises;

public static class Ch05_Casting
{
    public static void Run()
    {
        // Chapter 5: Type Casting

        // Converting a value to a different data type
        // Useful when we accept user input (string)
        // Different data types can do different things

        double a = 3.14;
        int b = Convert.ToInt32(a); // method that converts into an integer
        Console.WriteLine(b);
        Console.WriteLine(a.GetType()); //returns the type of the variable a

        int c = 123; 
        double d = Convert.ToDouble(c) + 0.1; // method that converts into a double
        Console.WriteLine(d.GetType());

        int e = 321;
        String f = Convert.ToString(e); // method that converts into a string
        Console.WriteLine(f.GetType());

        String g = "$";
        char h = Convert.ToChar(g); // method that converts into a character
        Console.WriteLine(h.GetType());

        String i = "true";
        bool j = Convert.ToBoolean(i); // method that converts into a boolean
        Console.WriteLine(j.GetType());

        Console.ReadKey();
    }
}
