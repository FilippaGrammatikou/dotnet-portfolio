using CSharpFundamentals.ChapterSupport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFundamentals.LINQ;

public static class Ch54_ThenByOperator
    {
    public static void Run()
    {
        // Chapter 54: OrderByOperator
        // after applying a OrderBy, if there are same value entries for that property(eg 2 books with the same price),
        // an additional ordering can be done based on another property

        // var booksCostWise = books.OrderBy(b=>b.Price) // METHOD based
        //                                              .ThenBy(b=>b.Quantity);
        // OR
        // var booksCostWise = from b in books orderby b.Price, b.Quantity select b; //QUERY based


        var books = Ch51_BookDatabase.GetBooksData();
        var data = books.OrderBy(b => b.Price)
                                   .ThenBy(b => b.Name);
        // var data = from b in books orderby b.Price, b.Name select b;
        // var data = from b in books orderby b.Price, b.Name descending select b;

        foreach (var entry in data)
        {
            Console.WriteLine($"{entry.Name} - {entry.Author} - {entry.Price}");
        }

        Console.ReadKey();
    }
}
