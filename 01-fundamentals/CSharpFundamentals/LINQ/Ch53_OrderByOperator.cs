using CSharpFundamentals.ChapterSupport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFundamentals.LINQ;

public static class Ch53_OrderByOperator
    {
    public static void Run()
    {
        // Chapter 53: OrderByOperator
        // Used for ordering the data based on some property(eg price)
        //var booksCostWise = books.OrderBy(b=>b.Price) // default equals ascending
        //var booksCostWise = books.OrderByDescending(b=> b.Price)  // descending order
        // OR
        // var booksCostWise = from b in books orderby b.Price select b;
        // var booksCostWise = from b in books orderby b.Price descending select b;

        var books = Ch51_BookDatabase.GetBooksData();// import book data
        var data = books.OrderBy(b=>(price: b.Price), (author: b.Author)).ToList;

        data.ForEach(b => Console.WriteLine($"{b.price}-{b.author}"));
        



    }
}
