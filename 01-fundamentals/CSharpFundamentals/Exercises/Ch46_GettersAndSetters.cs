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
        // set accessor = used to assign a new value
        // value keyword = defines the value being assigned by the set (parameter)

        Car car = new Car(400); //because public Car(int speed), therefore new Car(400 -> speed field)
        car.Speed = 1000000000; //accessing the property instead of the field

        Console.WriteLine(car.Speed); //accessing the property instead of the field if speed is written with a capital S

        Console.ReadKey();
    }

    class Car
    {
        private int speed; //field but if we turned it to private, we would lose access
        public Car(int speed)
        {
            speed = speed;
        }

        public int Speed //property
        {
            get { return speed; }  //read whatever values are within the field
            set // for this to be writable, we need set // writable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
                    speed = value; // value is like a parameter. when assigning a value to speed, that value is =value;
            }
        }
    }
}
