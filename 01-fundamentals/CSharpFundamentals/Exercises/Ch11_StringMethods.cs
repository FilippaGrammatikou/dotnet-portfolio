using System.Runtime.InteropServices;

namespace CSharpFundamentals.Exercises;

public static class Ch11_StringMethods
{
    public static void Run()
    {
        // Chapter 11: StringMethods

        String fullName = " Random Fullname";
        /* fullName = fullName.ToUpper(); // turns all characters into Upper Case
        fullName = fullName.ToLower(); // turns all characters into Lower Case
        Console.WriteLine(fullName); */

        String phoneNum = "123-456-789";
        /*phoneNum = phoneNum.Replace("-", "/"); // replaces the - within the phoneNum with /
        Console.WriteLine(phoneNum); */

        String userName = fullName.Insert(0, "@"); //inserts an @ at position 0 aka 1
        //Console.WriteLine(userName);

        // Console.WriteLine(fullName.Length);  //accesing a length property

        String firstName = fullName.Substring(0, 7); // keeps only the chars within the set range
        String lastName = fullName.Substring(7, 9); 
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);

        Console.ReadKey();
    }
}
