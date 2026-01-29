namespace CSharpFundamentals.Exercises;

public static class Ch33_Constructors
{
    public static void Run()
    {
        // Chapter 33: Constructors
        // special METHOD in a class, same NAME as the CLASS NAME
        // can be used to assign arguments to fields when creating an object

        /* Person person1 = new Person("Trish", 30); //constructor removed the need to call the object instance and field seperately
        Person person2 = new("Chadley",20);

        person1.Eat(); //Eat() is an instance method, taken from the class, and currently used by human1
        person1.Sleeping();

        person2.Eat();
        person2.Sleeping(); */

        Car car1 = new("Ford", "Mustang", 2022, "red");
        Car car2 = new("Chevy", "Corvette", 2021, "blue");

        car1.Drive();
        car2.Drive();


        Console.ReadKey();
    }

    /*class Person
    {
        public String name; //not safe to make these public but just for learning porpuses
        public int age;

        public Person(String name, int age) //CONSTRACTOR
        {
            this.name = name;
            this.age = age; 
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }
        public void Sleeping()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }*/

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

        public void Drive()
        {
            Console.WriteLine("I drive the " + make + "," + year);
        }
    }
}
