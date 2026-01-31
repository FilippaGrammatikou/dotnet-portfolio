namespace CSharpFundamentals.Exercises;

public static class Ch38_ArrayOfObjects
{
    public static void Run()
    {
        // Chapter 38: ArrayOfObjects

        /*  Car[] garage = new Car[3]; // defining arrays requires a data type, therefore Car[] is the type of the array of objects

         Car car1 = new Car("Mustang");
         Car car2 = new Car("Corvette");
         Car car3 = new Car("Lambo");

         garage[0]= car1;
         garage[1] = car2;
         garage[2] = car3;

         foreach (Car car in garage)
         {
             Console.WriteLine(car.model);
         } */

        // that was one way to do it. But if you don't want to define a specified size from the start, 
        // the following is better and more practical practice
        // we can just declare the array and imediately instantiate the objects instead

        Car[] garage = { new Car("Mustand"), new Car("Corvette"), new Car("Lambo")};
        
        Console.WriteLine(garage.Length);
        foreach (Car car in garage)
        {
            Console.WriteLine(car.model);
        }

        Console.ReadKey();
    }
    class Car
    {
        public String model; //field
        public Car(String model)
        {
            this.model = model;
        }
    }
}
