using System;
using System.Collections.Generic;
using CSharpFundamentals.ChapterSupport;
using CSharpFundamentals.Debugging;
using System.Text;
using System.Linq;

// Validate inputs before processing to prevent invalid program states.
// Key terms in this chapter:
// Defensive Programming: Writing code that checks assumptions early.
// Guard Clause: An early validation check that stops execution when input is invalid.
// ArgumentOutOfRangeException: Thrown when a value is outside allowed range.
// ArgumentNullException: Thrown when a required reference argument is null.
// Meaningful Exception Message: A message that explains what is wrong and why.

namespace CSharpFundamentals.Debugging
{
    internal class Ch65_DefensiveProgramming_GuardClauses
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2 }; 
            var smallests = GetSmallests(numbers, 3); //client of method sends wrong data for exception. Must be between 1 and no. of list elements.
            // var smallests = GetSmallests(null, 3); // if instead of numbers, we used null, we would get a no-reference exception, which we handle bellow
            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadLine();
        }

        public static List<int> GetSmallests(List<int> list, int count) //list will cause side effects
            // conditional statement used here to ensure Count is not greater than the number of elements in this list
        {
            // if (list == null) // ArgumentNullException
            // throw new ArgumentException("list");

            if (count > list.Count || count <=0 ) // check for count being larger than the no. of elements in this list
                throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in this list."); // Meaningful Exception Message
            // now problem is PARTIALLY solved. Prevents application from entering the wrong state

            var buffer = new List<int>(list); 
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var minim = GetSmallest(buffer); 
                smallests.Add(minim);
                buffer.Remove(minim); 
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0]; //failure point
            // to solve, we may either use a conditional statement here to ensure he list will not be empty, but
            // it is wiser to use one in thr GetSmallests method instead

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}