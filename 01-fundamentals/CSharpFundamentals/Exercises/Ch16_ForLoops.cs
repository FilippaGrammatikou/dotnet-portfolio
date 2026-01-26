namespace CSharpFundamentals.Exercises;

public static class Ch16_ForLoops
{
    public static void Run()
    {
        // Chapter 16: ForLoops
        // repeats some code a FINITE amount of times

        /* for (int i = 0; i <10; i++){
            Console.WriteLine(i);
        } */

        for (int i = 10; i > 0; i--){
            Console.WriteLine(i);
        }

        Console.WriteLine("Happy new year!");

        Console.ReadKey();
    }
}
