using System;
using System.Collections.Generic;
using System.Text;

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




    }
}
