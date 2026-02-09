using CSharpFundamentals.ChapterSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpFundamentals.LINQ;

public static class Ch56_UsefulOperator
    {
    public static void Run()
    {
        // Chapter 56: UsefulOperators
        // Here is a following list of other useful LINQ operators and their use

        // data.Single() ==> Looks for ONE item matching the condition. If not found or found more, throws exception
        // data.SingleOrDefault() ==> Same as previous. No exception. If not found, returns default value
        // data.First() ==> Looks for FIRST item matching the condition. If not found, throws exception
        // data.FirstOrDefault() ==> Same as First(). No exception. If not found, returns default value
        // data.Last() ==>  Looks for LAST item matching the condition. If not found, throws exception
        // data.LastOrDefault() ==> Same as Last(). No exception. If not found, returns default value
        // data.Min() ==> Gets the min from a list of numeric elements, or based on the property specified.
        // data.Max() ==> Gets the max from a list of numeric elements, or based on the property specified.
        // data.Average() ==> Gets the average from a list of numeric elements, or based on the property specified.
        // data.Sum() ==> Gets the sum from a list of numeric elements, or based on the property specified.
        // data.Count() ==> Gets the Count from a list of numeric elements, or based on the property specified.

        var books = Ch56_TestData.Books;

        // SINGLE vs SINGLEORDEFAULT
        var unique = books.Single(b => b.Price == 999m);  // exactly one match
        // This throws because there are TWO books with Price == 50
        // var throwsMultiple = books.Single(b => b.Price == 50m);

        var none = books.SingleOrDefault(b => b.Price == 123m); //  returns null (because BookRow is a reference type)

        // FIRST / FIRSTORDEFAULT 
        var firstCheap = books.First(b => b.Price < 50m);  
        var firstNone = books.FirstOrDefault(b => b.Price < 0m); // null

        // LAST / LASTORDEFAULT 
        var lastByListOrder = books.Last();  // last element in list
        var lastNone = books.LastOrDefault(b => b.InStock < 0);  // null

        // AGGREGATES
        var minPrice = books.Min(b => b.Price);
        var maxPages = books.Max(b => b.Pages);
        var avgPages = books.Average(b => b.Pages);
        var sumStock = books.Sum(b => b.InStock);
        var countOutOfStock = books.Count(b => b.InStock == 0);

        Console.WriteLine($"Minimum Price={minPrice}, Maximum Pages={maxPages}, Average Pages={avgPages}");
        Console.WriteLine($"Summary Stock={sumStock}, Out of Stock={countOutOfStock}");

        Console.ReadKey();
    }
}

