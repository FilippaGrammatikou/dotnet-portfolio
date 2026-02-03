namespace CSharpFundamentals.Exercises;

public static class Ch47_AutoProperties
{
    public static void Run()
    {
        // Chapter 47: AutoProperties
        // shortcut when no additional logic is required in the proeprty
        // do not have to define a field for a property,
        // only have to write get; and/or set; inside the property

        Car car = new Car("Porsche");

        Console.WriteLine(car.Model);

        Console.ReadKey();
    }
    class Car
    {
        /*String model;

        public String Model //property
        {
            get { return model; }
            set { model = value; }
        } */

        public String Model { get; set; }

        public Car(String model) //constructor
        {
            this.Model = model;
        }

    }
}
