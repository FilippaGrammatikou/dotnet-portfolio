namespace CSharpFundamentals.Exercises;

public static class Ch39_ObjectsAsArguments
{
    public static void Run()
    {
        // Chapter 39: ObjectsAsArguments
        // listin data types correctly in order to porperly use objects as arguments

        Car car1 = new Car("Mustang", "blue");
        Car car2 = Copy(car1);

        // ChangeColour(car1, "silver");
        Console.WriteLine(car1.colour + " " + car1.model);
        Console.WriteLine(car2.colour + " " + car2.model);

        Console.ReadKey();
    }

    /* public static void ChangeColour(Car car, String colour) //changes car colour
    {
        car.colour= colour;
    }*/

    public static Car Copy(Car car)
    {
        return new Car(car.model, car.colour);
    }

    public class Car
    {
        public String model; //field
        public String colour; 

        public Car(String model, String colour)
        {
            this.model = model;
            this.colour = colour;
        }
    }
}
 