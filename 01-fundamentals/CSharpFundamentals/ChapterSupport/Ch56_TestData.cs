using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.ChapterSupport
{
    internal class Ch56_TestData
    {
        // Numeric data: duplicates + negatives + zeros
        public static readonly List<int> Numbers = new()
        {
            10, -3, 0, 10, 42, 42, 7
        };

        // Reference-type data: duplicates + null-like cases (missing matches)
        public static readonly List<string> Names = new()
        {
            "Ada", "Ada", "Grace", "Linus", "Bjarne"
        };

        // Custom objects for LINQ operators
        public static readonly List<BookRow> Books = new()
        {
            new BookRow { Id = 1, Title = "C# in Depth", Author = "Jon Skeet", Price = 45m, Pages = 900, InStock = 3 },
            new BookRow { Id = 2, Title = "CLR via C#", Author = "Jeffrey Richter", Price = 50m, Pages = 800, InStock = 0 },
            new BookRow { Id = 3, Title = "Pro LINQ", Author = "Joseph Rattz", Price = 50m, Pages = 600, InStock = 5 }, // same price as Id=2
            new BookRow { Id = 4, Title = "Clean Code", Author = "Robert C. Martin", Price = 42m, Pages = 464, InStock = 2 },
            new BookRow { Id = 5, Title = "Clean Architecture", Author = "Robert C. Martin", Price = 42m, Pages = 432, InStock = 1 }, // same author + same price as Id=4
            new BookRow { Id = 6, Title = "The Mythical Man-Month", Author = "Fred Brooks", Price = 30m, Pages = 322, InStock = 2 },

            // Unique “one-off” book: use this to make Single(...) succeed
            new BookRow { Id = 999, Title = "Unique One-Off", Author = "Unique Author", Price = 999m, Pages = 1, InStock = 1 }
        };

        public sealed class BookRow
        {
            public int Id { get; init; }
            public string Title { get; init; } = "";
            public string Author { get; init; } = "";
            public decimal Price { get; init; }
            public int Pages { get; init; }
            public int InStock { get; init; }
        }
    }
}
   