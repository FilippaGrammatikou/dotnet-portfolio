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
        // Vehicle vehicle = new Vehicle(); 
        // vehicle will not have wheels and maxspeed since it's a parent, which is wrong use of code
        // incomplete implemantation, should be avoided from usage
        Console.ReadKey();  
    }

    //parent classes do't inherit methods and fields from the children classes
    abstract class Vehicle // abstract prevents instantiating incomplete implementation of the parent class 
    {                                 // (abstract can be applied to properties and methods as well)
        public int speed = 0; // field

        public void go()  // method
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
