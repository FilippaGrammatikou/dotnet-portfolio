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

        /* String[] food = new string[3]; //array

        food[0] = "pizza"; //adding elements in array
        food[1] = "hamburger";
        food[2] = "steak";
        food[3] = "fries"; */ // if we add an extra element, we run into an unhandled exception :outside the bounds of the array

        // Instead, use lists

        List<string> food = new List<string>(); //list, type of object we want to store, name of list

        // food.Add("fries");
        food.Add("pizza"); //adds items
        food.Add("hamburger");
        food.Add("steak");
        food.Add("fries");

        // food.Remove("fries"); //removes item from list
        // food.Insert(0, "sushi"); // insert an object at a given element, we need an index and an item, DOESN'T replace existing item in list
        // Console.WriteLine(food.Count); // displays list size
        // Console.WriteLine(food.IndexOf("pizza")); //displays positon of an item in the list
        // Console.WriteLine(food.LastIndexOf("fries")); //displays numerical positon of the last item in the list
        // Console.WriteLine(food.Contains("pizza"));  //returns a boolean
        // food.Sort(); //lists the list alphabetically
        // food.Reverse(); //lists the list alphabetically reversed
        // food.Clear(); //clears the list
        // String[] foodArray = food.ToArray(); // converts the list into an array declaring a new array

        foreach (String item in food)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

}
