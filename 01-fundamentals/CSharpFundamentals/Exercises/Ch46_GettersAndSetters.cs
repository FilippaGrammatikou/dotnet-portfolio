using System.ComponentModel.DataAnnotations;

namespace CSharpFundamentals.Exercises;

public static class Ch46_GettersAndSetters
{
    public static void Run()
    {
        // Chapter 46: GettersAndSetters
        // add security to fields by encapsulation. They're accessors found within properties

        // properties = combine aspects of both fields and methods (share name with a field)
        // get accessor = used to return the property value
        // get accessor = used to assign a new value
        // value keyword = defines the value being assigned by the set (parameter)

        Car car = new Car(400);
        car.speed = 100000000;

        Console.WriteLine(car.speed);

        Console.ReadKey();
    }

    class Car
    {
        public int speed;
        public Car(int speed)
        {
            speed = speed;
        }
    }
}
