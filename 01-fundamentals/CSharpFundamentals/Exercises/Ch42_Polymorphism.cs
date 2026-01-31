using System.ComponentModel.DataAnnotations;

namespace CSharpFundamentals.Exercises;

public static class Ch42_Polymorphism
{
    public static void Run()
    {
        // Chapter 42: Polymorphism
        // "to have many forms"
        // Objects can be identified by more than one type
        // ex. a dog is also: a canine, animal, organism

        Car car = new Car();
        Bike bike = new Bike();
        Boat boat = new Boat();

        Vehicle[] vehicles = {car, bike, boat};

        foreach(Vehicle vehicle in vehicles)
        {
            vehicle.Go();
        }

        Console.ReadKey();
    }

    class Vehicle 
    {
        public virtual void Go()
        {
           // Console.WriteLine("The vehicle is moving."); //since the parent method will be overriden, this space can be left empty
        }
    }
    class Car : Vehicle 
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    class Bike : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bike is moving.");
        }
    }
    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving.");
        }
    }
}