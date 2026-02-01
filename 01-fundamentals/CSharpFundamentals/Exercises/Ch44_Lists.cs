namespace CSharpFundamentals.Exercises;

public static class Ch44_Lists
{
    public static void Run()
    {
        // Chapter 44: Lists
        // data structure that represents a list of objects that can be accessed by index
        // similar to arrays, but can DYNAMICALLY increase/decrease in size
        // using System.Collections.Generic; 

        String[] food = new string[3];

        food[0] = "pizza";
        food[1] = "hamburger";
        food[2] = "steak";
        food[3] = "fries";

        foreach (String item in food)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

}
