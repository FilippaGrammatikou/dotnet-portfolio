namespace CSharpFundamentals.Exercises;

public static class Ch23_Methods
{
    public static void Run()
    {
        // Chapter 23: Methods
        // performs a selection of codel, whenever it's called "invoked"
        // benefit = let's us reuse code w/o writing it multiple times

        String name = "Random";
        int age = 25;

        singHappyBirthday(name, age); // pass down the name and age argument
        //singHappyBirthday();
        //singHappyBirthday();

        Console.ReadKey();
    }
        static void singHappyBirthday(String name, int age){ // pass down the name and age argument
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear, " + name);
            Console.WriteLine("You are " + age + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
}

// static void singHappyBirthday(String bdayBoy, int yearsOld){ // can have different names
/*        Console.WriteLine("Happy birthday to you!");
           Console.WriteLine("Happy birthday to you!");
           Console.WriteLine("Happy birthday dear, " + bdayBoy);
           Console.WriteLine("You are " + yearsOld + " years old!");
           Console.WriteLine("Happy birthday to you!");
           Console.WriteLine();
       }
} */