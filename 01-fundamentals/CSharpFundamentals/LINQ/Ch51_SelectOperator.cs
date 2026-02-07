using CSharpFundamentals.ChapterSupport;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;

namespace CSharpFundamentals.LINQ;

public static class Ch51_SelectOperator
{
    public static void Run()
    {
        // Chapter 51: NestedLoops
        // Language Integrated Query || 2 syntaxes: Method Based & Query Based
        // LINQ applications: linq to Objects(collections, files,Strings,etc)
        //                                 linq to entities(entity framework)
        //                                 ling to xml(xml docs)
        //                                 linq to datasets(ado.net data sets)
        //-------------------------------//

        // Method based: var output = books.Where(condition); ->lead to lambda expressions
        // Query based: var output = from b in books where condition
        //                                                                       orderby property
        //                                                                       select property; (query syntax MUST end with select or group clause)
        // it is allowed to mix the syntaxes
        //-------------------------------//

        // SELECT OPERATOR
        // used for selecting any particular property or object. Also allows to define a new type with selected property
        // var authors = books.Select(b => b.Author);  OR var authors = from b in books select b.Author;
        // defining a new type using Select
        // var data = books.Select(b=>new{
        //                  BookName = b.Name,
        //                  Cost = b.Price});
        //-------------------------------//

       var books = Ch51_BookDatabase.GetBooksData(); // imports all the book data from the DB 

        /* var data = books.Select(b => b.Author); // METHOD Based
         // var data = from b in books select b.Author; //QUERY Based
         foreach(var item in data)
         {
             Console.WriteLine(item);
         }*/

        // If we wish to extract MORE THAN ONE data category((eg Author), we do as follows:
        /* var data = books.Select(b => new{ // METHOD Based
             author = b.Author, 
             price = b.Price,
             id = b.Id,
             bookName = b.Name
         });*/

        // var data = from b in books select new {    // QUERY Based
        //              author = b.author,
        //              price = b.Price,
        //              id = b.Id,
        //              bookName = b.Name              
        // };

        // Or, we can create a TOUPLE, if we don't wish to use new
        var data = books.Select(b => (author: b.Author, price: b.Price, id: b.Id, bookName: b.Name));


        foreach(var item in data)
        {
            Console.WriteLine($"{item.bookName} - {item.author} - {item.price}");
        }

        //There is a shortcut for the foreach method, but it doesn't work with enum, therefore, we need to turn the touple into a list
        // var data = books.Select(b => (author: b.Author, price: b.Price, id: b.Id, bookName: b.Name)).ToList;
        // data.ForEach(b => Console.WriteLine($"{b.bookName} - {b.author} - {b.price}");

        Console.ReadKey();
    }
}
