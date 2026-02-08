using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals.ChapterSupport
{
    public class Ch51_BookDatabase
    {
        public static IEnumerable<Ch51_Book> GetBooksData()  //method that RETURNS(actionj) new list
        {
            return new List<Ch51_Book>
            {
                new Ch51_Book(121, "Harry Potter and the Sorcere's Stone", 800, "J.K. Rowling"),
                new Ch51_Book(186, "Tell me your Dreams", 600, "Sidney Sheldon"),
                new Ch51_Book(112, "The Monk who sold his Ferrari", 350, "Robin Sharma"),
                new Ch51_Book(145, "Half Girlfriend", 180, "Chetan Bhagat"),
                new Ch51_Book(167, "Harry Potter and the Half Blood Prince", 800, "J.K. Rowling"),
                new Ch51_Book (133, "Who will Cry When you Die", 250, "Robin Sharma"),
                new Ch51_Book(177, "The 7 Habits of Highly Effective People", 1100,"Stephen Covey")
            };
        }
    }
}
