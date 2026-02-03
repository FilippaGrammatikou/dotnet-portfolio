namespace CSharpFundamentals.Exercises;

public static class Ch48_Enums
{
    public static void Run()
    {
        // Chapter 48: Enums
        // special "class" that contains a set of named integer constants
        // use enums when you have values that you know will not change,
        // to get the integer value from an item, you must explicitly convert to an int
        // name = integer

        //Console.WriteLine(Planets.Pluto + " is a planet.");
        // Console.WriteLine(Planets.Pluto.ToString() + " is a planet."); // same as the line above
        Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury); //cast as an integer
        Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);

        String name=PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        double volume = Volume(PlanetRadius.Earth);


        Console.WriteLine("planet " + name);
        Console.WriteLine("planet " + radius + "km");
        Console.WriteLine("volume: " + volume+ "km^3");

        Console.ReadKey();
    }
    public static double Volume(PlanetRadius radius)
    {
        double Volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return Volume;
    }

    enum Planets
    {
        //Mercury, // by default this is 0 or we can numerate them 
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8,
        Pluto = 9
    }

   public enum PlanetRadius
    {
        Mercury = 2439,
        Venus = 6051,
        Earth = 6371,
        Mars = 3389,
        Jupiter = 69911,
        Saturn = 58232,
        Uranus = 25362,
        Neptune = 24622,
        Pluto = 1188
    }
}

