using CSharpFundamentals.ChapterSupport;

namespace CSharpFundamentals.Exercises;

public static class Ch31_Classes
{
    public static void Run()
    {
        // Chapter 31: Classes
        // A bundle of related code we wish to organize together. Can be used as a blueprint to create objects (oop)
        // Math.Round(3.14); // clicking on the class allows us to see all the math related methods withing it

        // in order to call them, we either need some sort of object or we turn the class into static and the methods within as public static
        ClassChapter31.Hello();
        ClassChapter31.Waiting();
        ClassChapter31.Goodbye();

        Console.ReadKey();
    }

    // To create a class we need to ensure that we are witting our code outside of other classes

    /*  class Messages
     {
         void Hello()
         {
             Console.WriteLine("Hello! Welcome to the program!");
         }

         void Waiting()
         {
             Console.WriteLine("I am waiting for an action");
         }

         void Goodbye()
         {
             Console.WriteLine("Thank you for visiting this program!");
         }
     } */
    // Or we can create a class via the solution explorer.

}
