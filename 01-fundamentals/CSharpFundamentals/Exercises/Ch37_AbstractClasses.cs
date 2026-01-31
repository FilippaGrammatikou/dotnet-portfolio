namespace CSharpFundamentals.Exercises;

public static class Ch37_AbstractClasses
{
    public static void Run()
    {
        // Chapter 37: AbstractClasses
        // modifier that indicates missing components or incomplete implementation

        Car car = new Car();
        Bike bike = new Bike();
        Boat boat = new Boat();
        Vehicle vehicle = new Vehicle();

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
        int maxSpeed = 500;
    }
    class Bike : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 200;
    }
}
