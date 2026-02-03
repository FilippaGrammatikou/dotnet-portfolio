using System;
using System.Collections.Generic;

namespace CSharpFundamentals.Exercises;

public static class Ch45_ListOfObjects
{
    public static void Run()
    {
        // Chapter 45: ListOfObjects

        List<Player> players = new List<Player>();
        Player player1 = new Player("Chad");
        Player player2 = new Player("Dean");
        Player player3 = new Player("Larry");

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);

        foreach (Player player in players)
        {
            Console.WriteLine(player.username);
        }

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