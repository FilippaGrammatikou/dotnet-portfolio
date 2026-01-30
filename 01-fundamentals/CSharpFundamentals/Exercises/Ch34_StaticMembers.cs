using System.ComponentModel.DataAnnotations;

namespace CSharpFundamentals.Exercises;

public static class Ch34_StaticMembers
{
    public static void Run()
    {
        // Chapter 34: StaticMembers
        // modifier to declare a static member, which belongs to the class itself rather than to any specific object

        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");
        Car car3 = new Car("Lambo");


        /* Console.WriteLine(car1.numberOfCars); // if numberOfCars++ isn't static there is no real ownership for Car aka there would be 1 & 1 cars, not 2
        Console.WriteLine(car2.numberOfCars); // numberOfCars++ needs to be static in order for the counter to
        We can no longer access this field in a non-static way*/

        // we can only access it now in a STATIC way
        Console.WriteLine(Car.numberOfCars);
        Car.StartRace();

        Console.ReadKey();
    }

    class Car
    {
        String model;
        public static int numberOfCars; // although bad practice, must be turned into a public so thaat Run() can access it
        public Car(String model)
        {
            this.model = model;
            numberOfCars++; //this now belongs to the class and no one object has complete ownership of it
        }
        public static void StartRace() // static can be used for methods as well
        {
            Console.WriteLine("The race has begun. ");
        }
    }
}