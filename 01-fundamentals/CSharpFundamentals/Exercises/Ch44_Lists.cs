using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Exercises;

public static class Ch44_Lists
{
    public static void Run()
    {
        // Chapter 44: Lists
        // data structure that represents a list of objects that can be accessed by index
        // similar to arrays, but can DYNAMICALLY increase/decrease in size
        // using System.Collections.Generic; 

        /* String[] food = new string[3];

        food[0] = "pizza";
        food[1] = "hamburger";
        food[2] = "steak";
        food[3] = "fries"; */

        // Instead, use lists

        List<string> food = new List<string>();
        // food.Add("fries");
        food.Add("pizza");
        food.Add("hamburger");
        food.Add("steak");
        food.Add("fries");

        // food.Remove("fries");
        // food.Insert(0, "sushi");
        // Console.WriteLine(food.Count);
        // Console.WriteLine(food.IndexOf("pizza"));
        // Console.WriteLine(food.LastIndexOf("fries"));
        // Console.WriteLine(food.Contains("pizza"));
        // food.Sort();
        // food.Reverse();
        // food.Clear();
        // String[] foodArray = food.ToArray();
        
        foreach (String item in food)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

}
