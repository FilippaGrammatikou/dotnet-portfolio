using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Exercises;

public static class Ch45_ListOfObjects
{
    public static void Run()
    {
        // Chapter 45: ListOfObjects
        // list of objects from a custom class

        List<Player> players = new List<Player>(); // new list <data type, in this case: our class>

        /*Player player1 = new Player("Chad"); //instantiating player objects
        Player player2 = new Player("Dean");
        Player player3 = new Player("Larry"); 

        players.Add(player1); // adds objects in the list
        players.Add(player2);
        players.Add(player3);*/

        players.Add(new Player("Chad")); //instantiating the objects anonymously
        players.Add(new Player("Dean"));
        players.Add(new Player("Larry"));

        foreach (Player player in players)
        {
            Console.WriteLine(player.username); //needs to add username, else displays class datatype
        } // or  we can override the ToString method

        Console.ReadKey();
    }

    class Player
    {
        public string username;

        public Player(String username)
        {
            this.username = username;
        }
        public override string ToString()
        {
            return username;
        }
    }
}