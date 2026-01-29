namespace CSharpFundamentals.Exercises;

public static class Ch32_Objects
{
    public static void Run()
    {
        // Chapter 32: Objects
        // an instance of a class.
        // a class can be used as a blueprint to create objects (oop)
        // objects can have fields and methods (characteristics and actions)

        Human human1 = new Human(); // new Human() creates a new object within the var reference "human1"
        Human human2 = new();

        human1.name = "Rick"; // Rick is a field/ property/ instance data
        human1.age = 30; // < object >.< fieldOrProperty >


        human2.name = "Chad";
        human2.age = 20;

        human1.Eat(); //Eat() is an instance method, taken from the class, and currently used by human1
        human1.Sleeping(); // <object>.<method>(arguments);
        // Math.Sqrt(25); <ClassName>.<method>(arguments); Static method (no object needed)

        human2.Eat();
        human2.Sleeping();

        Console.ReadKey();
    }
}
