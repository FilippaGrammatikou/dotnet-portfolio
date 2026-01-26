namespace CSharpFundamentals.Exercises;

public static class Ch13_SwitchStatements
{
    public static void Run()
    {
        // Chapter 13: SwitchStatements
        // An efficient alternative to many else if statements

        Console.WriteLine("What day is it today");
        String day = (Console.ReadLine());
        day = day.ToLower();

        switch (day)
        {
            case "monday":
                Console.WriteLine("It is Monday");
                break;
            case "tuesday":
                Console.WriteLine("It is Tuesday");
                break;
            case "wednesday":
                Console.WriteLine("It is Wednesday");
                break;
            case "thursday":
                Console.WriteLine("It is Thursday");
                break;
            case "friday":
                Console.WriteLine("It is Friday");
                break;
            case "saturday":
                Console.WriteLine("It is Saturday");
                break;
            case "sunday":
                Console.WriteLine("It is Sunday");
                break;
            default:
                Console.WriteLine("Not a valid day. Type e.g. Monday.");
                break;
        }
        Console.ReadKey();
    }
}


// More efficient way

/* while (true)
{
    Console.WriteLine("What day is it today?");
    string day = Console.ReadLine()?.Trim().ToLower();

    switch (day)
    {
        case "monday":
        case "tuesday":
        case "wednesday":
        case "thursday":
        case "friday":
        case "saturday":
        case "sunday":
            Console.WriteLine($"The day you entered is: {day}");
            return; // exits Run()
        default:
            Console.WriteLine("Invalid input, try again.");
            break;
    }
}
*/
