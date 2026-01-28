namespace CSharpFundamentals.Exercises;

public static class Ch27_ExceptionHandling
{
    public static void Run()
    {
        //Chapter 27: ExceptionHandling
        // errors that occur during execution

        // try = try some code that is considered "dangerous"
        // catch = catches and handles exceptions when they occur
        // finally = always executes regardless if exception is caught or not

        double x;
        double y;
        double results;

        /* Console.WriteLine("Enter number 1: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 1: ");
        y = Convert.ToDouble(Console.ReadLine());

        results = x / y; // doesn't handle error exceptions e.g. string input, 0 etc
        Console.WriteLine("results: " + results); */

        try
        {
            Console.WriteLine("Enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 1: ");
            y = Convert.ToDouble(Console.ReadLine());

            results = x / y; // doesn't handle error exceptions e.g. string input, 0 etc
            Console.WriteLine("results: " + results);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Please enter ONLY valid inputs!");
        }
        /* catch (DivideByZeroException e) // this only occurs with int division, so in order for this exception to be valid, the variables 
         {                                                        // have to be turned into integers
             Console.WriteLine("You cannot divide by zero!");
         } */
        /* catch (Exception e) //catches all exceptions but is not good practice
        {                                  // User won't know what error occured
            Console.WriteLine("Something went wrong!"); // It is wiser to handle all exceptions seperately and ONLY then use this method
        }*/

        // finally block is OPTIONAL. Used for closing open files or resetting

        finally //will still excecute EVEN if an exception catches an error
        {
            Console.WriteLine("Thank you for visiting!");
        }

        Console.ReadKey();  
    }
}
