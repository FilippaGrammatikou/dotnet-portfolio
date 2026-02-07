using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CSharpFundamentals.ChapterSupport;


namespace CSharpFundamentals.LINQ;

public static class Ch52_WhereOperator
    {
    public static void Run()
    {
        // Chapter 51: WhereOperator
        // Used for filtering data from a set of data
        // eg:  var cheapBooks = books.Where(b=>b.Price<100); or var cheapBooks = from b in books where b.Price <100 select b;


        var books = Ch51_BookDatabase.GetBooksData();  // imports book data

        var data = books.Where(b => b.Price < 500); //METHOD based
        // var data = from b in books  where b.price<500 select b; //QUERY based

        foreach(var item in data)
        {
            Console.WriteLine($"{item.Name} - {item.Author} - ({item.Price})");
        }


        //if we want on;y the titles of the books that are under 500, then all we need to do is this:
        /*var data = books.Where(b => b.Price < 500).Select(b=>b.Name);  // METHOD based
        // var data = from b in books  where b.price<500 select b.Name;     //QUERY based
         
        foreach (var item in data)
        {
            Console.WriteLine($"{item.Name} - {item.Author}");
        }*/



        Console.ReadKey();
        }
}
