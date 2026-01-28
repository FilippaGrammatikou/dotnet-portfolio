namespace CSharpFundamentals.Exercises;

public static class Ch30_MultidimensionalArrays
{
    public static void Run()
    {
        // Chapter 30: MultidimensionalArrays

        /* String[] ford = { "Mustang", "F-150", "Explorer" };
        String[] chevy = { "Corvette", "Camaro", "Silverado" };
        String[] toyota = { "Corolla", "Camry", "Rav4" }; */

        String[,] parkingLot = {  { "Mustand", "F-150", "Explorer"},
                                                { "Corvette", "Camaro", "Silverado" },
                                                { "Corolla", "Camry", "Rav4"}
                                             }; //once we complete this array, we don't need the ones from above anymore

        parkingLot[0, 2] = "Fusion"; //we can change the values within the array by declaring the exact position in the multidimensional array
        parkingLot[2,0] = "Tacoma";

        /*foreach(String car in parkingLot)
        {
            Console.WriteLine(car);
        }*/

        //using nested for loops, we display the array like a grid/matrix
        for(int i = 0; i < parkingLot.GetLength(0); i++) //getLength in the first loop always starts with 0
        {
            for(int j=0; j < parkingLot.GetLength(1); j++) // 1 so that this represents the second dimension
            {
                Console.Write(parkingLot[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
