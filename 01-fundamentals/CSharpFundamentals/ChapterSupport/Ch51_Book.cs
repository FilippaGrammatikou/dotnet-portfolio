using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.ChapterSupport
{
    public class Ch51_Book
    {
        public int Id { get; set;  }
        public String Name { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public Ch51_Book(int id, string name, double price, string author)
        {
            Id = id;
            Name = name;
            Price = price;
            Author = author;
        }
    }
}
