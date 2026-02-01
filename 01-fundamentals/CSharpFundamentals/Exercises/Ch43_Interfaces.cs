namespace CSharpFundamentals.Exercises;

public static class Ch43_Interfaces
{
    public static void Run()
    {
        // Chapter 43: Interfaces
        // defines a "contract" that all the classes inheriting from shou;d follow
        // An interface declares "what a class should have"
        // An inheriting class defines "how it should do it"
        // Benefit = security + multiple inheritance + "plug-and-play"


        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.Flee();
        hawk.Hunt();
        fish.Flee();
        fish.Hunt();

        Console.ReadKey();
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away.");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk searches for food.");
        }
    }

    class Fish : IPrey, IPredator // with interfaces a class can inherit more than one methods unlike with standard inheritance
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish!");
        }
    }

}
