namespace CSharpFundamentals.Exercises;

public static class Ch22_ForeachLoop
{
    public static void Run()
    {
        // Chapter 22: ForeachLoop
        // a simpler way to iterate over an array, but it's less flexible

        String[] cars = { "BMW", "MUSTANG", "CORVETTE" };

        /*for (int i = 0; i < cars.Length; i++){
            Console.WriteLine(cars[i]);
        } */
        //OR
        foreach (String car in cars){
            Console.WriteLine(car);
        }

        Console.ReadLine();
    }
}
