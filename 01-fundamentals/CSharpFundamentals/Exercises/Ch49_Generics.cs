namespace CSharpFundamentals.Exercises;

public static class Ch49_Generics
{
    public static void Run()
    {
        // Chapter 49: Generics
        // "not specified to a particular data type"
        // add <T> to: classes, method, fields,etc.
        // allows for code reusability for different data types

        int[] intArray = { 1, 2, 3 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        String[] stringArray = { "1", "2", "3" };
        
        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);

        Console.ReadKey();
    }
    /*public static void displayElements(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
    public static void displayElements(double[] array)
    {
        foreach(double item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
    public static void displayElements(String[] array)
    {
        foreach (String item in array)
        {
            Console.WriteLine(item + " ");
        }
    }*/
    public static void displayElements<Thing>(Thing[] array)
    {
        foreach (Thing item in array)
        {
            Console.WriteLine(item + " ");
        }
    }
}