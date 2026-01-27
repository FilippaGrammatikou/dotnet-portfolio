namespace CSharpFundamentals.Exercises;

public static class Ch21_Arrays
{
    public static void Run()
    {
        // Chapter 21: Arrays
        // async variable that can store multiple values. fixed sized
        
        String[] cars = {"BMW", "MUSTANG", "CORVETTE"};

        cars[0] = "Tesla"; // updates the array
        cars[1] = "Mustand";
        cars[2] = "Corvette";

        for (int i = 0; i < cars.Length; i++){
            Console.WriteLine(cars[i]);
        }

        //String[] cars = new String[3]; declaring the array
    }
}
