using System;
using System.Collections.Generic;
using CSharpFundamentals.ChapterSupport;
using CSharpFundamentals.Debugging;
using System.Text;
using System.Linq;

// Learn how to debug crashes and manage breakpoints efficiently.
// Key terms in this chapter:
// Exception: A runtime error that interrupts program execution.
// Breakpoints Window: A panel listing all breakpoints in the project.
// Continue (F5): Resume execution until the next breakpoint / crash.
// Restart Debugging (Ctrl+Shift+F5): Restart current debug session quickly.
// Disable vs Delete Breakpoints:
// * Disable = keep breakpoint but ignore it temporarily
// * Delete  = remove breakpoint entirely

namespace CSharpFundamentals.Debugging
{
    internal class Ch63_Exceptions_BreakpointsWindow_Restart
    {
        public static void Run()
        {
            var numbers = new List<int> { 1, 2}; //reduce the list to 2 numbers on porpuse. It will cause an "OUT OF RANGE" Exception
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);

            Console.ReadLine();
        }

    public static List<int> GetSmallests(List<int> list, int count)
    {
        var smallests = new List<int>();

        while (smallests.Count < count)
        {
            var minim = GetSmallest(list); 
            smallests.Add(minim);
            list.Remove(minim);
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