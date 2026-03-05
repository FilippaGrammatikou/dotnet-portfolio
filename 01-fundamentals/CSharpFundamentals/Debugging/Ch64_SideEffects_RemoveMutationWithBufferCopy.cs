using System;
using System.Collections.Generic;
using CSharpFundamentals.ChapterSupport;
using CSharpFundamentals.Debugging;
using System.Text;
using System.Linq;

// Identify and eliminate a side effect caused by mutating input data.
// Key terms in this chapter:
// Side Effect: A method changes data/state outside its intended output.
// Mutation: Modifying an existing object or collection.
// Input List: The original data passed into a method.
// Buffer Copy: A temporary copy used for processing so the original stays unchanged.

namespace CSharpFundamentals.Debugging
{
    internal class Ch64_SideEffects_RemoveMutationWithBufferCopy
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2 }; // "OUT OF RANGE" Exception on porpuse to create a side effect 
            // We temporarily used all 6 digits while creating the buffer and replacing list with it(and in smallests with numbers)
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadLine();
        }

        public static List<int> GetSmallests(List<int> list, int count) //list will cause side effects
        {
            var buffer = new List<int>(list); //BUFFER for solving side effect
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var minim = GetSmallest(buffer); //replace lsit with buffer
                smallests.Add(minim);
                buffer.Remove(minim); //replace list with buffer
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {

            var min = list[0]; //failure point

            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}