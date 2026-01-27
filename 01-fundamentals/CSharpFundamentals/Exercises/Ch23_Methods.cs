namespace CSharpFundamentals.Exercises;

public static class Ch23_Methods
{
    public static void Run()
    {
        // Chapter 23: Methods
        // performs a selection of codel, whenever it's called "invoked"
        // benefit = let's us reuse code w/o writing it multiple times

        singHappyBirthday();
        singHappyBirthday();
        singHappyBirthday();

        Console.ReadKey();
    }
        static void singHappyBirthday(){
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear YOU");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
}
