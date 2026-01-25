namespace CSharpFundamentals.Exercises;

public static class Ch12_IfStatements
{
    public static void Run()
    {
        // Chapter 12: If Statements
        // basic decision making form

        /* Console.WriteLine("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if(age >= 18 && age <= 119){
            Console.WriteLine("You are now signed up!");
        }
        else if (age < 0){
            Console.WriteLine("Please enter a valid age!");
        }
        else if (age > 120){
            Console.WriteLine("Please enter a valid age!");
        }
        else{
            Console.WriteLine("You must be 18+ to sign up to this service!");
        } */

        Console.WriteLine("Please enter your name: ");
        String name = Console.ReadLine();

        if (name == "") { // or if (name != "") console.writeline("hello, " + name)}
            Console.WriteLine("You did not enter your name");
        }
        else{
            Console.WriteLine("Hello, " + name);
        }
            Console.ReadKey();
    }
}
