using System.Xml.Linq;

namespace CSharpFundamentals.Exercises;

public static class Ch15_WhileLoops
{
    public static void Run()
    {
        // Chapter 15: WhileLoops
        // repeats some code while so condition remains true

        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();

        while (name == ""){  // or while(name == null){
            Console.Write("Please enter a non-blank name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello, " + name +"!");
        Console.ReadKey();
    }
}


// OR EVEN BETTER


/*    String name = "";

        while (name == ""){ 
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello, " + name + "!");
Console.ReadKey(); */