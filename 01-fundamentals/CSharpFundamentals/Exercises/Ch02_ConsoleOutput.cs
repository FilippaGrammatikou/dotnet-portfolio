namespace CSharpFundamentals.Exercises;

public static class Ch02_ConsoleOutput
{
    public static void Run()
    {
         // Chapter 2: ConsoleOutput

         Console.Write("This is  an output display"); //does not hit the Enter key after the end
         Console.WriteLine("This is also an output display"); //creates a new empty line 
         Console.WriteLine(); //cw + Tab Key => autogenerate WriteLine statement Shortcut

         // This is a one-line comment
         /* This
         * is 
         * a multi-line
         * comment*/

         // Escape Sequences
         Console.WriteLine("\tTestingSequenses"); //adds a horizontal Tab seq. 
         Console.WriteLine("Testing\bSequenses"); //adds a backspace
         Console.WriteLine("Testing\nSequenses"); //adds a new line
         Console.WriteLine("\aTestingSequenses"); //adds a Bell alert
         Console.WriteLine("Testing\fSequenses"); //adds Form Feed
         Console.WriteLine("Testing\rSequenses"); //adds Carriage Return
         Console.WriteLine("\vTestingSequenses"); // adds a vertical Tab seq.
         Console.WriteLine("\'TestingSequenses\'"); //adds a single quotation mark 
         Console.WriteLine("\"TestingSequenses\""); //adds a soubble quotation mark
         Console.WriteLine("\\TestingSequenses\\"); // adds backslash

        Console.ReadKey(); // prevents the program from ending until we provide a key
    }
}
