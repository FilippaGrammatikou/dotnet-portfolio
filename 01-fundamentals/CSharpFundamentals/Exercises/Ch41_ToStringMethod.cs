namespace CSharpFundamentals.Exercises;

public static class Ch41_ToStringMethod
{
    public static void Run()
    {
        // Chapter 41: ToStringMethod (built in)
        // converts an object to its string representation so that it is suitable for display

        Car car = new Car("Chevy", "Corvette", 2022, "blue");

        Console.WriteLine(car.ToString()); // displays the namespace followed by the type of object we are working with
        // in this case: CSharpFundamentals.Exercises.Ch41_ToStringMethod+Car

        // or: Console.WriteLine(car);

        Console.ReadKey();
    }
    class Car
    {
        String make;
        String model;
        int year;
        String colour;

        public Car(String make, String model, int year, String colour)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.colour = colour;
        }
        public override string ToString() // be sure to return a string
        {
            /* String mesage = "This is a " + make + " " + model; // can either do this
            return base.ToString(); */

            return "This is a " + make + " " + model+"."; // or this
        }
    }
}
