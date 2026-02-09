using System;
using System.Collections.Generic;
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
    }
}

