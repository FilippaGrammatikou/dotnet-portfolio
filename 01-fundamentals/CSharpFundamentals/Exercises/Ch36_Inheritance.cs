namespace CSharpFundamentals.Exercises;

public static class Ch36_Inheritance
{
    public static void Run()
    {
        // Chapter 36: Inheritance
        // One or more CHILD classes receiving fields, methods, etc. from a common parent

        Car car = new Car();
        Bike bike = new Bike();
        Boat boat = new Boat();

        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);
        car.go();

        Console.WriteLine(bike.speed);
        Console.WriteLine(bike.wheels);
        bike.go();

        Console.WriteLine(boat.speed);
        Console.WriteLine(boat.wheels);
        boat.go();

        Console.ReadKey(); 
    }

    class Vehicle // parent class
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }
    class Car : Vehicle // child class has access to the parent's methods and fields
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
