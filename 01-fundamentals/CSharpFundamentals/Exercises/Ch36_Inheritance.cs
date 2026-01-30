namespace CSharpFundamentals.Exercises;

public static class Ch36_Inheritance
{
    public static void Run()
    {
        // Chapter 36: Inheritance
        // One or more CHILD classes receiving fields, methods, etc. from a common parent


        Console.ReadKey(); 
    }

    class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle
    {
        public int wheels = 4;
    }

    class Bike : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;
    }

}
