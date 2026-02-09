using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CSharpFundamentals.ChapterSupport;

namespace CSharpFundamentals.LINQ;

public static class Ch55_GroupByOperator
    {
    public static void Run()
    {
        // Chapter 55: GroupByOperator
        // used for grouping data based on any property
        // var groupedBooks = books.GroupBy(b=>b.Author);
        // OR
        // var groupedBooks = from b in books group b by b.Author;

        // printing method makes it difficult to preview the data so instead
        //grouped data(eg authors) can be placed into a new list with the Grouped Key and other day

        // grouping and putting into new list
        // var output = books.GroupBy(b=>b.Author).Select(g=>new
        //                     {
        //                              Author = g.Key,
        //                              BookCount = g.Count()
        //                     });

        // OR

        // var output = from b in boosk group b by b.Author into g
        //                                                select new
        //                                                {
        //                                                      Author = g.Key,
        //                                                      BookCount = g.Count() //Count() is an extension LINQ method
        //                                                };

       var books = Ch51_BookDatabase.GetBooksData(); //imported collection of books
       // var data = books.GroupBy(b => b.Author); //grouping based on author

        /*foreach(var entry in data)  // set of books associated with author key
        { 
            Console.WriteLine($"{entry.Key}");
        }*/

        var fullData = books.GroupBy(b => b.Author).Select(g => new
        {
            Author = g.Key, //key is the key on which this group is divided
            BookCount = g.Count()
        }).OrderByDescending(b=>b.BookCount);

        // var fullData = from b in book group by b.Author into g
        //                         select new
        //                         {
        //                              Author = g.Key,
        //                              BookCount = g.Count()
        //                         }

        foreach(var entry in fullData)
        {
            Console.WriteLine($"{entry.Author} - {entry.BookCount}");
        }

        var fullData2 = books.GroupBy(b => b.Author).Select(g => new
        {
            Author = g.Key, //key is the key on which this group is divided
            Books = g.Select(book => book)
        });

        Console.WriteLine("     ");
        Console.WriteLine("     ");

        foreach (var entry in fullData2)
        {
            Console.WriteLine($"{entry.Author}");
            foreach(var book in entry.Books)
            {
                Console.WriteLine($"      {book.Name} - {book.Price}");
            }
        }

        //-------------------//
        // If we wish to have all the data and clauses we have learned so far we can do the following:

        /*var collection = books.Where(b => b.Price < 700).GroupBy(b => b.Author).Select(gb => new
        {
            Author = gb.Key,
            Books = gb.Select(book => book.Name)
        }).OrderBy(t=> t.Author);

        foreach(var entry in collection)
        {
            Console.WriteLine($"{entry.Author}");
            foreach(var book in entry.Books)
            {
                Console.WriteLine($"    {book}");
            }
        })*/


        Console.ReadLine();

    }
}

