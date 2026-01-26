namespace CSharpFundamentals.Exercises;

public static class Ch17_NestedLoops
{
    public static void Run()
    {
        // Chapter 17: NestedLoops

        //loops inside of other loops. Uses vary. Used a lot in sorting algorithms

        /*Console.WriteLine("How many rows?: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("How many columns?: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Which symbol: ");
        String symbol = Console.ReadLine();

        for (int x = 0; x < rows; x++){
            for (int y = 0; y < columns; y++){
                Console.Write(symbol);
            }
            Console.WriteLine();
        } */

        Console.WriteLine("Which symbol:");
        string symbol = Console.ReadLine();

        Console.WriteLine("Height:");
        int height = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < height; row++)
        {
            // leading spaces (decrease each row)
            for (int s = 0; s < height - row - 1; s++)
                Console.Write(" ");

            // symbols (1, 3, 5, ...)
            for (int c = 0; c < 2 * row + 1; c++)
                Console.Write(symbol);

            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
