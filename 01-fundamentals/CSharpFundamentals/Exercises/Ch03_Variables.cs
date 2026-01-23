namespace CSharpFundamentals.Exercises;

public static class Ch03_Variables
{
    public static void Run()
    {
        // Chapter 3: Variables

        // Declaring a variable takes two steps: Declaration & Initialization
        int x; // declaring a whole Integer
        x = 123; // initialization
        int y = 321; //declaration + initialization

        int z = x + y;
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);

        int age = 25;
        Console.WriteLine("This is a way to preview a variable within a message: " + age  + ".");

        double height = 300.3; // Decimal 
        Console.WriteLine("The examplary use of the double variable is this height: " + height + "cm.");

        bool lightsOn= true; // Boolean Values (True or False)
        Console.WriteLine("Is the light switch on or not? " + lightsOn);

        char symbol = '%'; // Single Character => placed within single quotations
        char symbol2 = '@';

        Console.WriteLine("This is the percentage " + symbol + " symbol.");

        String name = "Random Name"; // Series of char || Defined with a capital S => placed within double quotations
        String name2 = "random_example";
        String userName = symbol2 + name2;

        Console.WriteLine("Hello, " + name + ". Nice to meet you!");
        Console.WriteLine("The user name is: " + userName + ".");

        Console.ReadKey();
    }
}
